using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bird :BaseObject
{
    public UnityAction OnTouchPipe;
    public UnityAction OnTouchScore;

    private BirdMover _birdMover;
    protected override void Start()
    {
        base.Start();
        _birdMover = GetComponent<BirdMover>();
    }
    public override void StartObject()
    {
        _birdMover.SetRigidBodyCondition(false);
    }

    public override void StopObject()
    {
        _birdMover.CanMove = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Pipe pipe))
        {
            OnTouchPipe?.Invoke();
        GetComponent<Collider2D>().enabled= false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Score score))
        {
            OnTouchScore?.Invoke();
        }
    }
}
