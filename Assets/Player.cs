using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float movement = 0f;
    Vector2 moveDir = new Vector2(1, 0);

    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        
        transform.Translate(moveDir * movement * speed * Time.deltaTime);
    }
}
