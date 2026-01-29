

using UnityEngine;
using UnityEngine.UI;

public class SetImage : MonoBehaviour
{
    


    void Start()
    {
       GetComponent<Image>().sprite = Charactersington.Instance.selectedCharacter.characterSprite;

    }
}

    

