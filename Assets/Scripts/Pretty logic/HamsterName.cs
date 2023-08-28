using UnityEngine;
using System.IO;
using TMPro;

public class HamsterName : ISavable
{
    string namePath;
    TMP_Text _textForName;

    public string fileName { get; private set; }
    public string currentValue { get ; set; }
    public string initialValue { get; private set; }

    public HamsterName(TMP_Text textForName)
    {
        fileName = "hamsterName.txt";
        initialValue = " initial value";
        _textForName = textForName;
        currentValue = " pupu ";
    }

    public void SetValue<T>(T name)
    {
        currentValue = name.ToString();
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
