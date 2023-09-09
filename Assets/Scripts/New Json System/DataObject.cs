using System.Collections;
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
        food = string.Empty;
        house = string.Empty;
        miraculous = string.Empty;
        name = "some name";
        health = 100;
    }
}
