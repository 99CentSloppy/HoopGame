using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Register : MonoBehaviour
{
    public GameObject stage1;
    public GameObject stage2;
    public GameObject ball;
    bool stage1Bool;
    bool stage2Bool;
    int shotTaken= 0;
   void HandleRegister()
    {
        if(stage1Bool == true)
        {
            shotTaken +=1;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
