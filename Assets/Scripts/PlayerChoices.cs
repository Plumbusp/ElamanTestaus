using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChoices: MonoBehaviour, ISavable
{
    public static PlayerChoices instance;
    public delegate void SetChoice(Sprite whichSprite);
    public static event SetChoice OnFoodChoiceSet;
    public static event SetChoice OnweaponChoiceSet;
    public static event SetChoice OnHousedChoiceSet;

    //private string food;
    [SerializeField] private Image foodImage;
    //private string weapon;
    [SerializeField] private Image miraculousImage;
    //private string house;
    [SerializeField] private Image houseImage;

    private void Awake()
    {
        if(instance != null)
        {
            instance = null;
        }
        instance = this;
    }
    public void LoadData(DataObject data)
    {
        this.foodImage.sprite = data.foodSprite;
        this.miraculousImage.sprite = data.miraculousSprite;
        this.houseImage.sprite = data.houseSprite;
    }

    public void SaveData(ref DataObject data)
    {
        data.foodSprite = this.foodImage.sprite;
        data.miraculousSprite = this.miraculousImage.sprite;
        data.houseSprite = this.houseImage.sprite;
    }

    public void SetFood(Sprite whichSprite)
    {
        foodImage.sprite = whichSprite;
        OnFoodChoiceSet?.Invoke(whichSprite);
        Debug.Log("food choisen");
    }
    public void SetWeapon(Sprite whichSprite)
    {
        miraculousImage.sprite = whichSprite;
        OnweaponChoiceSet?.Invoke(whichSprite);
    }
    public void SetHouse( Sprite whichSprite)
    {
        houseImage.sprite = whichSprite;
        OnHousedChoiceSet?.Invoke(whichSprite);
    }
}
