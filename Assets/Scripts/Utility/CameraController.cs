using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Transform m_Player = null;

    private void Start()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        transform.position = m_Player.position;
    }

}
