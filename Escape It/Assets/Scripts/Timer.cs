using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeElapsed; // Total time elapsed
    private bool isRunning; // Timer running status
    public TextMeshProUGUI timerText; // Reference to the TextMeshProUGUI component to display the time

    void Start()
    {
        timeElapsed = 0f;
        isRunning = true; // Start the timer
    }

    void Update()
    {
        if (isRunning)
        {
            timeElapsed += Time.deltaTime; // Increment the timer
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        // Update the timer display in minutes and seconds
        float minutes = Mathf.FloorToInt(timeElapsed / 60);
        float seconds = Mathf.FloorToInt(timeElapsed % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Call this method to pause the timer
    public void PauseTimer()
    {
        isRunning = false; // Stop the timer
    }
}

