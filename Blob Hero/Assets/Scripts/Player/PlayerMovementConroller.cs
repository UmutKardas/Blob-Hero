using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementConroller : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private Rigidbody playerRigi;
    [SerializeField] private float movementSpeed;

    void FixedUpdate()
    {
        playerRigi.velocity = new Vector3(playerDataTransmitter.GetInputPlayer().x
        * movementSpeed * Time.fixedDeltaTime,
        playerRigi.velocity.y,
        playerDataTransmitter.GetInputPlayer().z * movementSpeed * Time.fixedDeltaTime);

    }
}
