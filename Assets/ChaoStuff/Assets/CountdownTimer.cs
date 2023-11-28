using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
[SerializeField]
public class CountdownTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public float countdownTime = 5.0f; // Set the initial countdown time in seconds
    private float currentTime = 0;
    private bool isCounting = false;
    public int roundIndex = 1;

    public AudioSource audioClick;
    public AudioSource audioGo;

    //public CharacterMovement Character;
    void Start()
    {
    
        // Time.timeScale = 0f;
        currentTime = countdownTime;
        UpdateTimerText();
        StartCountdown();
        StartCoroutine(Timer());
        Time.timeScale = 0f;
    }

    void Update()
    {
        //if (isCounting)
        //{
        //    currentTime -= Time.deltaTime;

        //    if (currentTime <= 0)
        //    {
        //        currentTime = 0;
        //        isCounting = false;
        //        Time.timeScale = 1f;
        //        timerText.gameObject.SetActive(false);
        //        Character.enabled = true;

        //        // Start your game or perform other actions when the timer reaches zero
        //    }

        //    UpdateTimerText();
        //}
    }

    public IEnumerator Timer()
    {
        yield return null;
        while(true)
        {
            if (isCounting)
            {
                currentTime -= 1;
                audioClick.Play();

                if (currentTime <= 0)
                {
                    currentTime = 0;
                    isCounting = false;
                    
                    break;
                    // Start your game or perform other actions when the timer reaches zero
                }

                UpdateTimerText();
                yield return new WaitForSecondsRealtime(1f);
            }
        }
        yield return new WaitForSecondsRealtime(.8f);
        timerText.text = "Round "+ roundIndex;
        audioGo.Play();
        yield return new WaitForSecondsRealtime(.8f);

        Time.timeScale = 1f;
        timerText.gameObject.SetActive(false);
        //Character.enabled = true;
    }
    void UpdateTimerText()
    {
        // Display the remaining time as a string in a Text component
        timerText.text = currentTime.ToString("0"); // Display with one decimal place
    }

    public void StartCountdown()
    {
        isCounting = true;
        //Character.enabled = false;
    }
}
