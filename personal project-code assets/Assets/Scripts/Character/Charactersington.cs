using UnityEngine;

public class Charactersington : MonoBehaviour
{
    public static Charactersington Instance;

    public CharacterSO selectedCharacter;

    public string gamertag = "Player";
    public int skin = 0;

    public string TowerType, TowerType2, TowerType3;

    public Sprite towerSprite, towerSprite2, towerSprite3;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
       DontDestroyOnLoad(this.gameObject);
    }

    public void SetSelectedCharacter(CharacterSO character)
    {
        selectedCharacter = character;
    }
    public CharacterSO GetSelectedCharacter()
    {
        return selectedCharacter;
    }

    public void SetTowerType(string type)
    {
        TowerType = type;
    }

    public string GetTowerType()
    {
        return TowerType;
    }

    public void SetTowerSprite(Sprite sprite)
    {
        towerSprite = sprite;
    }

    public Sprite GetTowerSprite()
    {
        return towerSprite;
    }

     public void SetTowerType2(string type)
    {
        TowerType2 = type;
    }

    public string GetTowerType2()
    {
        return TowerType2;
    }

        public void SetTowerSprite2(Sprite sprite)  
        {
            towerSprite2 = sprite;
        }
        public Sprite GetTowerSprite2()
        {
            return towerSprite2;
        }

     public void SetTowerType3(string type)
    {
        TowerType3 = type;
    }

    public string GetTowerType3()
    {
        return TowerType3;
    }
        public void SetTowerSprite3(Sprite sprite)  
        {
            towerSprite3 = sprite;
        }
        public Sprite GetTowerSprite3()
        {
            return towerSprite3;
        }

    public void SetGamertag(string s) { gamertag = s; }
    public string GetGamertag() { return gamertag; }

    public void SetSkin(int index)
    {
        skin = index;
    }

    public int GetSkin() { return skin; }
}