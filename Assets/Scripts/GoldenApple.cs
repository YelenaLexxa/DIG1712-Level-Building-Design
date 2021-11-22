using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenApple : MonoBehaviour
{

    //public int ScoreValue = 1; // for destroy
    private Pure_FPP_Controller player;
    private int value;

    private void Start()
    {
        GameObject PlayerObject = GameObject.FindWithTag("Player");
        if (PlayerObject != null)
        {
            player = PlayerObject.GetComponent<Pure_FPP_Controller>();
        }

        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            value = 15;
        }
        if (SceneManager.GetActiveScene().name == "MainSceneSecond")
        {
            value = 10;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
            player.HeailingPlayer(value);
        }
    }

}