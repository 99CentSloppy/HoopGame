using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPos3 : MonoBehaviour
{
    private InputHandler inputHandler;

    public Vector3 teleportPosition3;
    public void HandleTeleportation3()
    {
        if (inputHandler.teleportPos3)
        {
            transform.position = teleportPosition3;
        }
    }
    void Start()
    {
        inputHandler = InputHandler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        HandleTeleportation3();
    }
}
