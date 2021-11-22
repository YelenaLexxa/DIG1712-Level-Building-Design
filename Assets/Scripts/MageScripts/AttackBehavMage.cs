using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehavMage : StateMachineBehaviour
{
    private Transform Player;
    private float timeBtwShots;
    public GameObject projectile; // любые патроны
    public float startTimebtwShots;

    public float stepBackDistance; // 5
    public float LostPlayerDistance; //20

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //source = animator.GetComponent<AudioSource>();
        //source.Play();
        //Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        timeBtwShots = startTimebtwShots;
        Player = GameObject.FindGameObjectWithTag("Player").transform.GetComponent<Transform>();
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // animator.transform.position = Vector3.MoveTowards(animator.transform.position, playerPos.position, speed * Time.deltaTime);


        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, animator.transform.position, Quaternion.identity);
            timeBtwShots = startTimebtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }


        if (Vector3.Distance(Player.position, animator.transform.position) <= stepBackDistance)  // отходит назад
        {
            

            animator.SetBool("isWalk", true); //надо прописать
        }

        if (Vector3.Distance(Player.position, animator.transform.position) >= LostPlayerDistance)  // снова начинает патрулировать
        {
            
            animator.SetBool("isAttack", false); //надо прописать
        }

        Vector3 lookAt = Player.position; // поворачивает свою тупую башку в сторону игрока
        lookAt.y = animator.transform.position.y;
        animator.transform.LookAt(lookAt);

        // нужен ли тут else?

        //if (Vector3.Distance(playerPos.position, animator.transform.position) >= stoppingDistance) // теряет игрока и останавливается
        //{
        //    //animator.transform.position = this.transform.position; // остается там где потерял игрока

        //    animator.SetBool("isFollowing", false); // возвращается в положение Idle
        //}


    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
