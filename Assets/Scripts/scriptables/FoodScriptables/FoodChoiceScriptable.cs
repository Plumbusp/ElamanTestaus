using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "new food choice", menuName = "Choices For Hamster/Some Food Choice", order = 1)]
public class FoodChoiceScriptable : ScriptableObject
{
    [HideInInspector] public ChoicesTypes.ChoiceType choiceType = ChoicesTypes.ChoiceType.food;
    public ChoicesTypes.FoodType foodType;
    public Sprite choiceSprite;
}
