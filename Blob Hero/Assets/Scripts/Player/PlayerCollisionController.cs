using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            playerDataTransmitter.currentHealt -= 15;
        }

    }
}
