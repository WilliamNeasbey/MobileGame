using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDespawner : MonoBehaviour
{
    public float despawnTime = 5f;

    private GameObject platformObject;

    private void Start()
    {
        platformObject = gameObject;
        Invoke("DespawnPlatform", despawnTime);
    }

    private void DespawnPlatform()
    {
        if (platformObject != null)
        {
            Destroy(platformObject);
        }
    }
}
