using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Register : MonoBehaviour
{
    private bool stage1 = false;
    private bool stage2 = false;

    public void UpdateStage()
    {
        if(!stage1)
        {
            stage1 = true;
            Debug.Log("Stage 1 complete");

        } else if(!stage2)
        {
            stage2 = true;
            Debug.Log("stage 2 complete");
            UpdateScore();
        }

    }

    private void UpdateScore()
    {
        Debug.Log("score detected");
        //increase the score
        //reset the stages
    }

}
