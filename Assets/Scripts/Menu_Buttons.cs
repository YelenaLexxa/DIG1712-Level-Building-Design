using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{

    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadSceneSecond()
    {
        SceneManager.LoadScene("MainSceneSecond");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void AboutGame()
    {
        SceneManager.LoadScene("AboutGame");
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
