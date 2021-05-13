using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {

    }

    void Update()
    {
        Vector3 fireBall = new Vector3(0, 0, speed * Time.deltaTime);
        transform.Translate(fireBall);
    }
}

