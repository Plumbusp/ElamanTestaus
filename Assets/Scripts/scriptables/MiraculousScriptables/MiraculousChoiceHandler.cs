using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MiraculousChoiceHandler : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text miraculousName;
    [SerializeField] private MiraculousChoiceScriptable choice;
    private TypesNames.MiraculousType _miraculousType;

    private void Start()
    {
        _miraculousType = choice.miraculousType;
        image.sprite = choice.choiceSprite;
        miraculousName.text = choice.miraculousType.ToString();

        gameObject.GetComponent<Button>().onClick.AddListener(SetChoice);
    }
    public void SetChoice()
    {
        PlayerChoices.instance.SetMiraculous(image.sprite, _miraculousType.ToString());
    }
}
