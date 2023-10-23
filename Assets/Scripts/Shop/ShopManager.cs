using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class ShopManager : MonoBehaviour, ISavable
{
    [SerializeField] private Image sofa;
    [SerializeField] private Image chair;
    [SerializeField] private Image table;
    [SerializeField] private Image fridge;
    [SerializeField] private Image carpet;
    [SerializeField] private Image tv;

    private List<Image> LittleRoomsImages = new List<Image>();
    private List<string> BoughtItems = new List<string>();
    public List<ItemInfo> Items = new List<ItemInfo>();


    private void OnEnable()
    {
        ConstantItem.OnItemBought += PlaceBrandNewItem;
    }
    private void OnDisable()
    {
        ConstantItem.OnItemBought -= PlaceBrandNewItem;
    }
    private void Awake()
    {
        LittleRoomsImages.Add(sofa);
        LittleRoomsImages.Add(chair);
        LittleRoomsImages.Add(table);
        LittleRoomsImages.Add(fridge);
        LittleRoomsImages.Add(tv);
        LittleRoomsImages.Add(carpet);
        BoughtItems = new List<string>();
    }
    public void LoadData(DataObject data)
    {
        foreach (ItemInfo item in Items)
        {
            item.SetUnbought();
        }
        foreach (Image image in LittleRoomsImages)
        {
            image.sprite = null;
        }
        BoughtItems = data.BoughtItems;
        List<string> localBoughtItems = new List<string>(this.BoughtItems);
        foreach (ItemInfo item in Items)
        {
            foreach(string itemName in localBoughtItems)
            {
                if(item.itemName == itemName)
                {
                    item.MakeBought();
                }
            }
        }
    }

    public void SaveData(ref DataObject data)
    {
        data.BoughtItems = new List<string>(this.BoughtItems);
    }

    private void PlaceBrandNewItem(string whatIsItsName, Sprite sprite, TypesNames.ItemType whichType)
    {
        int i = 0;
        foreach(string itemNamein in BoughtItems)
        {
            if(itemNamein == whatIsItsName)
            {
                i++;
            }
        }
        if(i == 0)
        {
            BoughtItems.Add(whatIsItsName);
        }
        switch (whichType)
        {
            case TypesNames.ItemType.carpet:
                carpet.sprite = sprite;
                break;
            case TypesNames.ItemType.tv:
                tv.sprite = sprite;
                break;
            case TypesNames.ItemType.chair:
                chair.sprite = sprite;
                break;
            case TypesNames.ItemType.table:
                table.sprite = sprite;
                break;
            case TypesNames.ItemType.sofa:
                sofa.sprite = sprite;
                break;
            default:
                break;
        }
    }
    private List<IBuyableItem> FindAllBuyableItems()
    {
        IEnumerable<IBuyableItem> allBuyableObjects = FindObjectsOfType<MonoBehaviour>().OfType<IBuyableItem>();
        return new List<IBuyableItem>(allBuyableObjects);

    }
}
