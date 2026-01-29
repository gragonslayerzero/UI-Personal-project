using UnityEngine;

public class SetImageTowers2 : MonoBehaviour
{
   void Start()
    {
       GetComponent<UnityEngine.UI.Image>().sprite = Charactersington.Instance.towerSprite3;

    }
}
