using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    public GameObject spawnedPrefab;
    public Transform spawnLocation;

    public void SpawnPrefab()
    {
        Instantiate(spawnedPrefab, spawnLocation.position , spawnLocation.rotation);
    }
}
