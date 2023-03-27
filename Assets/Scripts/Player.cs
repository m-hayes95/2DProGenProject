using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float movement = 0f;
    Vector3 centerScreen = new Vector3(0,0, 0);

    private void Update()
    {
        //Store horizontal input into movement variable.
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        // Move player around the center of the screen, using negative speed to move clockwise on right input.
        transform.RotateAround(centerScreen, Vector3.forward, movement * Time.fixedDeltaTime * - speed);
    }
}
