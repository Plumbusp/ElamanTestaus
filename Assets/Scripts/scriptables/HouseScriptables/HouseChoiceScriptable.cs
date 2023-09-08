using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new house choice", menuName = "Choices For Hamster/Some House Choice",order = 1)]
public class HouseChoiceScriptable : ScriptableObject
{
    [HideInInspector] public ChoicesTypes.ChoiceType choiceType = ChoicesTypes.ChoiceType.house;
    public ChoicesTypes.HouseType houseType;
    public Sprite choiceSprite;
}
