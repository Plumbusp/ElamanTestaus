using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Buyer : MonoBehaviour, ISavable
{
    public Text text;
    float money = 999f;
    private void OnEnable()
    {
        text.text = "money:" + money.ToString();
    }
    public void BuyItem()
    {
        GameObject buttonRef = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<EventSystem>().currentSelectedGameObject;
        if(buttonRef != null)
        {
             money = buttonRef.GetComponent<ItemInfo>().Buy(money);
             text.text = "money:" + money.ToString();
        }

    }

    public void LoadData(DataObject data)
    {
        money = data.money;
        text.text = "money:" + money.ToString();
    }

    public void SaveData(ref DataObject data)
    {
        data.money = this.money;
    }
}
