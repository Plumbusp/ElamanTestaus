using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    [SerializeField] ItemInfoScriptable itemInfo;
    [SerializeField] private TMP_Text itemNameText;
    [SerializeField] private Image image;
    [SerializeField] private GameObject boughtCover;

    public delegate void BuyngItem(string itemName, Sprite itemSprite, TypesNames.ItemType whichType);
    public static event BuyngItem OnItemBought;
    private void OnEnable()
    {
        if(itemInfo.isBought)
        {
            MakeBought();
        }
    }
    private void Awake()
    {
        itemNameText.text = itemInfo.itemName;
        image.sprite = itemInfo.sprite;
    }
    public float Buy(float amountOfYourMoney)
    {
        if (!itemInfo.isBought)
        {
            if (amountOfYourMoney >= itemInfo.price)
            {
                MakeBought();
                OnItemBought.Invoke(itemInfo.itemName, itemInfo.sprite, itemInfo.itemType);
                return amountOfYourMoney - itemInfo.price;
            }
        }
        return amountOfYourMoney;
    }

    public void MakeBought()
    {
        itemInfo.SetBought();
        GetComponent<Button>().enabled = false;
        boughtCover.SetActive(true);
        OnItemBought.Invoke(itemInfo.itemName, itemInfo.sprite, itemInfo.itemType);
    }

}
