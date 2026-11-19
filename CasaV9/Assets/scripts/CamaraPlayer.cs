
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 distancia;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        gameObject.transform.LookAt(player);
    }

    void Update()
    {
        if (player != null)
        {
            transform.position = player.position + distancia;
            transform.LookAt(player);
        }
    }
}
