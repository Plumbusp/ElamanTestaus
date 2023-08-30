using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class UIManager : MonoBehaviour
{
    [SerializeField] private float maxHealthValue;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private TMP_Text textForHealth;
    [SerializeField] private TMP_Text textForName;
    [SerializeField] private TMP_InputField nameInputField;
}

