using UnityEngine;
using TMPro;

public class setname : MonoBehaviour
{
    void Start()
    {
       GetComponent<TMP_Text>().text = Charactersington.Instance.gamertag;

    }
}
