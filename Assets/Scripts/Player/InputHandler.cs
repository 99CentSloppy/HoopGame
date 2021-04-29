using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static InputHandler instance;

    private Controls controls;

    public Vector2 move;

    public Vector2 look;

    public bool teleportPos1 = false;
    public bool teleportPos2 = false;
    public bool teleportPos3 = false;
    public bool teleportPos4 = false;
    public bool fireDown = false;
    public bool aimDown = false;
    public bool resetSpace = false;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

        controls = new Controls();

    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
     
        controls.Locomotion.Look.performed += controls => look = controls.ReadValue<Vector2>();

        controls.Locomotion.Shoot.performed += controls => fireDown = true;
        controls.Locomotion.Shoot.canceled += controls => fireDown = false;

        controls.Locomotion.Reset.performed += controls => resetSpace = true;

        controls.Locomotion.Teleport.performed += controls => teleportPos1 = true;
        controls.Locomotion.Teleport.canceled += controls => teleportPos1 = false;

        controls.Locomotion.Teleport.performed += controls => teleportPos2 = true;
        controls.Locomotion.Teleport.canceled += controls => teleportPos2 = false;

        controls.Locomotion.Teleport.performed += controls => teleportPos3 = true;
        controls.Locomotion.Teleport.canceled += controls => teleportPos3 = false;

        controls.Locomotion.Teleport.performed += controls => teleportPos4 = true;
        controls.Locomotion.Teleport.canceled += controls => teleportPos4 = false;



        //revmove "//" when the control is added 

        // controls.Locomotion.Aim.performed += controls => aimDown = true;
        // controls.Locomotion.Aim.canceled += controls => aimDown = false;

    }
}
