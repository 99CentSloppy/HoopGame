using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private InputManager inputManager;

    [SerializeField]
    private Transform playerParent;

    [SerializeField]
    private float hSens = 100f;
    [SerializeField]
    private float vSens = 100f;
    [SerializeField]
    private float sens = 100f;

    private float xRot = 0f;


    void Start()
    {
        inputManager = InputManager.instance;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        HandleLook(Time.deltaTime);
    }

    private void HandleLook(float delta)
    {
        float mouseX;
        float mouseY;

        if (hSens == vSens)
        {
            mouseX = inputManager.look.x * sens * delta;
            mouseY = inputManager.look.y * sens * delta;

        }
        else
        {
            mouseX = inputManager.look.x * hSens * delta;
            mouseY = inputManager.look.y * vSens * delta;
        }

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90, 90);

        transform.localRotation = Quaternion.Euler(xRot, 0, 0);

        playerParent.Rotate(Vector3.up, mouseX);

    }
}
