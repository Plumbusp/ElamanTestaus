using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class JSONFileHandler 
{
    private string _directoryName;
    private string _fileName;
   public JSONFileHandler(string directoryName, string fileName)
    {
        _directoryName = directoryName;
        _fileName = fileName;
    }

    public DataObject Load()
    {
        DataObject loadedData = null;
        string filePath = Path.Combine(Application.dataPath, _fileName);   // Create file path using directory path

        try
        {                    // variable to store string data in JSON format
            string jsonData = File.ReadAllText(filePath);
            loadedData = JsonUtility.FromJson<DataObject>(jsonData);   // convert from json to DataObject and return DataObject Loaded Data
            return loadedData;
        }
        catch(Exception e)
        {
            Debug.LogError("Unsucsess trying loaded data from path " + filePath + "...." + e);
        }
        return loadedData;
    }
    public void Save(DataObject data)
    {
        string filePath = Path.Combine(Application.dataPath, _fileName);   // Create file path using directory path
        try
        {
            string jsonData = JsonUtility.ToJson(data);
            File.WriteAllText(filePath, jsonData);
        }
        catch(Exception ex)
        {
            Debug.LogError("Unsucsess trying save data to path " + filePath + "...." + ex);
        }
    }
}
