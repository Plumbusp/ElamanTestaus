using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    [SerializeField] private Texture happyPhoto;
    [SerializeField] private Texture neutralPhoto;
    [SerializeField] private Texture sadPhoto;
    [SerializeField] private RawImage image;

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
                image.texture = happyPhoto;
                break;
            case Condition.neutral:
                image.texture = neutralPhoto;
                break;
            case Condition.sad:
                image.texture = sadPhoto;
                break;
            default:
                break;
        }
    }
}
