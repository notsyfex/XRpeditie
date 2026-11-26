using UnityEngine;

public class SunAndMoonMovement : MonoBehaviour
{
    Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }


    public void AnimationsForSun()
    {
        _animator.SetTrigger("SunDown");
    }
    public void AnimationForMoon()
    {
        _animator.SetTrigger("SunUp");
    }
}

