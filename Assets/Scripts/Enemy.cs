using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float enemyPrefabThrust = Random.Range(100f, 1000f);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(transform.forward * enemyPrefabThrust, ForceMode2D.Impulse);
        Debug.Log(enemyPrefabThrust);
    }

    
}
