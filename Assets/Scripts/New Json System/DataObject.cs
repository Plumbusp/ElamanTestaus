using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DataObject : MonoBehaviour
{
    public string name;
    public float health;
    public Image house;
    public Image miracolous;
    public Image[] rodentType;

    public DataObject()
    {
        name = "Rodent name: " + string.Empty;
        health = 100;
    }
}
