using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private float spawnRangeX = 20f;
    
    [SerializeField]
    private float spawnPosZ = 20f;
    
    [SerializeField]
    private float startDelay = 2f;
    
    [SerializeField]
    private float spawnInterval = 1.5f;

    public List<GameObject> animalPrefabs;

    public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal), startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        animalIndex = Random.Range(0, animalPrefabs.Count);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
