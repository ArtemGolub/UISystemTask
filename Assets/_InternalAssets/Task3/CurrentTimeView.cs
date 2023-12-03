using System.Collections;
using TMPro;
using UnityEngine;

public class CurrentTimeView : MonoBehaviour
{
    public TextMeshProUGUI realTimeis;
    public bool isTimeNeedUpdating = true;

    private CurrentTimeModel currentTimeModel;
    private Coroutine currentTimeCoroutine;
    private void Awake()
    {
        currentTimeModel = new CurrentTimeModel();
    }

    private void OnEnable()
    {
        currentTimeCoroutine = StartCoroutine(TimeUpdate());
    }

    private void OnDisable()
    {
        StopCoroutine(currentTimeCoroutine);
    }

    private void UpdateUI()
    { 
        realTimeis.text = currentTimeModel.Hour + ":" + currentTimeModel.Minute + ":" + currentTimeModel.Second;
    }

    private IEnumerator TimeUpdate()
    {
        currentTimeModel.UpdateTime();
        UpdateUI();
        while (isTimeNeedUpdating)
        {
            yield return new WaitForSeconds(1);
            currentTimeModel.UpdateTime();
            UpdateUI();
        }
    }
}
