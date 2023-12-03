using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentController : MonoBehaviour
{
    public ScrollRect scrollRect; 
    public RectTransform content; 

    private RectTransform scrollRectTransform;
    private List<RectTransform> visibleElements = new List<RectTransform>();
    private float distanceThreshold = 150f;
    public ItemBarFabric fabric;
    private void Start()
    {
        scrollRectTransform = scrollRect.GetComponent<RectTransform>();
    }

    private void Update()
    {
        Rect visibleRect = GetVisibleRect(scrollRectTransform);
        visibleElements.Clear();
        foreach (RectTransform element in content)
        {
            Vector3 closestPoint = element.position;
            closestPoint.x = Mathf.Clamp(closestPoint.x, visibleRect.xMin, visibleRect.xMax);
            closestPoint.y = Mathf.Clamp(closestPoint.y, visibleRect.yMin, visibleRect.yMax);
            float distance = Vector3.Distance(element.position, closestPoint);
            
            if (distance < distanceThreshold && element.name != "PlaceHolder")
            {
                visibleElements.Add(element);
            }
            else
            {
                fabric.ReturnToPull(element);
            }
        }
        
        foreach (RectTransform element in visibleElements)
        {
            fabric.UseFromPull(element);
        }

    }
    
    private Rect GetVisibleRect(RectTransform scrollRectTransform)
    {
        Vector3[] corners = new Vector3[4];
        scrollRectTransform.GetWorldCorners(corners);

        Vector2 bottomLeft = corners[0];
        Vector2 topRight = corners[2];

        return new Rect(bottomLeft.x, bottomLeft.y, topRight.x - bottomLeft.x, topRight.y - bottomLeft.y);
    }
}
