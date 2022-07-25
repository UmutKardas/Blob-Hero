using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerDeadController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private GameObject gameoverText;
    [SerializeField] private GameObject restartButton;
    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        SetPlayerDead();
    }
    private void SetPlayerDead()
    {
        if (playerDataTransmitter.currentHealt <= 0)
        {
            Time.timeScale = 0;
            gameoverText.SetActive(true);
            restartButton.SetActive(true);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
}
