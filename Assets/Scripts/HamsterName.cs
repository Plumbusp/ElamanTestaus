using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class HamsterName : MonoBehaviour, ISavable
{
    private string name = "none";
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_Text textForName;

    public void SaveData(ref DataObject data)
    {
        data.name = name;
    }
    public void LoadData(DataObject data)
    {       
        SetName(data.name);
    }

    public void SetNameThroughtInput()
    {
        SetName(inputField.text);
        inputField.text = "";
    }
    private void SetName(string name)
    {
        this.name = name;
        textForName.text = "Hamster's name: " + this.name;
    }
}
