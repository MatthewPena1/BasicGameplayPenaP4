using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    int sideMinZ = 2;
    int sideMaxZ = 15;
    int spawnPosX = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalRandomPosition", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimalTop()
    {
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnAnimalRandomPosition()
    {
        // Spawn left side
        SpawnRandomAnimal(new Vector3(-spawnPosX - 5, 0, Random.Range(sideMinZ, sideMaxZ)), Quaternion.Euler(0, 90, 0));

        // Spawn right side
        SpawnRandomAnimal(new Vector3(spawnPosX + 5, 0, Random.Range(sideMinZ, sideMaxZ)), Quaternion.Euler(0, -90, 0));
    }

    void SpawnRandomAnimal(Vector3 spawnPos, Quaternion rotation)
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[Random.Range(0, animalPrefabs.Length)], spawnPos, rotation);
    }
}