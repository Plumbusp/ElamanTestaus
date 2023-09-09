using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class SavingsController
{
    protected void SaveData(string path, string data)
    {
        using (StreamWriter sw = new StreamWriter(path, append: false))
        {
            sw.WriteLine(data.ToString());
        }
    }

    protected string LoadData(string path)
    {
        if(File.Exists(path))
        {
            using (StreamReader sw = new StreamReader(path))
            {
                string line = sw.ReadLine();
                if (line == null)
                {
                    return null;
                }
                else
                {
                    return line;
                }
            }
        }
        return null;
           
    }

    protected void DiscardData(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }

    protected string CreatePath(string fileName)
    {
        string _filePath = Path.Combine(Application.persistentDataPath, fileName);
        return _filePath;
    }
}
