using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Characterselect : MonoBehaviour
{
    public CharacterSO[] characters;
    public List<Button> characterButtons;
    public Transform characterSelectParent;
    public GameObject characterSelectPrefab;
    
    public static Characterselect Instance;
    public UnityEvent onTowerSelected;
    [ContextMenu("Instantiate Character Select")]

     void Start()
    {
        Instance = this;
    }
    public void InstantiateCharacterSelect()
    {
        foreach(CharacterSO character in characters)
        {
            GameObject tmp = Instantiate(characterSelectPrefab, characterSelectParent);
            Image portrait = tmp.GetComponentsInChildren<Image>()[1];
            portrait.sprite = character.characterSprite;
            Button b = tmp.GetComponent<Button>();

            b.onClick.AddListener(delegate { SelectCharacter(character); });
            characterButtons.Add(b);
            
            
        }
    }

    public void SelectCharacter(CharacterSO c)
    {
        Charactersington.Instance.SetSelectedCharacter(c);
        onTowerSelected?.Invoke();

    }

    public void DesableButtons()
    {
        foreach(Button b in characterButtons)
        {
           b.enabled = false;
        }
    }

    public void EnableButtons()
    {
        foreach(Button b in characterButtons)
        {
           b.enabled = true;
        }
    }
}


