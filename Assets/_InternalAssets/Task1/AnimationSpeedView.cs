using UnityEngine;
using UnityEngine.UI;

public class AnimationSpeedView : MonoBehaviour
{
    public AnimationSpeedViewModel viewModel;

    public Slider speedSlider;
   
    private void Start()
    {
        speedSlider.onValueChanged.AddListener(OnSpeedSliderChanged);
    }
    
    private void OnDisable()
    {
        speedSlider.value = 0;
    }

    private void OnSpeedSliderChanged(float value)
    {
        if (viewModel != null)
        {
            viewModel.UpdateAnimationSpeed(value);
        }
    }
}
