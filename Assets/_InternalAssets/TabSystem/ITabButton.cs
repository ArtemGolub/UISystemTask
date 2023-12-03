using UnityEngine;
using UnityEngine.UI;

public interface ITabButton
{
    TabGroup tabGroup { get; }
    Image background { get; }
    bool isSelected { get; set; }
    RectTransform prevPose { get; set; }
}