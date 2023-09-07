using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DataObject 
{
    public string name;
    public float health;
    public Sprite foodSprite;
    public Sprite houseSprite;
    public Sprite miraculousSprite;
    public Image[] rodentType;
    public enum RodentType
    {
        hamster,
        rat,
        mouse
    }
    public RodentType theRodentType;
    public DataObject()
    {
        theRodentType = RodentType.hamster;
        name = "some name";
        health = 100;
    }
}
