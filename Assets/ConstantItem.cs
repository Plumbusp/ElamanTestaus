using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantItem : MonoBehaviour
{
    public delegate void BuyngItem(string itemName, Sprite itemSprite, TypesNames.ItemType whichType);
    public static event BuyngItem OnItemBought;
    public static void InvokOnItemBought(string itemName, Sprite itemSprite, TypesNames.ItemType whichType)
    {
        OnItemBought.Invoke(itemName, itemSprite, whichType);
    }
}
