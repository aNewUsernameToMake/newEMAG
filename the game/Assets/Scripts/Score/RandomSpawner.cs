using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public float Radius = 1f;

    // Change to IEnumerate later + wait for ... seconds
    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnObject();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
        
    }

    // Spawn object randomly
    void SpawnObject()
    {
        Vector3 randomPosition = Random.insideUnitCircle * Radius;

        // Instantiate the item at a random position
        Instantiate(itemPrefab, randomPosition, Quaternion.identity);
    }
}
