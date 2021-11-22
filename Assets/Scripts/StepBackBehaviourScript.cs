using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepBackBehaviourScript : StateMachineBehaviour
{
    private Transform playerPos;
    public float speed;

    public float stoppingDistance;// большая дистанция
    public float StartMoveDistance;// небольшая дистанция

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position = Vector3.MoveTowards(animator.transform.position, playerPos.position, -speed * Time.deltaTime);


        if (Vector3.Distance(playerPos.position, animator.transform.position) >= StartMoveDistance && Vector3.Distance(playerPos.position, animator.transform.position) < stoppingDistance)  // переходит в атаку если отодвигается не далеко
        {
            animator.SetBool("isAttack", true); //надо прописать
        }

        // нужен ли тут else?

        if (Vector3.Distance(playerPos.position, animator.transform.position) >= stoppingDistance) // теряет игрока и начинает стоять
        {
            //animator.transform.position = this.transform.position; // остается там где потерял игрока

            animator.SetBool("isIdle", true); // возвращается в положение Patrol
        }


        Vector3 lookAt = playerPos.position; // поворачивает свою тупую башку в сторону игрока
        lookAt.y = animator.transform.position.y;
        animator.transform.LookAt(lookAt);

    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
