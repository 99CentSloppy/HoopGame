using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPos4 : MonoBehaviour
{
    private InputHandler inputHandler;

    public Vector3 teleportPosition4;
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
        HandleTeleportation4();
    }
}
