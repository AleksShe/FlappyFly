using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed; 
    private Rigidbody2D _rb;
    


    private void Start()
    {
            _rb=GetComponent<Rigidbody2D>();
    }
    public void MoveBird()
    {
        _rb.AddForce(Vector2.up * _moveSpeed);
    }
}
