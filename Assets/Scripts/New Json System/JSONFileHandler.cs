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
        string dataToLoad = string.Empty;
        string filePath = Path.Combine(Application.dataPath, _fileName);   // Create file path using directory path

        try
        {                    // variable to store string data in JSON format
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    dataToLoad = reader.ReadToEnd();
                }
            }
            loadedData = JsonUtility.FromJson<DataObject>(dataToLoad);
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
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    string dataToSave = JsonUtility.ToJson(data);
                    writer.Write(dataToSave);
                }
            }
        }
        catch(Exception ex)
        {
            Debug.LogError("Unsucsess trying save data to path " + filePath + "...." + ex);
        }
    }
}
