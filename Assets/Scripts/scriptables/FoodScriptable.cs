using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "foodChoice", menuName = "Food Choice", order = 1)]
public class FoodScriptable : ScriptableObject
{
    public string foodName;
    public Sprite sprite;
}
