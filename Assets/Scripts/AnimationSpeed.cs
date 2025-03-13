using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // 인스펙터에서 조정할 수 있도록 public 또는 SerializeField 사용
    [SerializeField]
    private float attackSpeed = 1f; // 프레임 간 간격

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
