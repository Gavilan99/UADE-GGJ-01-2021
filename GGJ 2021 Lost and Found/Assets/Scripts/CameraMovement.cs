using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject playerToFollow;
    public float cameraDistance = 30.0f;
    
    private void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(playerToFollow.transform.position.x, playerToFollow.transform.position.y, transform.position.z);
    }
}
