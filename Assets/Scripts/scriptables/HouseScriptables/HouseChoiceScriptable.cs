using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new house choice", menuName = "Choices For Hamster/Some House Choice",order = 1)]
public class HouseChoiceScriptable : ScriptableObject
{
    [HideInInspector] public TypesNames.ChoiceType choiceType = TypesNames.ChoiceType.house;
    public TypesNames.HouseType houseType;
    public Sprite choiceSprite;
}
