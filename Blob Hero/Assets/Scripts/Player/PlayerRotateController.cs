using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotateController : MonoBehaviour
{
    [SerializeField] PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private float lerpValue;

    void Start()
    {

    }

    void Update()
    {
        if (playerDataTransmitter.GetInputPlayer().x > 0f)
        {
            transform.rotation = Quaternion.Slerp
            (transform.rotation, Quaternion.Euler(0, 90f, 0), lerpValue * Time.deltaTime);
        }
        else if (playerDataTransmitter.GetInputPlayer().x < 0f)
        {
            transform.rotation = Quaternion.Slerp
           (transform.rotation, Quaternion.Euler(0, -90f, 0), lerpValue * Time.deltaTime);
        }
        else if (playerDataTransmitter.GetInputPlayer().x > 0f && playerDataTransmitter.GetInputPlayer().z > 0f)
        {
            transform.rotation = Quaternion.Slerp
           (transform.rotation, Quaternion.Euler(0, 35f, 0), lerpValue * Time.deltaTime);
        }
        else if (playerDataTransmitter.GetInputPlayer().z > 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), lerpValue * Time.deltaTime);
        }
        else if (playerDataTransmitter.GetInputPlayer().z < 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 180f, 0), lerpValue * Time.deltaTime);
        }


    }
}
