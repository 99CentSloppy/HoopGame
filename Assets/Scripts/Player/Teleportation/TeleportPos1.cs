using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPos1 : MonoBehaviour
{
    private InputHandler inputHandler;

    public Vector3 teleportPosition1;
    public void HandleTeleportation1()
    {
        if (inputHandler.teleportPos1)
        {
            transform.position = teleportPosition1;
        }
    }
    void Start()
    {
        inputHandler = InputHandler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        HandleTeleportation1();
    }
}
