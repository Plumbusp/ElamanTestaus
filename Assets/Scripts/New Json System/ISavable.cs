using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISavable 
{
    public void LoadData(DataObject data);
    public void SaveData(ref DataObject data);
}
