using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public List<Vector3> spawnPoints;

    void Start()
    {
        foreach (Transform spawnPoint in transform)
        {
            spawnPoints.Add(spawnPoint.position);
        }
    }

    public Vector3 GetRandomSpawnPoint()
    {
        int index = Random.Range(0, spawnPoints.Count);
        return spawnPoints[index];
    }

    void Update()
    {
        
    }
}
