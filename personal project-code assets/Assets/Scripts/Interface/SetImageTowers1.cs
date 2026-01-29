using UnityEngine;

public class SetImageTowers1 : MonoBehaviour
{
   void Start()
    {
       GetComponent<UnityEngine.UI.Image>().sprite = Charactersington.Instance.towerSprite2;

    }
}
