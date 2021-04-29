using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPos : MonoBehaviour
{
    private InputHandler inputHandler;

    public Vector3 teleportPosition1;
    public Vector3 teleportPosition2;
    public Vector3 teleportPosition3;
    public Vector3 teleportPosition4;
    public void HandleTeleportation1()
    {
        if (inputHandler.teleportPos1)
        {
            transform.position = teleportPosition1;
        }
    }
    public void HandleTeleportation2()
    {
        if (inputHandler.teleportPos2)
        {
            transform.position = teleportPosition2;
        }
    }
    public void HandleTeleportation3()
    {
        if (inputHandler.teleportPos3)
        {
            transform.position = teleportPosition3;
        }
    }
    public void HandleTeleportation4()
    {
        if (inputHandler.teleportPos4)
        {
            transform.position = teleportPosition4;
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
        HandleTeleportation2();
        HandleTeleportation3();
        HandleTeleportation4();
    }
}
