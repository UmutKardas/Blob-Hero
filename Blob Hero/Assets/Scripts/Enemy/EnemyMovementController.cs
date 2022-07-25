using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    [SerializeField] private float enemyMovementSpeed;
    GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");

    }

    void Update()
    {
        SetEnemyMovement();
    }

    private void SetEnemyMovement()
    {
        transform.position = Vector3.MoveTowards(transform.position,
        player.transform.position,
        enemyMovementSpeed * Time.deltaTime);
    }
}
