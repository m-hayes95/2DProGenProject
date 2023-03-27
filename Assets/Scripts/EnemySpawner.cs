using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyArray;
    public float spawnRate = 1f;
    public float nextSpawn = 0f;
    public float thrust;
   
    

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        int randomIndex = Random.Range(0, enemyArray.Length);

        if (Time.time >= nextSpawn)
        {
            Instantiate(enemyArray[randomIndex], transform.position, Quaternion.identity);
            nextSpawn = Time.time + 1f / spawnRate;
        }
    }
}
