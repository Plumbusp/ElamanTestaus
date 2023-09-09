using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public class HouseChoiceHandler : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text name;
    [SerializeField] private HouseChoiceScriptable choice;
    private ChoicesTypes.HouseType _houseType;

    private void Start()
    {
        _houseType = choice.houseType;
        image.sprite = choice.choiceSprite;
        name.text = choice.houseType.ToString();

        gameObject.GetComponent<Button>().onClick.AddListener(SetChoice);
    }
    public void SetChoice()
    {
        PlayerChoices.instance.SetHouse(image.sprite, _houseType.ToString());
    }
}
