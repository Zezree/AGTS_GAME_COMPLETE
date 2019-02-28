using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    //Spawn neboli vytvoření nových enemy navazbeno na Spawner (obrázek zombie)

    public Transform[] spawnPoints;
    public GameObject[] enemies;
    int randomSpawnPoint, randomEnemy;
    public static bool spawnAllowed;
    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAEnemy", 5f, 5f); // Rychlost spawnování Enemy
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnAEnemy() //Metoda spawnování pozice a koho spawnout
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomEnemy = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomEnemy], spawnPoints[randomSpawnPoint].position,
                Quaternion.identity);
        }
    }
}
