using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPos2 : MonoBehaviour
{
    private InputHandler inputHandler;

    public Vector3 teleportPosition2;
    public void HandleTeleportation2()
    {
        if (inputHandler.teleportPos2)
        {
            transform.position = teleportPosition2;
        }
    }
    void Start()
    {
        inputHandler = InputHandler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        HandleTeleportation2();
    }
}
