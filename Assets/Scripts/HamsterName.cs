using UnityEngine;
using System.IO;
using TMPro;

public class HamsterName : SavingsController
{
    string hamsterName;
    string namePath;
    TMP_Text _textForName;
    
    public HamsterName(TMP_Text textForName)
    {
        _textForName = textForName;
        namePath = CreatePath("name.txt");
    }
    
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
    
    private void SetName(string name)
    {
        this.hamsterName = "Hamsters's name: " + name;
        _textForName.text = this.hamsterName;
    }
    public void DiscardName()
    {
        DiscardData(namePath);
    }
}
