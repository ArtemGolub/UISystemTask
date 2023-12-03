using System.Collections.Generic;
using UnityEngine;

public class ItemBarFabric : MonoBehaviour
{
    public ItemBar barPrefab;
    public RectTransform contentPanel;
    public List<ScriptableItem> items;
    public List<RectTransform> allBars;
    private void Start()
    {
        InitItems();
    }

    private void InitItems()
    {
        for (int i = 0; i < items.Count; i++)
        {
            var newBar = Instantiate(barPrefab, contentPanel);
            newBar.name = "ItemBar " + i;
            newBar.GetComponent<ItemBar>().SetupItem(items[i]);
            allBars.Add(newBar.GetComponent<RectTransform>());
        }
    }
    
    public void UseFromPull(RectTransform bar)
    {
        for (int i = 0; i < bar.childCount; i++)
        {
            bar.GetChild(i).gameObject.SetActive(true);
        }
    }
    
    public void ReturnToPull(RectTransform bar)
    {
        for (int i = 0; i < bar.childCount; i++)
        {
            bar.GetChild(i).gameObject.SetActive(false);
        }
    }


    
}
