using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int ScoreValue = 1;
    private Pure_FPP_Controller player;

    private void Start()
    {
        GameObject PlayerObject = GameObject.FindWithTag("Player");
        if (PlayerObject != null)
        {
            player = PlayerObject.GetComponent<Pure_FPP_Controller>();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
            player.CrystalScore(ScoreValue);
        }
    }
}
