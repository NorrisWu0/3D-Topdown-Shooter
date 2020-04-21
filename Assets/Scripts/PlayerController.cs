using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    private Rigidbody m_RB;

    private void Start()
    {
        m_RB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    #region Movement System
    [Header("Movement Controller")]
    [SerializeField] float m_SpeedMultiplier = 10;
    [SerializeField] LayerMask m_LayerMask = new LayerMask();

    private float m_InputHorizontal = 0;
    private float m_InputVertical = 0;

    private void MovePlayer()
    {
        m_InputHorizontal = Input.GetAxis("Horizontal");
        m_InputVertical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(m_InputHorizontal, 0, m_InputVertical) * m_SpeedMultiplier;

        m_RB.velocity = _movement;

    }

    private void RotatePlayer()
    {
        RaycastHit _hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out _hit, Mathf.Infinity, m_LayerMask))
            transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));

    }


    #endregion
}
