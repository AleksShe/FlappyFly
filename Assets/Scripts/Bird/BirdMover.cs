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
        {
            _rb.AddForce(Vector2.up * _moveSpeed);
            StopCoroutine("RotateBird");
            StartCoroutine("RotateBird");
        }
      
    }
    public void SetRigidBodyCondition(bool value)
    {
        _rb.isKinematic= value;
    }
    private IEnumerator RotateBird()
    {
        int z = 0;
        while (z <= 25)
            {
            transform.rotation = Quaternion.Euler(0, 0, z);
            yield return new WaitForSeconds(0.003f);
            z++;
            }
        yield return new WaitForSeconds(0.5f);
        while (z>-90)
        {
            transform.rotation = Quaternion.Euler(0, 0, z);
            yield return new WaitForSeconds(0.003f);
            z--;
        }
    }
}
