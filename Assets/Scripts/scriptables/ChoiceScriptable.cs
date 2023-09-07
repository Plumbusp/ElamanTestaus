using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "new choice", menuName = "Some Choice", order = 1)]
public class ChoiceScriptable : ScriptableObject
{
    public enum ChoiceType
    {
        food,
        miraculous,
        house
    }
    public ChoiceType choiceType;
    public string choiceName;
    public Sprite choiceSprite;
}
