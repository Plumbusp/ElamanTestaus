using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

[RequireComponent(typeof(Button))]
public class ChoiceHandler : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text name;
    [SerializeField] private ChoiceScriptable choice;
    private enum ChoiceType
    {
        food,
        miraculous,
        house
    }
    private ChoiceType choiceType;

    private void Start()
    {
        image.sprite = choice.choiceSprite;
        name.text = choice.choiceName;
        foreach(ChoiceType type in Enum.GetValues(typeof(ChoiceType)))
        {
            if(choice.choiceType.ToString() == type.ToString())
            {
                choiceType = type;
            }
        }
        gameObject.GetComponent<Button>().onClick.AddListener(SetChoice);
    }
    public void SetChoice()
    {
        switch(choiceType){
            case ChoiceType.food:
                PlayerChoices.instance.SetFood(image.sprite);
                break;

            case ChoiceType.miraculous:
                PlayerChoices.instance.SetWeapon(image.sprite);
                break;

            case ChoiceType.house:
                PlayerChoices.instance.SetHouse(image.sprite);
                break;

            default:
                break;
        }
    }
}
