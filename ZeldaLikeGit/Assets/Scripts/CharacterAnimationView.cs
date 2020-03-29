using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationView : MonoBehaviour
{
    public Animator animator;
    private CharacterMovementModel m_MovementModel;

    // Start is called before the first frame update
    private void Awake()
    {
        m_MovementModel = GetComponent<CharacterMovementModel>();
        if(animator == null)
        {
            Debug.LogError("Character Animator not setup!");
            enabled = false;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateDirection();
    }

    void updateDirection()
    {
        Vector3 direction = m_MovementModel.getDirection();
        if(direction != Vector3.zero)
        {
            animator.SetFloat("DirectionX", direction.x);
            animator.SetFloat("DirectionY", direction.y);
        }
        animator.SetBool("IsMoving", m_MovementModel.isMoving());
    }
}
