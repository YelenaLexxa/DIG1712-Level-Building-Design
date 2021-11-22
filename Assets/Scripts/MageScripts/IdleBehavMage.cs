using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehavMage : StateMachineBehaviour
{
    //private Transform playerPos;
    //public GameObject effect;

    private float timerForMove;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        timerForMove = 5;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)

    {

        if (timerForMove <= 0)
        {
            animator.SetBool("isPatroling", true);
        }
        else
        {
            timerForMove -= Time.deltaTime;
        }

        
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Instantiate(effect, animator.transform.position, Quaternion.identity);
    }
}
