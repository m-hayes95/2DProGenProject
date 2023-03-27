using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject spawnLocation;
    public float spawnRate = 1f;
    public float nextSpawn = 0f;
    public float thrust;
   
    

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Time.time >= nextSpawn)
        {
            Instantiate(enemyPrefab, spawnLocation.transform.position, spawnLocation.transform.rotation);
            nextSpawn = Time.time + 1f / spawnRate;
        }
    }
}
