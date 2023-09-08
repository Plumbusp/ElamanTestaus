using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new miraculous choice", menuName = "Choices For Hamster/Some Miraculous Choice")]
public class MiraculousChoiceScriptable : ScriptableObject
{
    [HideInInspector] public ChoicesTypes.ChoiceType choiceType = ChoicesTypes.ChoiceType.miraculous;
    public ChoicesTypes.MiraculousType miraculousType;
    public Sprite choiceSprite;
}
