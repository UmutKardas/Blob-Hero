using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealtController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private Image healtBar;

    private float maxHealt = 100f;

    void Update()
    {
        healtBar.fillAmount = playerDataTransmitter.currentHealt / maxHealt;
    }


}
