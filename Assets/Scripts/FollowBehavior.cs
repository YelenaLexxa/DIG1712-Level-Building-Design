using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowBehavior : StateMachineBehaviour
{
    //private AudioSource source;
    private Transform playerPos;
    public float speed;

    public float attackDistance; // 20
    public float stoppingDistance;// 50

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //source = animator.GetComponent<AudioSource>();
        //source.Play();

        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position = Vector3.MoveTowards(animator.transform.position, playerPos.position, speed * Time.deltaTime);


        if (Vector3.Distance(playerPos.position, animator.transform.position) <= attackDistance)  // переходит в атаку если приближается
        {
            //animator.transform.position = this.transform.position; // останавливается (возможно не обязательно - надо потестить)

            animator.SetBool("isAttack", true); //надо прописать
        }

        // нужен ли тут else?

        if (Vector3.Distance(playerPos.position, animator.transform.position) >= stoppingDistance) // теряет игрока и останавливается
        {
            //animator.transform.position = this.transform.position; // остается там где потерял игрока

            animator.SetBool("isFollowing", false); // возвращается в положение Idle
        }


        Vector3 lookAt = playerPos.position; // поворачивает свою тупую башку в сторону игрока
        lookAt.y = animator.transform.position.y;
        animator.transform.LookAt(lookAt);


        //if (Input.GetKeyDown(KeyCode.Space)) // надо придумать когда он будет стоять на месте. 
        //{
        //    animator.SetBool("isFollowing", false);
        //}

        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    animator.SetBool("isPatrolling", true);
        //}

        //if (Input.GetKeyDown(KeyCode.X))
        //{
        //    animator.SetBool("isDissappearing", true);
        //}
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    animator.SetBool("isCreating", true);
        //}
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}