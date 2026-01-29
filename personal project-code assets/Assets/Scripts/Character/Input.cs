

using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
   public InputAction moveAction, jumpAction;
   Transform t;

   public int movementSpeed = 5;

   Vector2 movevector;

    private void Start()
    {
        movevector = Vector2.zero;
        moveAction.Enable();
        jumpAction.Enable();
        t = GetComponent<Transform>();
        moveAction.performed += MoveCharacter;
        moveAction.canceled += MoveCharacter;
        jumpAction.performed += JumpCharacter;
        jumpAction.canceled += JumpCharacter;

    }

    private void MoveCharacter(InputAction.CallbackContext context)
    {
        var tmp = context.ReadValue<Vector2>();
        movevector = new Vector2(tmp.x, tmp.y);
    }

    private void JumpCharacter(InputAction.CallbackContext context)
    {
        t.position += new Vector3(0, 2, 0);
    }

    private void FixedUpdate()
    {
        t.position += new Vector3(movevector.x, 0, movevector.y) * movementSpeed * Time.deltaTime;
    }
}
