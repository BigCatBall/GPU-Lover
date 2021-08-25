using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCheck : MonoBehaviour
{
    Animator anim;

    bool isIdle = true;
    bool isRunning = true;
    bool isRunningStraight = false;
    bool isRunningBack = false;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("idle");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }

        if (isRunning == true)
        {
            anim.SetTrigger("isRunning");
        }
        else if (isRunning == false) ;
        {
            anim.SetTrigger("idle");
        }
    }
}
