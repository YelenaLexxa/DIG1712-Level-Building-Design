using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{

    public int ScoreValue;
    private ScelOne scelOne;
    private ScelTwo scelTwo;
    private ScelThree scelThree;
    private ScelFour scelFour;

    private ScelFive scelFive;
    private ScelSix scelSix;
    private ScelSeven scelSeven;
    private ScelEight scelEight;
    private ScelNine scelNine;
    private ScelTen scelTen;


    public float startTimebtwShots;
    private float timeBtwShots;


    // Start is called before the first frame update
    void Start()
    {
        GameObject PlayerObject = GameObject.FindWithTag("ScelOne"); // 1
        if (PlayerObject != null)
        {
            scelOne = PlayerObject.GetComponent<ScelOne>();
        }

        GameObject PlayerObject2 = GameObject.FindWithTag("ScelTwo"); // 2
        if (PlayerObject2 != null)
        {
            scelTwo = PlayerObject2.GetComponent<ScelTwo>();
        }

        GameObject PlayerObject3 = GameObject.FindWithTag("ScelThree"); //3 
        if (PlayerObject3 != null)
        {
            scelThree = PlayerObject3.GetComponent<ScelThree>();
        }

        GameObject PlayerObject4 = GameObject.FindWithTag("ScelFour"); //4 
        if (PlayerObject4 != null)
        {
            scelFour = PlayerObject4.GetComponent<ScelFour>();
        }


        GameObject PlayerObject5 = GameObject.FindWithTag("ScelFive"); //5 
        if (PlayerObject5 != null)
        {
            scelFive = PlayerObject5.GetComponent<ScelFive>();
        }

        GameObject PlayerObject6 = GameObject.FindWithTag("ScelSix"); //6 
        if (PlayerObject6 != null)
        {
            scelSix = PlayerObject6.GetComponent<ScelSix>();
        }

        GameObject PlayerObject7 = GameObject.FindWithTag("ScelSeven"); //7 
        if (PlayerObject7 != null)
        {
            scelSeven = PlayerObject7.GetComponent<ScelSeven>();
        }

        GameObject PlayerObject8 = GameObject.FindWithTag("ScelEight"); //8 
        if (PlayerObject8 != null)
        {
            scelEight = PlayerObject8.GetComponent<ScelEight>();
        }

        GameObject PlayerObject9 = GameObject.FindWithTag("ScelNine"); //9 
        if (PlayerObject9 != null)
        {
            scelNine = PlayerObject9.GetComponent<ScelNine>();
        }

        GameObject PlayerObject10 = GameObject.FindWithTag("ScelTen"); //10 
        if (PlayerObject10 != null)
        {
            scelTen = PlayerObject10.GetComponent<ScelTen>();
        }


        timeBtwShots = startTimebtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            Destroy(gameObject);
            timeBtwShots = startTimebtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "ScelOne") // 1
        {
            Destroy(gameObject);
            scelOne.MinusScore(ScoreValue);
        }

        if (col.tag == "ScelTwo") //2 
        {
            Destroy(gameObject);
            scelTwo.MinusScore(ScoreValue);
        }

        if (col.tag == "ScelThree") // 3
        {
            Destroy(gameObject);
            scelThree.MinusScore(ScoreValue);
        }

        if (col.tag == "ScelFour") // 4
        {
            Destroy(gameObject);
            scelFour.MinusScore(ScoreValue);
        }

        if (col.tag == "ScelFive") // 5
        {
            Destroy(gameObject);
            scelFive.MinusScore(ScoreValue);
        }
        if (col.tag == "ScelSix") // 6
        {
            Destroy(gameObject);
            scelSix.MinusScore(ScoreValue);
        }
        if (col.tag == "ScelSeven") // 7
        {
            Destroy(gameObject);
            scelSeven.MinusScore(ScoreValue);
        }
        if (col.tag == "ScelEight") // 8
        {
            Destroy(gameObject);
            scelEight.MinusScore(ScoreValue);
        }
        if (col.tag == "ScelNine") // 9
        {
            Destroy(gameObject);
            scelNine.MinusScore(ScoreValue);
        }
        if (col.tag == "ScelTen") // 10
        {
            Destroy(gameObject);
            scelTen.MinusScore(ScoreValue);
        }


    }
}
