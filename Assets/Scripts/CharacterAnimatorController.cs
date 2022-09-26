using UnityEngine;

public class CharacterAnimatorController : MonoBehaviour
{
    // animation IDs
    private int _animIDSpeed;
    private int _animIDGrounded;
    private int _animIDJump;
    private int _animIDFreeFall;
    private int _animIDMotionSpeed;

    private Animator _animator;
    private bool _hasAnimator;


    void Start()
    {
        _hasAnimator = TryGetComponent(out _animator);

        AssignAnimationIDs();
    }

    private void AssignAnimationIDs()
    {
        _animIDSpeed = Animator.StringToHash("Speed");
        _animIDGrounded = Animator.StringToHash("Grounded");
        _animIDJump = Animator.StringToHash("Jump");
        _animIDFreeFall = Animator.StringToHash("FreeFall");
        _animIDMotionSpeed = Animator.StringToHash("MotionSpeed");
    }

    void Update()
    {
        _hasAnimator = TryGetComponent(out _animator);
    }

    public void SetSpeedAndMotionSpeed(float animationBlend, float inputMagnitude)
    {
        if (_hasAnimator)
        {
            _animator.SetFloat(_animIDSpeed, animationBlend);
            _animator.SetFloat(_animIDMotionSpeed, inputMagnitude);
        }
    }

    public void StartJump()
    {
        if (_hasAnimator)
        {
            _animator.SetBool(_animIDJump, true);
        }
    }

    public void StartFreeFall()
    {
        if (_hasAnimator)
        {
            _animator.SetBool(_animIDFreeFall, true);
        }
    }

    public void EndJumpAndFreeFall()
    {
        if (_hasAnimator)
        {
            _animator.SetBool(_animIDJump, false);
            _animator.SetBool(_animIDFreeFall, false);
        }
    }

    public void SetGrounded(bool grounded)
    {
        if (_hasAnimator)
        {
            _animator.SetBool(_animIDGrounded, grounded);
        }
    }
}