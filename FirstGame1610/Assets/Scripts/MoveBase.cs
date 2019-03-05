using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveBase : ScriptableObject
{
    protected Vector3 position;
    public float JumpForce = 1;
    public float Gravity = -9.8f;
    public float Speed = 15;
    
    public abstract void Move(CharacterController controller);
}
