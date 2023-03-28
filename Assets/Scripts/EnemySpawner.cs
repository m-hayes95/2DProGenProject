using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject spawnLocation;
   
    public float spawnRate = 1f, nextSpawn = 0f; // Spawn timer ref

    private float spawnAreaWidth, spawnAreaHeight;

    public Vector3 randomSpawnPoint;

    private void Start()
    {
        spawnAreaHeight = 1080;
        spawnAreaWidth = 1920;
    }

    private void Update()
    {
        /*
        for (int x=0; x < spawnAreaWidth; x++)
        {
            for (int y=0; y < spawnAreaHeight; y++)
            {
                // use perlin noise to generate a random spawn location.
                float perlinValue = Mathf.PerlinNoise(x / spawnAreaWidth, y / spawnAreaHeight);
                
                
            }
        } */

        Shoot(); // Shoot an instantiated enemy prefab.
        
    }

    private void Shoot()
    {
        if (Time.time >= nextSpawn)
        {
            float randomValueY = Random.Range(0, spawnAreaHeight);
            float randomValueX = Random.Range(0, spawnAreaWidth);
            randomSpawnPoint = new Vector3(randomValueX, randomValueY, 0);
            // When timer resets, instantiate an enemy prefab
            Instantiate(enemyPrefab, randomSpawnPoint, spawnLocation.transform.rotation);
            nextSpawn = Time.time + 1f / spawnRate;
        }
    }
}
