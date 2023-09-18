using System.Collections;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DataObject 
{
    public string name;
    public float health;
    public string food;
    public string house;
    public string miraculous;
    public List<string> BoughtItems;
    /*
    public enum RodentType
    {
        hamster,
        rat,
        mouse
    }
    */
    public DataObject()
    {
        BoughtItems = new List<string>();
        food = string.Empty;
        house = string.Empty;
        miraculous = string.Empty;
        name = "some name";
        health = 100;
    }
    public override bool Equals(object obj)
    {
       if(this == obj)
       {
            return true;
       }
       else if(obj == null || !this.GetType().Equals(obj.GetType()))
       {
            return false;
       }
       else
       {
            DataObject compared = (DataObject)obj;
            return CompareTwoDataObjects(compared);
       }
    }

    private bool CompareTwoDataObjects(DataObject obj)
    {
        if (
        obj.name == this.name&&
        obj.health == this.health &&
        obj.food == this.food)
        {
            return true;
        }
        else
        {
            return false;
        }
       
    }
}
