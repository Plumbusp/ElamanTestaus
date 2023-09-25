using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ShopManager : MonoBehaviour, ISavable
{
    //[SerializeField] private Transform sofaDisplacement;
    //[SerializeField] private Transform chairDispalcement;
    //[SerializeField] private Transform tableDisplacement;
    //[SerializeField] private Transform fridgeDispacement;

    public delegate void SettingItemBought(string name);
    public static event SettingItemBought OnSetItemBought;

    [SerializeField] private Image sofa;
    [SerializeField] private Image chair;
    [SerializeField] private Image table;
    [SerializeField] private Image fridge;
    [SerializeField] private Image carpet;
    [SerializeField] private Image tv;

    private List<string> BoughtItems = new List<string>();
    private List<Image> LittleRoomsImages = new List<Image>();
    public List<ItemInfoScriptable> Items = new List<ItemInfoScriptable>();

    //void Start()
    //{
    //    foreach(ItemInfo info in test)
    //    {
    //        Debug.Log(info.itemName + info.isBought);
    //    }
    //}

    private void OnEnable()
    {
        ItemInfo.OnItemBought += PlaceBrandNewItem;
    }
    private void OnDisable()
    {
        ItemInfo.OnItemBought -= PlaceBrandNewItem;
        BoughtItems = null;
    }
    private void Awake()
    {
        LittleRoomsImages.Add(sofa);
        LittleRoomsImages.Add(chair);
        LittleRoomsImages.Add(table);
        LittleRoomsImages.Add(fridge);
        LittleRoomsImages.Add(tv);
        LittleRoomsImages.Add(carpet);

    }
    public void LoadData(DataObject data)
    {
        foreach(Image image in LittleRoomsImages)
        {
            image.sprite = null;
        }
        foreach(string boughtItemName in data.BoughtItems)
        {
            this.BoughtItems.Add(boughtItemName);
            OnSetItemBought?.Invoke(boughtItemName);
        }
    }

    public void SaveData(ref DataObject data)
    {
        foreach (string item in BoughtItems)
        {
            data.BoughtItems.Add(item);
        }
    }

    private void PlaceBrandNewItem(string whatIsItsName, Sprite sprite, TypesNames.ItemType whichType)
    {
        BoughtItems.Add(whatIsItsName);
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
