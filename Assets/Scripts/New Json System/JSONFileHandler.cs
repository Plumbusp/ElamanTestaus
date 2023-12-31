using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class JSONFileHandler 
{
    private string _fileName;
    private string filePath;
   public JSONFileHandler(string directoryName, string fileName)
    {
        _fileName = fileName;
        filePath = Path.Combine(Application.dataPath, _fileName);   // Create file path using directory path
        if(!File.Exists(filePath))
        {
            File.Create(filePath);
        }
    }

    public DataObject Load()
    {
        DataObject loadedData = null;
        string dataToLoad = string.Empty;            // variable to store string data in JSON format
        try
        {                    
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
        if (!File.Exists(filePath))
        {
            File.Create(filePath);
        }
        try
        {
             using (StreamWriter writer = new StreamWriter(filePath))
             {
                  string dataToSave = JsonUtility.ToJson(data, true);
                  writer.Write(dataToSave);
             }
            
        }
        catch(Exception ex)
        {
            Debug.LogError("Unsucsess trying save data to path " + filePath + "...." + ex);
        }
    }
    public void DiscardData()
    {
        if(File.Exists(filePath))
        {
            File.Create(filePath);
        }
       // return Load();
    }

}
