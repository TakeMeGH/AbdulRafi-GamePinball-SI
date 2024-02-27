using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoominController : MonoBehaviour
{
    CameraController cameraController;
    public float length;

    private void Start() {
        cameraController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            cameraController.FollowTarget(other.transform, length);
        }
    }
}
