using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static InputHandler instance;

    private Controls controls;

    public Vector2 move;

    public Vector2 look;

    public Vector2 teleport;

    public bool fireDown = false;
    public bool aimDown = false;
    public bool reset = false;

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
        controls.Locomotion.Teleport.performed += controls => teleport = controls.ReadValue<Vector2>();

        controls.Locomotion.Shoot.performed += controls => fireDown = true;
        controls.Locomotion.Shoot.canceled += controls => fireDown = false;

        controls.Locomotion.Reset.performed += controls => reset = true;
        controls.Locomotion.Reset.canceled += controls => reset = false;


        //revmove "//" when the control is added 

        // controls.Locomotion.Aim.performed += controls => aimDown = true;
        // controls.Locomotion.Aim.canceled += controls => aimDown = false;

    }
}
