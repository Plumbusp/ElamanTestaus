using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private float maxHealthValue;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private TMP_Text textForHealth;
    [SerializeField] private TMP_Text textForName;
    [SerializeField] private TMP_InputField nameInputField;

    HamsterHealth hamsterHealth;
    HamsterName hamsterName;

    //private Dictionary<string, string> playerData = new Dictionary<string, string>();
    public void Awake()
    {
        hamsterHealth = new HamsterHealth(maxHealthValue, healthSlider, textForHealth);
        hamsterName = new HamsterName(textForName);
    }

    public void SavePlayerData()
    {
        JsonSaveManager.SaveFile(hamsterName);
        JsonSaveManager.SaveFile(hamsterHealth);
    }
    public void LoadPlayerData()      // if target data is not null, then load it
    {
        hamsterHealth.SetValue(JsonSaveManager.LoadFile(hamsterHealth));
        hamsterName.SetValue(JsonSaveManager.LoadFile(hamsterName));
    }
    public void SaveNameLocaly()
    {
        hamsterName.SetValue(nameInputField.text);
        nameInputField.text = "";
    }

    public void DiscardAllData()
    {
        JsonSaveManager.DiscardFile(hamsterHealth);
        JsonSaveManager.DiscardFile(hamsterName);
    }
    public void DecreaseHealth()
    {
        hamsterHealth.Decrease();
    }
    public void IncreaseHealth()
    {
        hamsterHealth.Increase();
    }

}

