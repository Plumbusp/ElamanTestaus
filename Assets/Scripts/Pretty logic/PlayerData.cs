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
        //hamsterHealth = new HamsterHealth(maxHealthValue, healthSlider, textForHealth);
       // hamsterName = new HamsterName(textForName);
    }


}

