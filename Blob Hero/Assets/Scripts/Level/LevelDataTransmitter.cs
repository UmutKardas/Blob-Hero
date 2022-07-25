using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDataTransmitter : MonoBehaviour
{
    [SerializeField] private LevelActiveController levelActiveController;
    public float lvlAmount = 0;

    public void SetInactiveButton()
    {
        levelActiveController.SetInactiveButton();
    }
}
