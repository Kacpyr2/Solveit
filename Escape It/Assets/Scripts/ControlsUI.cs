using UnityEngine;
using TMPro; // Only needed if using TextMeshPro

public class ControlsUI : MonoBehaviour
{
    public GameObject controlsPanel; // Reference to the UI panel (or Text element)

    void Start()
    {
        // Ensure the controls panel is visible when the game starts
        controlsPanel.SetActive(true);
    }

    void Update()
    {
        // Check if the player presses the space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Hide the controls panel
            controlsPanel.SetActive(false);
        }
    }
}
