using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private float attackSpeed = 1f; // 공격속도 배수

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        SetAnimationSpeed(attackSpeed);
    }

    void Update()
    {
        SetAnimationSpeed(attackSpeed);
    }

    void SetAnimationSpeed(float speed)
    {
        if (animator!=null && speed!=0)
        {
            animator.speed = speed;
        }
    }
}
