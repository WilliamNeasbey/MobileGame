using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject ShittyCloudPlatformPrefab;
    public float levelWidth = 3f;
    public float minY = 0.2f;
    public float maxY = 1.5f;
    public float despawnDistance = 10f;
    public Transform playerTransform;

    private List<GameObject> spawnedPlatforms = new List<GameObject>();
    private float leftEdge;
    private float rightEdge;

    private void Start()
    {
        leftEdge = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + levelWidth;
        rightEdge = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - levelWidth;

        SpawnInitialPlatforms();
    }

    private void SpawnInitialPlatforms()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        for (int i = 0; i < 10; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x += Random.Range(-levelWidth, levelWidth);
            GameObject newPlatform = Instantiate(ShittyCloudPlatformPrefab, spawnPosition, Quaternion.identity);
            spawnedPlatforms.Add(newPlatform);
        }
    }

    private void Update()
    {
        if (spawnedPlatforms.Count > 0 && spawnedPlatforms[0].transform.position.y < playerTransform.position.y - despawnDistance)
        {
            DespawnPlatform();
        }

        if (spawnedPlatforms.Count < 20)
        {
            SpawnPlatform();
        }
    }

    private void SpawnPlatform()
    {
        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = spawnedPlatforms[spawnedPlatforms.Count - 1].transform.position.y + Random.Range(minY, maxY);
        spawnPosition.x = Random.Range(leftEdge, rightEdge);
        GameObject newPlatform = Instantiate(ShittyCloudPlatformPrefab, spawnPosition, Quaternion.identity);
        spawnedPlatforms.Add(newPlatform);
    }

    private void DespawnPlatform()
    {
        GameObject platformToDespawn = spawnedPlatforms[0];
        spawnedPlatforms.RemoveAt(0);
        Destroy(platformToDespawn);
    }
}
