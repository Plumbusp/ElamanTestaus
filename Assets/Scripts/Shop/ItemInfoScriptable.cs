using UnityEngine;
using UnityEngine.UI;
using TMPro;
[CreateAssetMenu(fileName = "new shop choice", menuName = "Choices for shop /Buyable Item",order = 0)]
public class ItemInfoScriptable: ScriptableObject
{
    public float price;
    public string itemName;
    public TypesNames.ItemType itemType;
    [HideInInspector] public bool isBought;
    public Sprite sprite;

    private void OnEnable()
    {
        isBought = false;
        ShopManager.OnSetItemBought += (string itemName) =>
        {
            if (itemName == this.itemName)
            {
                SetBought();
            }
        };
    }
    private void OnDisable()
    {
        ShopManager.OnSetItemBought -= (string itemName) =>
        {
            if (itemName == this.itemName)
            {
                SetBought();
            }
        };
    }
    public void SetBought()
    {
        isBought = true;
    }
}