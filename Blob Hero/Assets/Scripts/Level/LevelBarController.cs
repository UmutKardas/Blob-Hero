using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBarController : MonoBehaviour
{
    [SerializeField] private LevelDataTransmitter levelDataTransmitter;
    [SerializeField] private Image lvlBar;

    private float maxHealt = 100f;

    void Update()
    {
        lvlBar.fillAmount = levelDataTransmitter.lvlAmount / maxHealt;
    }
}
