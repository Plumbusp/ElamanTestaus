using UnityEngine;
using System.IO;
using TMPro;

public class HamsterName : MonoBehaviour, ISavable
{
    string hamsterName;
    string namePath;
    TMP_Text _textForName;
    
    public HamsterName(TMP_Text textForName)
    {
        _textForName = textForName;
        //namePath = CreatePath("name.txt");
    }
    
    public void SaveData(ref DataObject data)
    {
        data.name = hamsterName;
    }
    public void LoadData(DataObject data)
    {
        hamsterName = data.name;
    }
    
    private void SetName(string name)
    {
        this.hamsterName = "Hamsters's name: " + name;
        _textForName.text = this.hamsterName;
    }
    public void DiscardName()
    {
        
    }
}
