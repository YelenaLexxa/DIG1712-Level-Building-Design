using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : StateMachineBehaviour
{
    private PatrollSpotsSecond patrol;
    public float speed;
    private int randomSpot;
    public float StartMoveDistance;
    private Transform playerPos;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        patrol = GameObject.FindGameObjectWithTag("PatrollSpotsSecond").GetComponent<PatrollSpotsSecond>();
        randomSpot = Random.Range(0, patrol.patrolPoints.Length);
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)

    {
        //animator.transform.position = Vector3.MoveTowards(animator.transform.position, patrol.patrolPoints[0].position, speed * Time.deltaTime);
        //animator.transform.position = Vector3.MoveTowards(animator.transform.position, patrol.patrolPoints[1].position, speed * Time.deltaTime);
        //animator.transform.position = Vector3.MoveTowards(animator.transform.position, patrol.patrolPoints[2].position, speed * Time.deltaTime);


        if (Vector3.Distance(animator.transform.position, patrol.patrolPoints[randomSpot].position) > 0.2f)

        {
            animator.transform.position = Vector3.MoveTowards(animator.transform.position, patrol.patrolPoints[randomSpot].position, speed * Time.deltaTime);

        }
        else
        {
            randomSpot = Random.Range(0, patrol.patrolPoints.Length);
        }

        if (Vector3.Distance(playerPos.position, animator.transform.position) <= StartMoveDistance)  // переходит в атаку если отодвигается не далеко
        {
            animator.SetBool("isAttack", true); //надо прописать
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
