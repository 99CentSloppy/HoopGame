using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private InputHandler inputHandler;

    public Vector3 resetPosition;
    public void HandleReset()
    {
        if (inputHandler.resetSpace)
        {
            transform.position = resetPosition;
        } 

    }
    void Start()
    {
        inputHandler = InputHandler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        HandleReset();
    }
}
