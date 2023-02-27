using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BaseObject :MonoBehaviour, IGameObject
{
    protected virtual void Start()
    {
        BaseObjectsHandler.Instance.AddGameObject(this);
    }
    public virtual void StartObject()
    {
  
    }

    public virtual void StopObject()
    {
      
    }
}
