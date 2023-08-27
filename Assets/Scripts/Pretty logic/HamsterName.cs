using UnityEngine;
using System.IO;
using TMPro;

public class HamsterName : ISavable
{
    string namePath;
    TMP_Text _textForName;

    public string fileName { get; private set; }
    public string currentValue { get ; set; }

    public HamsterName(TMP_Text textForName)
    {
        _textForName = textForName;
        currentValue = string.Empty;
    }

    public void SetValue<T>(T name)
    {
        currentValue = "Hamsters's name: " + name.ToString();
        _textForName.text = currentValue;
    }

    /*
    public void SaveName(string nameToSave)
    {
        SaveData(namePath, nameToSave);
    }
    public string LoadName()
    {
        if(LoadData(namePath) == null)
        {
            SetName("");
            return " ";
        }
        hamsterName = LoadData(namePath);
        SetName(hamsterName);
        return hamsterName;
    }
    */


}
