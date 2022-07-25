using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    public Animator animator;

    void Update()
    {
        SetRunAnimation();
    }
    private void SetRunAnimation()
    {
        if (Mathf.Abs(playerDataTransmitter.GetInputPlayer().x) > 0f
        || Mathf.Abs(playerDataTransmitter.GetInputPlayer().z) > 0f)
        {
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);

        }
    }
}
