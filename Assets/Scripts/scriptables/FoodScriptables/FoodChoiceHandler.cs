using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

[RequireComponent(typeof(Button))]
public class FoodChoiceHandler : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text foodName;
    [SerializeField] private FoodChoiceScriptable choice;

    private TypesNames.FoodType _foodType;

    private void Start()
    {
        _foodType = choice.foodType;
        image.sprite = choice.choiceSprite;
        foodName.text = choice.foodType.ToString();
        
        gameObject.GetComponent<Button>().onClick.AddListener(SetChoice);
    }
    public void SetChoice()
    {
        PlayerChoices.instance.SetFood(image.sprite, _foodType.ToString());
    }

}
