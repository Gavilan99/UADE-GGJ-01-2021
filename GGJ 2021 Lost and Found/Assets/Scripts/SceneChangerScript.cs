using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class SceneChangerScript : MonoBehaviour
{

    public GameObject player;
    public Camera cam;
    public Transform target;
    public PolygonCollider2D bound;
    public CinemachineConfiner confiner;
    

    private void OnTriggerEnter2D(Collider2D collision){
        player.transform.position = target.transform.position;
        cam.transform.position = new Vector3(24f,0.05f,0f);
        confiner.m_BoundingShape2D = bound;
    }
}
