using UnityEngine;

[CreateAssetMenu(fileName = "CharacterSO", menuName = "Characters/CharacterSO")]
public class CharacterSO : ScriptableObject
{
    public string characterName;
    public Sprite characterSprite;
    
    public int fireRate,damage,range;
    
}

public enum TowerType
{
    archer,mage,knight
}
