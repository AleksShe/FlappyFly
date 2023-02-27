using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed; 
    private Rigidbody2D _rb;
    public bool CanMove { get; set; } = true;
    


    private void Start()
    {
            _rb=GetComponent<Rigidbody2D>();
    }
    public void MoveBird()
    {
        if(CanMove)
        _rb.AddForce(Vector2.up * _moveSpeed);
    }
    public void SetRigidBodyCondition(bool value)
    {
        _rb.isKinematic= value;
    }
}
