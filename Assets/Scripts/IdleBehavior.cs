using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehavior : StateMachineBehaviour
{

    private Transform playerPos;
    //public GameObject effect;

    public float followDistance; // 40

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)

    {
        if (Vector3.Distance(playerPos.position, animator.transform.position) <= followDistance) // начинает следовать за игроком
        {
            //animator.transform.position = this.transform.position; // остается там где потерял игрока

            animator.SetBool("isFollowing", true); // возвращается в положение Idle
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Instantiate(effect, animator.transform.position, Quaternion.identity);
    }


}