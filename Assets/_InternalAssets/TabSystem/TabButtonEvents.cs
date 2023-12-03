using UnityEngine;

public class TabButtonEvents: MonoBehaviour
{
    public void OnTabSelectedLogic(TabButton button)
    {
        if (button.isSelected) return;

        RectTransform buttonRectTransform = button.GetComponent<RectTransform>();
        button.prevPose = buttonRectTransform;
        Vector2 newPose = new Vector2(button.prevPose.anchoredPosition.x - (button.prevPose.sizeDelta.x / 2), 
            button.prevPose.anchoredPosition.y);
        buttonRectTransform.anchoredPosition = newPose;
        button.isSelected = true;
    }
    
    public void OnTabDeselectedLogic(TabButton button)
    {
        RectTransform buttonRectTransform = button.GetComponent<RectTransform>();
        Vector2 newPose = new Vector2(
            button.prevPose.anchoredPosition.x + (button.prevPose.sizeDelta.x / 2), 
            button.prevPose.anchoredPosition.y);
        buttonRectTransform.anchoredPosition = newPose;
        button.isSelected = false;
    }
}
