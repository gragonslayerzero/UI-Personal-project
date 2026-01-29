using UnityEngine;

public class SetImageTowers : MonoBehaviour
{
   void Start()
    {
       GetComponent<UnityEngine.UI.Image>().sprite = Charactersington.Instance.towerSprite;

    }
}
