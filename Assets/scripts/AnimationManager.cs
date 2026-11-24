using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public bool IsStartActivated = false;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (IsStartActivated)
        {
            animator.SetBool("StartMenuUnlock", true);
        }
    }
}
