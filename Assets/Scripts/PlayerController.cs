using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private InputManager inputManager;
    private CharacterController controller;

    #region HandlingGravity
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private float gravity = -9.81f;
    [SerializeField]
    private Vector3 velocity;
    [SerializeField]
    private LayerMask groundMask;
    [SerializeField]
    private float groundDistance = .4f;
    [SerializeField]
    private bool grounded = false;
    [SerializeField]
    private float jumpHeight = 3f;
    #endregion

    void Start()
    {
        controller = GetComponent<CharacterController>();
        inputManager = InputManager.instance;
    }

    void FixedUpdate()
    {
        HandleMovement(Time.deltaTime);
        HandleGravity(Time.deltaTime);
        HandleJump();
    }

    private void HandleMovement(float delta)
    {
        Vector3 movement = (inputManager.move.x * transform.right) + (inputManager.move.y * transform.forward);

        controller.Move(movement * 5 * delta);
    }

    private void HandleGravity(float delta)
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * delta;
        controller.Move(velocity * delta);
    }

    private void HandleJump()
    {
        if (inputManager.jumpDown && grounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
}
