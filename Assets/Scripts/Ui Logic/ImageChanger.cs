using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    [SerializeField] private Sprite happyPhoto;
    [SerializeField] private Sprite neutralPhoto;
    [SerializeField] private Sprite sadPhoto;
    [SerializeField] private Image image;

    public static ImageChanger instance;
    private Condition _condition;

    public void Awake()
    {
        instance = this;
    }
    public enum Condition
    {
        happy,
        neutral,
        sad
    }
    public void ChangeConditionTo(Condition changeTo)
    {
        _condition = changeTo;

        switch (_condition)
        {
            case Condition.happy:
                image.sprite = happyPhoto;
                break;
            case Condition.neutral:
                image.sprite = neutralPhoto;
                break;
            case Condition.sad:
                image.sprite = sadPhoto;
                break;
            default:
                break;
        }
    }
}
