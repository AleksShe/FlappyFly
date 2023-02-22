using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LoopObjectMover : MonoBehaviour
{
    [SerializeField] protected float Speed;
    [SerializeField] protected float XPosition;
    [SerializeField] protected float ResetPosition;
    [SerializeField] protected Vector3 PlusValue;

    protected void Update()
    {
        transform.position -= PlusValue * Speed * Time.deltaTime;
        CheckPosition();
    }
    protected virtual void CheckPosition()
    {  
    }
}
