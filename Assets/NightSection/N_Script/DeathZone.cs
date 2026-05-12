using UnityEngine;

public class DeathZone : MonoBehaviour
{
 

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if(playerHealth != null)
            {
                playerHealth.TakeDaamge(100); // Inflict damage to the player when they enter the death zone.
            }
        }
    }

}
