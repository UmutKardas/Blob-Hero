using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallowController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float lerpValue;
    Vector3 newPos;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - playerTransform.position;

    }

    void LateUpdate()
    {
        newPos = Vector3.Lerp(transform.position, playerTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPos;

    }
}
