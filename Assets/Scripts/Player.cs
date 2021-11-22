using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int Score;
    public Slider slider; // for crystal
    public Text countdown; // for crystal

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateScore()
    {
        slider.value = Score;
        countdown.text = ("" + Score);

        //if (ScoreCount >= 100)
        //{
        //    ScoreCount = 100;
        //}
    }

    public void CrystalScore(int value)
    {
        Score = +value;

        UpdateScore();
    }
}
