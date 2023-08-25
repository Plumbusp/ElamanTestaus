using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoodHandler : MonoBehaviour
{
    [SerializeField] private Button firstButton;
    [SerializeField] private FoodScriptable firstButtonChoice;
    [SerializeField] private Button secondButton;
    [SerializeField] private FoodScriptable secondButtonChoice;
    [SerializeField] private Button thirdButton;
    [SerializeField] private FoodScriptable thirdButtonChoice;
    ///[SerializeField] private Image firstImage;
    ///[SerializeField] private Image secondImage;
    ///[SerializeField] private Image thirdImage;

    private void Awake()
    {
        firstButton.transform.Find("Text0").GetComponent<TMP_Text>().text = firstButtonChoice.foodName;
        firstButton.transform.Find("Image0").GetComponent<Image>().sprite = firstButtonChoice.sprite;

        secondButton.transform.Find("Text1").GetComponent<TMP_Text>().text = secondButtonChoice.foodName;
        secondButton.transform.Find("Image1").GetComponent<Image>().sprite = secondButtonChoice.sprite;

        thirdButton.transform.Find("Text2").GetComponent<TMP_Text>().text = thirdButtonChoice.foodName;
        thirdButton.transform.Find("Image2").GetComponent<Image>().sprite = thirdButtonChoice.sprite;
    }
    public void SetChoosenFood()
    {
        string buttonName = gameObject.transform.GetComponentInChildren<TMP_Text>().text;
        Sprite buttonImage = gameObject.transform.GetComponentInChildren<Image>().sprite;
        PlayerChoices.SetFood(buttonName, buttonImage);
    }
}
