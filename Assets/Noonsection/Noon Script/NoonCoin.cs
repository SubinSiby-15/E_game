using UnityEngine;

public class NoonCoin : MonoBehaviour
{

    public int coinValue = 1; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Coin Collected!"); // Log a message to the console when the coin is collected for debugging purposes.)

            NoonCoinManger.instance.AddCoinCount(coinValue); // Increment the coin count by the coin's value using the NoonCoinManger singleton instance.
            AudioManger.instance.CoinCollectedClip(); 
            Destroy(gameObject); // Destroy the coin GameObject after it has been collected to prevent it from being collected again.

        }
    }




}
