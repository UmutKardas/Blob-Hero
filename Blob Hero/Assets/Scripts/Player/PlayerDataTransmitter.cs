using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{
    [SerializeField] private PlayerInputController playerInputController;

    public float currentHealt;

    public Vector3 GetInputPlayer()
    {
        return playerInputController.playerVec;
    }




}
