using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "new food choice", menuName = "Choices For Hamster/Some Food Choice", order = 1)]
public class FoodChoiceScriptable : ScriptableObject
{
    [HideInInspector] public TypesNames.ChoiceType choiceType = TypesNames.ChoiceType.food;
    public TypesNames.FoodType foodType;
    public Sprite choiceSprite;
}
