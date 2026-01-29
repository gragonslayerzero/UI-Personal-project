using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class pauseinput : MonoBehaviour
{
    private Pause gameInputs; // Reference to the generated C# class

    private void Awake()
    {
        gameInputs = new Pause();
        // Subscribe to the 'Pause' action event when it's performed (pressed)
        gameInputs.UI.freeze.performed += OnEscapePressed; 
    }

    private void OnEnable()
    {
        gameInputs.UI.Enable(); // Enable the UI Action Map
    }

    private void OnDisable()
    {
        gameInputs.UI.Disable(); // Disable the UI Action Map when the object is disabled
    }

    private void OnEscapePressed(InputAction.CallbackContext context)
    {
        
        SceneManager.LoadScene(2); 
        
    }

   
    

   
       
    
}
