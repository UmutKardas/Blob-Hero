using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    public List<GameObject> spawnPoint = new List<GameObject>();
    int spawnPointNumber;
    void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (spawnPointNumber <= 40)
            {
                SpawnEnemy();
                spawnPointNumber++;
            }
            else
            {
                spawnPointNumber = 0;
                SpawnEnemy();

            }
        }

    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint[spawnPointNumber].transform.position, Quaternion.identity);
    }
}
