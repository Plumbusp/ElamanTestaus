using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public class HouseChoiceHandler : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text houseName;
    [SerializeField] private HouseChoiceScriptable choice;
    private TypesNames.HouseType _houseType;

    private void Start()
    {
        _houseType = choice.houseType;
        image.sprite = choice.choiceSprite;
        houseName.text = choice.houseType.ToString();

        gameObject.GetComponent<Button>().onClick.AddListener(SetChoice);
    }
    public void SetChoice()
    {
        PlayerChoices.instance.SetHouse(image.sprite, _houseType.ToString());
    }
}
