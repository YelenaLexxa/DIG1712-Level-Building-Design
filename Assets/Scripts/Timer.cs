using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public int timeLeft = 7;
    public Text countdown;

    void Start()
    {
        StartCoroutine("LoseTime");
    }


    void Update()
    {
        countdown.text = ("" + timeLeft);
        if (timeLeft == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}