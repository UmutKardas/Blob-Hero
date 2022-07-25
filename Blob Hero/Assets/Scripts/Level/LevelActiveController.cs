using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelActiveController : MonoBehaviour
{
    [SerializeField] private LevelDataTransmitter levelDataTransmitter;
    [SerializeField] private GameObject ballLVLButton;
    [SerializeField] private GameObject healtButton;
    [SerializeField] private GameObject ballSpeedButton;

    void Update()
    {
        SetActiveButton();

    }

    private void SetActiveButton()
    {
        if (levelDataTransmitter.lvlAmount >= 100)
        {
            ballLVLButton.SetActive(true);
            healtButton.SetActive(true);
            ballSpeedButton.SetActive(true);
            Time.timeScale = 0;

        }

    }

    public void SetInactiveButton()
    {
        ballLVLButton.SetActive(false);
        healtButton.SetActive(false);
        ballSpeedButton.SetActive(false);
        Time.timeScale = 1;

    }
}
