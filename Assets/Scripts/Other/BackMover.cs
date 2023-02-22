using UnityEngine;

public class BackMover : LoopObjectMover
{
    protected override void CheckPosition()
    {
        if (transform.position.x < XPosition)
            transform.position = new Vector3(ResetPosition, 0, 0);
    }
}

