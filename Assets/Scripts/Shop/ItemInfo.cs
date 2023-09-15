using UnityEngine;
using UnityEngine.UI;
using TMPro;
[RequireComponent(typeof(Button))]
public class ItemInfo : MonoBehaviour, IBuyable
{
    public GameObject boughtCover;
    public float price;
    public string itemName;
    [HideInInspector] public bool isBought;
    [SerializeField] private TMP_Text itemNameText;
    [SerializeField] private Image Image;

    public float Buy(float amountOfYourMoney)
    {
        if(amountOfYourMoney >= price)
        {
            isBought = true;
            GetComponent<Button>().enabled = false;
            boughtCover.SetActive(true);
            return amountOfYourMoney - price;
        }
        return amountOfYourMoney;
    }
}
