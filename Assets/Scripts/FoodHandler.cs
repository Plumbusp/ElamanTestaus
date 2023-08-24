using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodHandler : MonoBehaviour
{
    [SerializeField] private string firstButtonName;
    [SerializeField] private string secondButtonName;
    [SerializeField] private string thirdButtonName;
    public void SetChoosenFood()
    {
        string buttonName = gameObject.name;
        switch(buttonName)
        {
            //case firstButtonName:
              //  break;

        }
    }
}
