using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerV2 : MonoBehaviour
{
    private CharacterController controller;



    private Vector2 moveInput;

    public float gravity = -9.8f;
    private float verticalVelocity;


    public Transform modelTransform;
    public Transform Camerapivot;

    private Animator animator;

    private bool isRunning;
    private bool isMoving;
    public float walkSpeed = 3f;
    public float runSpeed = 6f;

    public float jumpForce = 0.01f;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    void Update()
    {

        float currentSpeed = (isRunning && isMoving) ? runSpeed : walkSpeed;

        if (controller.isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 forward = Camerapivot.forward;
        Vector3 right = Camerapivot.right;

        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        Vector3 desiredMoveDir = (forward * moveInput.y + right * moveInput.x);

        if (desiredMoveDir.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(desiredMoveDir);
            modelTransform.rotation = Quaternion.Slerp(modelTransform.rotation, targetRotation, 15f * Time.deltaTime);
        }

        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);

        Vector3 velocity = desiredMoveDir * currentSpeed;
        velocity.y = verticalVelocity;

        controller.Move(velocity * Time.deltaTime);

        UpdateAnimations();
    }
    public void OnSprint(InputAction.CallbackContext context)
    {
        isRunning = context.ReadValueAsButton();
    }

    

    public void OnJump(InputAction.CallbackContext context)
    {

        if (context.performed && controller.isGrounded)
        {
            verticalVelocity = jumpForce;
            animator.SetTrigger("Jump");
        }
    }

    public void OnDance(InputAction.CallbackContext context)
    { 
        if (context.performed)
        {
            animator.SetTrigger("Dance");
        }
    }
    public void UpdateAnimations()
    {
        isMoving = moveInput.magnitude > 0.1f;

        animator.SetBool("IsMoving", isMoving);
        animator.SetBool("IsRunning", isRunning && isMoving);
        animator.SetBool("Grounded", controller.isGrounded);
        animator.SetFloat("VerticalVelocity", verticalVelocity);
    }
}
