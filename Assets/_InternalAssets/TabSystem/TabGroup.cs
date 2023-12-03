using System.Collections.Generic;
using UnityEngine;

// Requirement for spreading scripts logic for not making "God Scripts".
// Also possible solution - Events
[RequireComponent(typeof(TabButtonEvents))]
public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public List<GameObject> objectsToSwap;
    public TabSettings tabSettings;
    
    // Custom inspector essential for making pairs of tabButtons and objectsToSwap
    public int arraySize; 
    
    private TabButton selectedTab;
    private TabButtonEvents tabButtonEvents;

    #region Unity Methods

    private void Start()
    {
        tabButtonEvents = GetComponent<TabButtonEvents>();
    }

    #endregion
    
    #region OnTab region

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if (selectedTab == null || button != selectedTab)
        {
            button.background.sprite = tabSettings.tabHovered;
        }
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        SwitchTabState(button);
        ResetTabs();
        button.background.sprite = tabSettings.tabActive;
        EnableObjects(button);
    }

    #endregion

    #region Tab Manipulations
    public void SubscribeTabs(TabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }
        
        tabButtons.Add(button);
    }
    private void SwitchTabState(TabButton button)
    {
        if (selectedTab != null)
        {
            tabButtonEvents.OnTabDeselectedLogic(selectedTab);
        }
        
        selectedTab = button;
        tabButtonEvents.OnTabSelectedLogic(selectedTab);
    }
    
    private void ResetTabs()
    {
        foreach (TabButton button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab)
            {
                continue;
            }

            button.background.sprite = tabSettings.tabIdle;
        }
    }

    #endregion

    #region Tab binded objects

    private void EnableObjects(TabButton button)
    {
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++)
        {
            if (i == index)
            {
                // Switch to enable disable canvas not complete object
                objectsToSwap[i].SetActive(true);
            }
            else
            {
                objectsToSwap[i].SetActive(false);
            }
        }
    }

    #endregion
}