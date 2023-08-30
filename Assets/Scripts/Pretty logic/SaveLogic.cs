using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Collections.Generic;

public class SaveLogic : SavingsController
{
    [SerializeField] private float maxHealthValue;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private TMP_Text textForHealth;
    [SerializeField] private TMP_Text textForName;
    [SerializeField] private TMP_InputField nameInputField;

    private HamsterHealth hamsterHealth;
    private HamsterName hamsterName;
    private UIManager[] PlayerDatas;

    //List<string> Datas = new List<string>();
    //  Dictionary<string, string> Datas = new Dictionary<string, string>();
    /*
    private void Awake()
    {
        hamsterHealth = new HamsterHealth(maxHealthValue, healthSlider, textForHealth);
        hamsterName = new HamsterName(textForName);
        LoadAllData();
    }
    private void LoadAllData()
    {
       foreach (PlayerData playerData in PlayerDatas)
        {
            string path = Path.Combine(Application.dataPath, playerData.key + ".txt");
            Debug.Log(path);
            string messyData = LoadData(path);
            if (messyData != null)
            {
                string[] cleanData = messyData.Split(" ");
                Datas.Add(cleanData[0], cleanData[1]);
            }
            
            if(Datas.ContainsKey("health"))
            {
                float.TryParse(Datas["health"], out float amount);
                hamsterHealth.SetHealth(amount);

            }
            else
            {
                hamsterHealth.HealthToDefault();
            }

            if(Datas.ContainsKey("name"))
            {
                hamsterName.SetName(Datas[name]);
            }
            else
            {
                hamsterName.SetName(" ");
            }
        }
    }
    public void SaveAllData()
    {
        foreach(PlayerData playerData in PlayerDatas)
        {
            Datas.Add(playerData.key, playerData.value);
        }
    }
    public void SaveNameLocaly()
    {

    }
    */
}
