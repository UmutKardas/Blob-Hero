using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public Vector3 playerVec;

    void Update()
    {
        GetInputPlayer();
    }

    private void GetInputPlayer()
    {
        playerVec.x = Input.GetAxisRaw("Horizontal");
        playerVec.z = Input.GetAxisRaw("Vertical");
    }
}
