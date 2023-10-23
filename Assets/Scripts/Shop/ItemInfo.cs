using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

[RequireComponent(typeof(Button))]
public class ItemInfo : MonoBehaviour
{

    [SerializeField] private GameObject boughtCover;
    [SerializeField] private float price;
    public string itemName;
    public TypesNames.ItemType itemType;
    [HideInInspector] public bool isBought;
    [SerializeField] private TMP_Text itemNameText;
    [SerializeField] private TMP_Text itemPriceText;
    [SerializeField] Sprite sprite;

    private void Awake()
    {
        itemNameText.text = itemName;
        itemPriceText.text = price.ToString();
    }
    public float Buy(float amountOfYourMoney)
    {
        if(!isBought)
        {
            if (amountOfYourMoney >= price)
            {
                MakeBought();
                return amountOfYourMoney - price;
            }
        }
        return amountOfYourMoney;
    }
    public void SetUnbought()
    {
        isBought = false;
        GetComponent<Button>().enabled = true;
        boughtCover.SetActive(false);
    }
    public void MakeBought()
    {
        isBought = true;
        GetComponent<Button>().enabled = false;
        boughtCover.SetActive(true);
        ConstantItem.InvokOnItemBought(itemName, sprite, itemType);
        //OnItemBought?.Invoke(itemName, sprite, itemType);  // Invoking event telling that some item is bought and specify that item with its name
    }
    //public void FirstBought(Action<string, Sprite, TypesNames.ItemType> del)
    //{
    //    isBought = true;
    //    GetComponent<Button>().enabled = false;
    //    boughtCover.SetActive(true);
    //    del.Invoke(itemName, sprite, itemType);
    //}
}