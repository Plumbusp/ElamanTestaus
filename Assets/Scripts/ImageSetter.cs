using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSetter : MonoBehaviour
{
    [SerializeField] private Image foodImage;

    private void OnEnable()
    {
        PlayerChoices.OnFoodChoiceSet += ChangeFoodImage;
    }
    private void OnDisable()
    {
        PlayerChoices.OnFoodChoiceSet -= ChangeFoodImage;
    }

    private void ChangeFoodImage(Sprite sprite)
    {
        foodImage.sprite = sprite;
    }
}
