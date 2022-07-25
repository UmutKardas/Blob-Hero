using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransformController : MonoBehaviour
{
    public float ballRotateSpeed;
    [SerializeField] private Transform playerTransform;
    private void Update()
    {
        Rotateball();
        TransformBall();
    }
    private void Rotateball()
    {
        transform.Rotate(new Vector3(0f, 90f, 0f), ballRotateSpeed
        * Time.deltaTime);
    }

    private void TransformBall()
    {
        transform.position = new Vector3(playerTransform.position.x,
        0.1f, playerTransform.position.z);
    }
}
