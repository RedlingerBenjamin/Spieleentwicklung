using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementModel : MonoBehaviour
{
    public float Speed;
    private Vector3 m_MovementDirection;
    private Rigidbody2D m_Body;

    private void Awake()
    {
        m_Body = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateMovement();
    }

    void updateMovement()
    {
        if(m_MovementDirection != Vector3.zero)
        {
            //speed diagonal eingeschränkt
            m_MovementDirection.Normalize();
        }

        
        m_Body.velocity = m_MovementDirection * Speed;
        //deltaTime reguliert Speed -> keine Computer abhängigkeit
        //Funktioniert nicht mit Collision
        //transform.position += m_MovementDirection * Speed * Time.deltaTime;
    }

    public void setDirection( Vector2 direction)
    {
        m_MovementDirection = new Vector3(direction.x, direction.y, 0);
    }

    public Vector3 getDirection()
    {
        return m_MovementDirection;
    }
    
    public bool isMoving()
    {
        return m_MovementDirection != Vector3.zero;
    }
}
