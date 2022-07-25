using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionContoller : MonoBehaviour
{
    [SerializeField] private LevelDataTransmitter levelDataTransmitter;
    [SerializeField] private EnemySpawnController enemySpawnController;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            levelDataTransmitter.lvlAmount += 15;
            enemySpawnController.SpawnEnemy();
        }

    }
}
