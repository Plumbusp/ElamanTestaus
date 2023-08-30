using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class HamsterName : MonoBehaviour, ISavable
{
    string hamsterName;
    [SerializeField] TMP_Text textForName;
    [SerializeField] TMP_InputField inputField;
    
    public HamsterName(TMP_Text textForName)
    {
        this.textForName = textForName;
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
    
    public void SetNameThroughtInput()
    {
        SetName(inputField.text);
        inputField.text = "";
    }
    private void SetName(string name)
    {
        this.hamsterName = "Hamsters's name: " + name;
        textForName.text = this.hamsterName;
    }
}
