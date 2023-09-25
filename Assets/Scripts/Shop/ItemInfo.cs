using UnityEngine;
using UnityEngine.UI;
using TMPro;
[RequireComponent(typeof(Button))]
public class ItemInfo : MonoBehaviour, IBuyableItem
{
    public GameObject boughtCover;
    public float price;
    public string itemName;
    public TypesNames.ItemType itemType;
    [HideInInspector] public bool isBought;
    [SerializeField] private TMP_Text itemNameText;
    [SerializeField] private Image Image;
    private Sprite sprite;

    public delegate void BuyngItem(string itemName, Sprite itemSprite, TypesNames.ItemType whichType);
    public static event BuyngItem OnItemBought;

    private void Awake()
    {
        itemNameText.text = itemName;
        sprite = Image.sprite;
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

    public void SetBought(string itemName)
    {
        if(this.itemName == itemName)
        {
            MakeBought();
        }
    }
    public void SetUnbought()
    {
        isBought = false;
        GetComponent<Button>().enabled = true;
        boughtCover.SetActive(false);
    }
    private void MakeBought()
    {
        isBought = true;
        GetComponent<Button>().enabled = false;
        boughtCover.SetActive(true);
        OnItemBought?.Invoke(itemName, sprite, itemType);  // Invoking event telling that some item is bought and specify that item with its name
    }
}