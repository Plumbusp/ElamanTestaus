using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new miraculous choice", menuName = "Choices For Hamster/Some Miraculous Choice")]
public class MiraculousChoiceScriptable : ScriptableObject
{
    [HideInInspector] public TypesNames.ChoiceType choiceType = TypesNames.ChoiceType.miraculous;
    public TypesNames.MiraculousType miraculousType;
    public Sprite choiceSprite;
}
