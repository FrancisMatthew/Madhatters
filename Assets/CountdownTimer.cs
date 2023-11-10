using UnityEngine;
using UnityEngine.UI;
using TMPro;
[SerializeField]
public class CountdownTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public float countdownTime = 5.0f; // Set the initial countdown time in seconds
    private float currentTime = 0;
    private bool isCounting = false;
    public CharacterMovement Character;
    void Start()
    {
    
        // Time.timeScale = 0f;
        currentTime = countdownTime;
        UpdateTimerText();
        StartCountdown();
    }

    void Update()
    {
        if (isCounting)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                isCounting = false;
                Time.timeScale = 1f;
                timerText.gameObject.SetActive(false);
                Character.enabled = true;

                // Start your game or perform other actions when the timer reaches zero
            }

            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        // Display the remaining time as a string in a Text component
        timerText.text = currentTime.ToString("0"); // Display with one decimal place
    }

    public void StartCountdown()
    {
        isCounting = true;
        Character.enabled = false;
    }
}
