using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    public Register register;

    private void Start()
    {
        register = GetComponentInParent<Register>();
    }

    private void OnTriggerEnter(Collider other)
    {    
        if (other.CompareTag("ball"))
        {
            register.UpdateStage();
        }
    }
}
