
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{


    private void Start()
    {
        Time.timeScale = 0f;
    }
    public void MainMenu()
    {
        Time.timeScale = 0f;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
    public void Play()
    {
        Time.timeScale = 1f;
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
