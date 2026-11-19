using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cameracontroler : MonoBehaviour
{

    public Transform pivot;
    public float sensitivility = 0.2f;
    private Vector2 lookInput;
    private float yaw = 0f;
    private float pitch = 0f;

    public void OnLook(InputAction.CallbackContext context)
    {

        lookInput = context.ReadValue<Vector2>();
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        // Si el juego está pausado, no mover la cámara
        if (Time.timeScale == 0f)
        {
            lookInput = Vector2.zero;
            return;
        }

        yaw += lookInput.x * sensitivility;
        pitch -= lookInput.y * sensitivility;

        pitch = Mathf.Clamp(pitch, -45f, 60f);

        pivot.localRotation = Quaternion.Euler(pitch, yaw, 0);

    }
}
