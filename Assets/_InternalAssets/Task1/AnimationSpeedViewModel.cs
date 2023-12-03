using UnityEngine;

public class AnimationSpeedViewModel : MonoBehaviour
{
    public RectTransform animatedObject;
    
    private AnimationSpeedModel _model;
    //Switch to Tween or code
    private Animator _animator;
    
    private void Awake()
    {
        _model = new AnimationSpeedModel();
    }
    private void Start()
    {
        _animator = animatedObject.GetComponent<Animator>();
    }

    public void UpdateAnimationSpeed(float newSpeed)
    {
        _model.AnimationSpeed = newSpeed;
        if (_animator == null) return;
        _animator.SetFloat("MoveSpeed", _model.AnimationSpeed);
    }
}