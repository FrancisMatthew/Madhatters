
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{

    public GameObject puasemenu;

    public bool isPaused = false;

    private void Start()
    {
        Time.timeScale = 1f;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused == false)
            {
                puasemenu.SetActive(true);
                isPaused = true;
                Pause();
            }
            else if (isPaused == true)
            {
                puasemenu.SetActive(false);
                isPaused = false;
                Resume();
            }
        }
    }
    public void MainMenu()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
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

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
