using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private int cubesThrownAway = 0; // Counter for thrown cubes
    public GameObject exit; // Reference to the exit GameObject

    void Start()
    {
        if (exit != null)
        {
            exit.SetActive(false); // Initially hide the exit
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("canPickUp")) // Ensure the object has this tag
        {
            Debug.Log("Cube entered the trash can!");
            Destroy(other.gameObject); // Destroy the cube
            cubesThrownAway++; // Increment the count of thrown cubes

            // Check if the player has thrown away 10 cubes
            if (cubesThrownAway >= 10)
            {
                UnlockExit(); // Call the method to unlock the exit
            }
        }
    }

    private void UnlockExit()
    {
        if (exit != null)
        {
            exit.SetActive(true); // Activate the exit
            Debug.Log("Exit unlocked!"); // Debug message for confirmation
        }
    }
}
