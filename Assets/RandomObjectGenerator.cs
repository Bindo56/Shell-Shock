using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectGenerator : MonoBehaviour
{
    public GameObject objectPrefab; // Drag your prefab into this field in the Inspector
    public Vector2 spawnAreaSize = new Vector2(10f, 10f); // Adjust the spawn area size in the Inspector

    public int numberOfObjectsToSpawn = 10; // Adjust the number of objects to spawn

    private void Start()
    {
        SpawnRandomObjects();
    }

    private void SpawnRandomObjects()
    {
        for (int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            Vector2 randomPosition = new Vector2(Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f), Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f));
            Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        }
    }
}

