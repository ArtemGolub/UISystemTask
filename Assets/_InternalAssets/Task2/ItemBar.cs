using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemBar : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI description;
    
    public void SetupItem(ScriptableItem item)
    {
        image.sprite = item.sprite;
        description.text = item.description;
    }
}
