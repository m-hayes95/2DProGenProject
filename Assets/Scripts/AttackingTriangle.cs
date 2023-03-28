using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingTriangle : MonoBehaviour
{
    public float rotateSpeed;
    public float triangleForce = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    private void FixedUpdate()
    {
        
        rb.AddForce(transform.forward * triangleForce, ForceMode2D.Force);

    }
}
