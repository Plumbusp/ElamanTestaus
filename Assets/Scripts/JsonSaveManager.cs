using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class JsonSaveManager
{
    private static string directory = "/SaveData/";
    public static void SaveFile(ISavable so)
    {
        string dirPath = Application.persistentDataPath + directory;
        if (!Directory.Exists(dirPath))
        {
            System.IO.Directory.CreateDirectory(dirPath);        // Create directory if it not exists
        }
         
        string saveData = JsonUtility.ToJson(so);             // To covert ISavable to JSON 
        File.WriteAllText(dirPath + so.fileName, saveData);   // Save Json into file
        
        //SAVE JSON to file
    }
    public static string LoadFile(ISavable so)
    {
        string fullPath = Application.persistentDataPath + directory + so.fileName;
        if(!File.Exists(fullPath))
        {
            return so.currentValue;
        }
        string savedata = File.ReadAllText(fullPath);  //Get File with JSON
        ISavable savable = JsonUtility.FromJson<ISavable>(savedata);   //Convert from JSON to ISavable
        return savable.currentValue;               // return ISavable object
        
    }
    public static void DiscardFile(ISavable so)
    {
        string fullPath = Application.persistentDataPath + directory + so.fileName;
        if(File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }
    }
               
}
