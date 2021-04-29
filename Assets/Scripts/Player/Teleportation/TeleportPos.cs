using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPos : MonoBehaviour
{
    [SerializeField]
    private Transform teleportPosition1;
    [SerializeField]
    private Transform teleportPosition2;
    [SerializeField]
    private Transform teleportPosition3;
    [SerializeField]
    private Transform teleportPosition4;

    private InputHandler inputHandler;
  
    public void HandleTeleportation1()
    {
        if (inputHandler.teleportPos1)
        {
            transform.position = teleportPosition1.position;
        }
    }

    public void HandleTeleportation2()
    {
        if (inputHandler.teleportPos2)
        {
            transform.position = teleportPosition2.position;
        }
    }
    public void HandleTeleportation3()
    {
        if (inputHandler.teleportPos3)
        {
            transform.position = teleportPosition3.position;
        }
    }
    public void HandleTeleportation4()
    {
        if (inputHandler.teleportPos4)
        {
            transform.position = teleportPosition4.position;
        }
    }
    void Start()
    {
        inputHandler = InputHandler.instance;
    }
    void Update()
        {

            HandleTeleportation1();
            HandleTeleportation2();
            HandleTeleportation3();
            HandleTeleportation4();
        }
}