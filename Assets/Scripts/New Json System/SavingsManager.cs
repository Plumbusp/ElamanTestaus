using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SavingsManager : MonoBehaviour
{
    public static SavingsManager Instance;

    JSONFileHandler fileHandler;
    DataObject dataObject;

    string directoryName = "SavedData";
    string fileName = "PlayerChoices.json";
    List<ISavable> savableObjects;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        fileHandler = new JSONFileHandler(directoryName, fileName);
        dataObject = new DataObject();
        savableObjects = FindAllISavableObjects();
        Instance = this;
    }

    public void LoadData()
    {
        dataObject = fileHandler.Load();

        if(dataObject == null)
        {
            NewGame();
            //Debug.Log("No Saved Data Was Found");
            return;
        }
        foreach(ISavable savableObject in savableObjects)
        {
            savableObject.LoadData(dataObject);
        }     
        //Debug.Log(dataObject.name + dataObject.health.ToString() + "LOADED");
    }
    public void SaveData()
    {
        foreach (ISavable savableObject in savableObjects)
        {
            savableObject.SaveData(ref dataObject);
        }

        fileHandler.Save(dataObject);
    }
    private void NewGame()
    {
        fileHandler.DiscardData();
        dataObject = new DataObject();
        foreach (ISavable savableObject in savableObjects)
        {
            savableObject.LoadData(dataObject);
        }
    }
    public bool HasSavedData()
    {
        dataObject = fileHandler.Load();
        if(dataObject == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private List<ISavable> FindAllISavableObjects()
    {
         IEnumerable<ISavable>allSavableObjects = FindObjectsOfType<MonoBehaviour>().OfType<ISavable>();
        return new List<ISavable>(allSavableObjects);
       
    }
}
