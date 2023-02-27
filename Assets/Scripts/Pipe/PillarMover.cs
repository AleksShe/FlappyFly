using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMover : LoopObjectMover
{
    private void Start()
    {
        ResetYPosition();
    }
    protected override void CheckPosition()
    {
        if (transform.position.x < XPosition)
        {
            transform.position = new Vector3(ResetPosition, 0, 0); 
            ResetYPosition();
        }
    }
    private void ResetYPosition()
    {
        float rnd = Random.RandomRange(1.5f, 5.76f);
        transform.position = new Vector3(transform.position.x, rnd, transform.position.z);
    }
    public void ChangePillarSpeed(float speed)
    {
        Speed = speed;
    }
}

