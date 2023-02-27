using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : BaseObject
{
    private PillarMover _pillarMover;
    protected override void Start()
    {
        base.Start();
        _pillarMover = GetComponent<PillarMover>();
    }

    public override void StartObject()
    {
        _pillarMover.ChangePillarSpeed(20);
    }
    public override void StopObject()
    {
        _pillarMover.ChangePillarSpeed(0);
    }
}
