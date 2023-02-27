using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObjectsHandler : MonoBehaviour
{
public static BaseObjectsHandler Instance;
    private void Awake()
    {
        if (Instance == null)
        Instance = this;
    }
    private List<IGameObject> _allInteractableObjects = new List<IGameObject>();
    public void AddGameObject(IGameObject obj)
    {
        _allInteractableObjects.Add(obj);
    }
    public void StopAllObjects()
    {
        foreach (var item in _allInteractableObjects)
        {
            item.StopObject();
        }
    }
    public void StartAllObjects()
    {
        foreach (var item in _allInteractableObjects)
        {
            item.StartObject();
        }

    }
}
