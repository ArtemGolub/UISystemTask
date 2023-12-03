using UnityEngine;

[CreateAssetMenu(fileName = "NewTabSettings", menuName = "Settings/TabSettings")]
public class TabSettings : ScriptableObject
{
    public Sprite tabIdle;
    public Sprite tabActive;
    public Sprite tabHovered;
}
