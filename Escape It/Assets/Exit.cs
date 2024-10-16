using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class Exit : MonoBehaviour
{
    public Timer timer; // Reference to the Timer script

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player is colliding
        {
            timer.PauseTimer(); // Pause the timer
            SceneManager.LoadScene("RestartScene"); // Load the restart scene
            Debug.Log("Player exited to restart scene!");
        }
    }
}