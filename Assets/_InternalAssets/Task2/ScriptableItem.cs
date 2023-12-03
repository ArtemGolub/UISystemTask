using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableItem", menuName = "Items/ScriptableItem")]
public class ScriptableItem : ScriptableObject
{
    public Sprite sprite;
    public string description;
    public int id;
}
