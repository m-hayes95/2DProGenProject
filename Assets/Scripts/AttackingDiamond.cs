using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingDiamond : MonoBehaviour
{
    public float rotateSpeed;
    public float diamondForce = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        //Rotate the diamond
        transform.Rotate(new Vector3(1, 0, 0), rotateSpeed * Time.deltaTime);
        rb.AddForce(transform.forward * diamondForce, ForceMode2D.Impulse);
    }
}
