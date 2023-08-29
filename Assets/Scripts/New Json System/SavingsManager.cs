using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SavingsManager : MonoBehaviour
{
    private DataObject dataObject;
     public static SavingsManager Instance;
    List<ISavable> savableObjects;
    private void Awake()
    {
        dataObject = new DataObject();
        Instance = this;
        savableObjects = FindAllISavableObjects();
    }

    public void LoadData()
    {
        if(dataObject == null)
        {
            NewGame();
            Debug.Log("No Saved Data Was Found");
        }
        foreach(ISavable savableObject in savableObjects)
        {
            savableObject.LoadData(dataObject);
        }

        Debug.Log(dataObject.name + dataObject.health.ToString());
    }
    public void SaveData()
    {
        foreach (ISavable savableObject in savableObjects)
        {
            savableObject.SaveData(ref dataObject);
        }
    }
    public void NewGame()
    {

    }

    private List<ISavable> FindAllISavableObjects()
    {
         IEnumerable<ISavable>allSavableObjects =  FindObjectsOfType<MonoBehaviour>().OfType<ISavable>();
        return new List<ISavable>(allSavableObjects);
       
    }
    private void OnDisable()
    {
        SaveData();
        LoadData();

    }
}
