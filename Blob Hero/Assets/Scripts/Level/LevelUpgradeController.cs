using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpgradeController : MonoBehaviour
{
    [SerializeField] private LevelDataTransmitter levelDataTransmitter;
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    private BallTransformController ballTransformController;
    [SerializeField] private GameObject ballsLvL1;
    [SerializeField] private GameObject ballsLvL2;
    [SerializeField] private GameObject ballsLvL3;

    private int ballsLVLAmount = 0;
    private void Start()
    {
        ballTransformController = FindObjectOfType<BallTransformController>();
    }




    public void BallsLvLButton()
    {
        if (ballsLVLAmount == 0)
        {
            ballsLvL1.SetActive(false);
            ballsLvL2.SetActive(true);
            ballsLVLAmount++;
        }
        else if (ballsLVLAmount == 1)
        {
            ballsLvL2.SetActive(false);
            ballsLvL3.SetActive(true);
        }
        levelDataTransmitter.lvlAmount = 0;
        levelDataTransmitter.SetInactiveButton();

    }

    public void HealtButton()
    {
        if (playerDataTransmitter.currentHealt >= 90)
        {
            playerDataTransmitter.currentHealt = 100f;


        }
        else if (playerDataTransmitter.currentHealt < 90)
        {
            playerDataTransmitter.currentHealt += 10;
        }

        levelDataTransmitter.lvlAmount = 0;
        levelDataTransmitter.SetInactiveButton();
    }

    public void BallsSpeedButton()
    {
        ballTransformController.ballRotateSpeed += 20;
        levelDataTransmitter.lvlAmount = 0;
        levelDataTransmitter.SetInactiveButton();
    }

}
