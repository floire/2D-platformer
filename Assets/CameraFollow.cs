using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform mainFollow;
    public Transform spiritFollow;
    public float CameraDistance = 30.0f;

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / CameraDistance);
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(mainFollow.position.x, mainFollow.position.y + 2, transform.position.z);
    }
}

