using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class JsonSaveManager
{
    //private static string directory = "/SaveData/";
    public static void SaveFile<T> (T so, string fileName)
    {
        
        string fullPath = Path.Combine(Application.dataPath, fileName);
        string saveData = JsonUtility.ToJson(so);             // To covert ISavable to JSON 
        File.WriteAllText(fullPath, saveData);
        Debug.Log("Everithing sabed in " + so.ToString() + saveData + "    " + fullPath);// Save Json into file
        /*
        string dirPath = Application.dataPath + directory;
        if (!Directory.Exists(dirPath))
        {
            System.IO.Directory.CreateDirectory(dirPath);        // Create directory if it not exists
        }
         */

        //SAVE JSON to file
    }
    public static T LoadFile<T>(T defaultObject, string fileName)
    {
        //string dirPath = Path.Combine(Application.dataPath, directory);   // Make directory path
        string fullPath = Path.Combine(Application.dataPath, fileName);  // Make full path to file
        if(!File.Exists(fullPath) || IsJsonEmpty(fullPath) )
        {
            Debug.Log("return initial object");
            return defaultObject;                                                        // return current object if file with data not exists
            
        }
        else
        {
            string savedata = File.ReadAllText(fullPath);   //Get File with JSON data using object's data path
            T savable = JsonUtility.FromJson<T>(savedata);   //Convert from JSON to T type object (Hamster health or Hamster name ect.)
            return savable;               // return T type object object
        }   
    }
    public static void DiscardFile(string fileName)
    {
        //string dirPath = Path.Combine(Application.dataPath, directory);   // Make directory path
        string fullPath = Path.Combine(Application.dataPath, fileName);  // Make full path to file
        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }
    }

    private static bool IsJsonEmpty(string fullPath)
    {
        string jsonContent = File.ReadAllText(fullPath);
        if (string.IsNullOrEmpty(jsonContent) || jsonContent == "{}")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
