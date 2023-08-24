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

    [HideInInspector] public string theName;
    [HideInInspector] public string health;
    //private Dictionary<string, string> playerData = new Dictionary<string, string>();
    public void Awake()
    {
        hamsterHealth = new HamsterHealth(maxHealthValue, healthSlider, textForHealth);
        hamsterName = new HamsterName(textForName);
    }

    public void SavePlayerData()
    {
        hamsterHealth.SaveHealth();
        hamsterName.SaveName(theName);
    }
    public void LoadPlayerData()      // if target data is not null, then load it
    {
        hamsterHealth.LoadHealth();
        hamsterName.LoadName();
    }
    public void SaveNameLocaly()
    {
        theName = "Hamsters's name: " + nameInputField.text;
        textForName.text = theName;
        nameInputField.text = "";
    }

    public void DiscardAllData()
    {
        hamsterName.DiscardName();
        hamsterHealth.HealthToDefault();
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

