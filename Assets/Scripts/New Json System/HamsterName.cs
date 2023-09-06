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
        Debug.Log(name + " saved");
    }
    public void LoadData(DataObject data)
    {       
        SetName(data.name);
        Debug.Log(name + " loaded");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(name);
        }
    }
    public void SetNameThroughtInput()
    {
        SetName(inputField.text);
        inputField.text = "";
    }
    private void SetName(string name)
    {
        this.name = "Rodent's name: " + name;
        textForName.text = this.name;
    }
}
