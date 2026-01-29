using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;

public class Towerselect : MonoBehaviour
{
    string[] towerOptions;


    [SerializeField] private TMP_Dropdown dropdownMenu;

    public Sprite archerSprite, mageSprite, knightSprite;



    void Awake()
    {
        towerOptions = System.Enum.GetNames(typeof(TowerType));

        List<string> options = new List<string>(towerOptions);
        populatedropdown(options);

        Charactersington.Instance.SetTowerSprite(archerSprite);
        Charactersington.Instance.SetTowerType("archer");
        Charactersington.Instance.SetTowerSprite2(archerSprite);
        Charactersington.Instance.SetTowerType2("archer");
        Charactersington.Instance.SetTowerSprite3(archerSprite);
        Charactersington.Instance.SetTowerType3("archer");

    }

    public void SelectTower(int index)
    {


        switch (index)
        {
            case 0:
                Charactersington.Instance.SetTowerSprite(archerSprite);
                Charactersington.Instance.SetTowerType("archer");
                break;
            case 1:
                Charactersington.Instance.SetTowerSprite(mageSprite);
                Charactersington.Instance.SetTowerType("mage");
                break;
            case 2:
                Charactersington.Instance.SetTowerSprite(knightSprite);
                Charactersington.Instance.SetTowerType("knight");
                break;
            default:
                Charactersington.Instance.SetTowerSprite(archerSprite);
                Charactersington.Instance.SetTowerType("archer");
                break;

        }


    }

    public void SelectTower2(int index)
    {

        switch (index)
        {
            case 0:
                Charactersington.Instance.SetTowerSprite2(archerSprite);
                Charactersington.Instance.SetTowerType2("archer");
                break;
            case 1:

                Charactersington.Instance.SetTowerSprite2(mageSprite);
                Charactersington.Instance.SetTowerType2("mage");
                break;
            case 2:
                Charactersington.Instance.SetTowerSprite2(knightSprite);
                Charactersington.Instance.SetTowerType2("knight");
                break;
            default:
                Charactersington.Instance.SetTowerSprite2(archerSprite);
                Charactersington.Instance.SetTowerType2("archer");
                break;

        }


    }

    public void SelectTower3(int index)
    {

        switch (index)
        {
            case 0:
                Charactersington.Instance.SetTowerSprite3(archerSprite);
                Charactersington.Instance.SetTowerType3("archer");
                break;
            case 1:

                Charactersington.Instance.SetTowerSprite3(mageSprite);
                Charactersington.Instance.SetTowerType3("mage");
                break;
            case 2:

                Charactersington.Instance.SetTowerSprite3(knightSprite);
                Charactersington.Instance.SetTowerType3("knight");
                break;

            default:
                Charactersington.Instance.SetTowerSprite3(archerSprite);
                Charactersington.Instance.SetTowerType3("archer");
                break;

        }


    }




    void populatedropdown(List<string> options_)
    {
        dropdownMenu.ClearOptions();
        dropdownMenu.AddOptions(options_);
    }




}
