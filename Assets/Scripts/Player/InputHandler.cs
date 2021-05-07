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
    public bool resetSpace = false;
    public bool fireDown = false;
    public bool aimDown = false;
    

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
        controls.Locomotion.Reset.canceled += controls => resetSpace = false;

        controls.Locomotion.Teleport1.performed += controls => teleportPos1 = true;
        controls.Locomotion.Teleport1.canceled += controls => teleportPos1 = false;

        controls.Locomotion.Teleport2.performed += controls => teleportPos2 = true;
        controls.Locomotion.Teleport2.canceled += controls => teleportPos2 = false;

        controls.Locomotion.Teleport3.performed += controls => teleportPos3 = true;
        controls.Locomotion.Teleport3.canceled += controls => teleportPos3 = false;

        controls.Locomotion.Teleport4.performed += controls => teleportPos4 = true;
        controls.Locomotion.Teleport4.canceled += controls => teleportPos4 = false;



        //revmove "//" when the control is added 

        // controls.Locomotion.Aim.performed += controls => aimDown = true;
        // controls.Locomotion.Aim.canceled += controls => aimDown = false;

    }
}
