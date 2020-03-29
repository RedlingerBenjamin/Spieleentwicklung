using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementBaseControl : MonoBehaviour
{
    protected CharacterMovementModel m_MovementModel;

    void Awake()
    {
        m_MovementModel = GetComponent<CharacterMovementModel>();
    }

    protected void setDirection (Vector2 direction)
    {
        m_MovementModel.setDirection(direction);
    }
}
