using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class PlayerChoices 
{
   // private static string hamstersName;
   // private static float hamstersHealth;
    private static string food;
    private static Image foodImage;
    private static string weapon;
    private static Image weaponImage;
    private static string house;
    private static Image houseImage;

    public delegate void SetChoice(Sprite whichSprite);
    public static event SetChoice OnFoodChoiceSet;
    public static event SetChoice OnweaponChoiceSet;
    public static event SetChoice OnHousedChoiceSet;
    // public static void HamsterName(string name)
    //{
    //    hamstersName = name;
    //}
    // public static void HamsterHealth(float health)
    //{
    //   hamstersHealth = health;
    // }
    public static void SetFood(string whichFood, Sprite whichSprite)
    {
        food = whichFood;
        foodImage.sprite = whichSprite;
        OnFoodChoiceSet?.Invoke(whichSprite);
    }
    public static void SetWeapon(string whichWeapon, Sprite whichSprite)
    {
        weapon = whichWeapon;
        weaponImage.sprite = whichSprite;
        OnweaponChoiceSet?.Invoke(whichSprite);
    }
    public static void SetHouse(string whichHouse, Sprite whichSprite)
    {
        house = whichHouse;
        houseImage.sprite = whichSprite;
        OnHousedChoiceSet?.Invoke(whichSprite);
    }


    //public static string SetName()
    //{
    //    return hamstersName;
    //}
    //public static float GetHealth()
    // {
    //    return hamstersHealth;
    //}
     public static string GetFood()
    {
        return food;
    }
    public static string GetWeapon()
    {
        return weapon;
    }
    public static string GetHouse()
    {
        return house;
    }

}
