using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour


{


    public float speedss = 5f;

    public float jumpHeight = 10f;
    public float gravityValue = -20f;

    public CharacterController controller;

    private bool groundedPlayer;

    // DOBLE SALTO
    public int maxJumps = 2;
    private int jumpCount;

    // VELOCIDAD VERTICAL
    private float verticalSpeed;

    void Update()
    {
        groundedPlayer = controller.isGrounded;

        // Suelo
        if (groundedPlayer && verticalSpeed < 0)
        {
            verticalSpeed = -2f;
            jumpCount = 0;
        }

        // DOBLE SALTO
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumps)
        {
            verticalSpeed = jumpHeight;
            jumpCount++;
        }

        // Gravedad
        verticalSpeed += gravityValue * Time.deltaTime;

        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            move.x = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            move.x = 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            move.z = 1;
        }
        if(Input.GetKey(KeyCode.S))
        {
            move.z = -1;
        }

        // Añadimos el movimiento vertical
        move.y = verticalSpeed;

        // Mover al jugador
        controller.Move(move * Time.deltaTime * speedss);


    }


}

