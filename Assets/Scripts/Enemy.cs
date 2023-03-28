using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject centrePoint;

    // Start is called before the first frame update
    void Start()
    {
        // Assign center point in scene view to gameobject var.
        centrePoint = GameObject.FindGameObjectWithTag("CentrePoint");
        // Set roatation to look at enemy.
        transform.LookAt(centrePoint.transform.position);
        // On spawn, assign rigid body and random thrust, using them to add force to the game object.
        float enemyPrefabThrust = Random.Range(100f, 1000f);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(Vector2.right * enemyPrefabThrust);
        //Debug.Log(enemyPrefabThrust);
    }

    
}
