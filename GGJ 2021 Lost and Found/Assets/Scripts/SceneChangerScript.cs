using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class SceneChangerScript : MonoBehaviour
{
    public KeyCode interactKey;
    public GameObject player;
    public Camera cam;
    public Transform target;
    public PolygonCollider2D bound;
    public CinemachineConfiner confiner;
    private bool wantsToEnter;

    public void teletransport() {
        player.transform.position = target.transform.position;
        confiner.m_BoundingShape2D = bound;
    }
}
