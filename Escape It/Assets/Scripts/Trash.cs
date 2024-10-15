using UnityEngine;

public class TrashCan : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("canPickUp")) // Ensure the ball has this tag
        {
            Debug.Log("Ball entered the trash can!");
            Destroy(other.gameObject); // or handle scoring
        }
    }
}