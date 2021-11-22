using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float speed;
    private Pure_FPP_Controller player;
    public int ScoreValue;
    //private Vector3 target;


    void Start()
    {
        GameObject PlayerObject = GameObject.FindWithTag("Player");
        if (PlayerObject != null)
        {
            player = PlayerObject.GetComponent<Pure_FPP_Controller>();
            //target = new Vector3.Distance(player.position, transform.position);
        }

        //target = player.transform.position;
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        Vector3 lookAt = player.transform.position;
        lookAt.x = transform.position.x;
        transform.LookAt(lookAt);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);

            player.DamageHealth(ScoreValue);
        }

        //if (col.tag == "Border")
        //{
        //    Destroy(gameObject);
        //}
    }
}
