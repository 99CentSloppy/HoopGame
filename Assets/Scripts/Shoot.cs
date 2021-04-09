using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Basketball
{
    [Header("Operational Info")]
    public float rpm = 100f;
    private float fireRate;
    private float nextTimeToFire = 0f;


    void Start()
    {
        base.Init();
        fireRate = 60 / rpm;
    }

    void Update()
    {
        CheckForFire();
        AimDownSights();
        ResetPosition();
    }

    protected override void CheckForFire()
    {
        if (Time.time >= nextTimeToFire)
        {
            canFire = true;
        }
        else
        {
            canFire = false;
        }

        if (input.fireDown && canFire)
        {
            nextTimeToFire = Time.time + fireRate;
            Shoot();
        }
    }
}
