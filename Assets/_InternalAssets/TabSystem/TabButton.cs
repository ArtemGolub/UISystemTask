using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class TabButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, ITabButton
{
    public bool isSelected { get; set; }
    public RectTransform prevPose { get; set; }
    public TabGroup tabGroup { get; private set; }
    public Image background { get; private set; }

    
    #region UnityMethods
    private void Start()
    {
        tabGroup = transform.GetComponentInParent<TabGroup>();
        background = GetComponent<Image>();
        tabGroup.SubscribeTabs(this);
    }
    

    #endregion

    #region PointerMethods

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OnTabExit(this);
    }

    #endregion
}