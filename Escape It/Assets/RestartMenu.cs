using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
using TMPro; // Required for TextMesh Pro

public class RestartMenu : MonoBehaviour
{
    public TextMeshProUGUI timeText; // Reference to the TMP text for displaying time

    void Start()
    {
        // Enable the cursor and unlock it
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Retrieve the time from the Timer script in the previous scene
        Timer previousTimer = FindObjectOfType<Timer>();
        if (previousTimer != null)
        {
            float timeTaken = previousTimer.timeElapsed; // Get the elapsed time
            DisplayTime(timeTaken); // Call method to display time
        }
    }

    void DisplayTime(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timeText.text = string.Format("Time Taken: {0:00}:{1:00}", minutes, seconds); // Format to minutes and seconds
    }

    public void RestartGame()
    {
        // Load the original scene (replace "YourOriginalScene" with the name of your main scene)
        SceneManager.LoadScene("SampleScene"); // Change to your main scene name
    }

    public void ExitGame()
    {
        // Exit the game (works in built applications)
        Application.Quit();
    }
}

