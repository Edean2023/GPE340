using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // set the player transform
    public Transform PlayerTransform;
    // camera offset
    private Vector3 cameraOffset;
    // helps the camera follow the player smoothly
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        // calculates the camera offset
        cameraOffset = transform.position - PlayerTransform.position;
    }

    // LateUpdate is called after Update methods
    void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + cameraOffset;

        // calculates the new position of the camera
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
