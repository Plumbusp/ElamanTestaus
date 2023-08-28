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
        JsonSaveManager.SaveFile<HamsterName>(hamsterName, hamsterName.fileName);
        JsonSaveManager.SaveFile<HamsterHealth>(hamsterHealth, hamsterHealth.fileName);
    }
    public void LoadPlayerData()      // if target data is not null, then load it
    {
        HamsterHealth newHamsterHealth = JsonSaveManager.LoadFile<HamsterHealth>(new HamsterHealth(maxHealthValue,healthSlider,textForHealth), hamsterHealth.fileName);
        Debug.Log(newHamsterHealth.currentValue);
        hamsterHealth.SetValue(newHamsterHealth.currentValue);
        HamsterName newHamsterName = JsonSaveManager.LoadFile<HamsterName>(new HamsterName(textForName), hamsterName.fileName);
        Debug.Log(newHamsterName.currentValue);
        hamsterName.SetValue(newHamsterName.currentValue);

        //string nameValue = JsonSaveManager.LoadFile<HamsterName>(hamsterName).currentValue;
        //hamsterName.SetValue(nameValue);
    }
    public void SaveNameLocaly()
    {
        hamsterName.SetValue(nameInputField.text);
        nameInputField.text = "";
    }

    public void DiscardAllData()
    {
        JsonSaveManager.DiscardFile(hamsterHealth.fileName);
        JsonSaveManager.DiscardFile(hamsterName.fileName);
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

