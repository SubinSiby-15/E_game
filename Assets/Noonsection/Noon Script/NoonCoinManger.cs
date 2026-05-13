using UnityEngine;
using TMPro; 

public class NoonCoinManger : MonoBehaviour
{
    public static NoonCoinManger instance; // Singleton instance to allow easy access to the coin manager from other scripts.

    int coinCount = 0; // Variable to keep track of the total number of coins collected.
    public  TextMeshProUGUI coinText; 


    private void Awake()
    {

        UpdateCoinText();

        if (instance == null)
        {
            instance = this; // Set the singleton instance to this object if it hasn't been set yet.
            DontDestroyOnLoad(gameObject); // Prevent this object from being destroyed when loading new scenes to maintain the coin count across the game.
        }
        else
        {
            Destroy(gameObject); // Destroy this object if another instance already exists to enforce the singleton pattern.
        }
    }

    public void AddCoinCount(int amount)
    {
        coinCount += amount; // Increment the coin count by the specified amount.
        Debug.Log("Coins Collected: " + coinCount); // Log the current coin count to the console for debugging purposes.
        UpdateCoinText(); // Update the UI text element to reflect the new coin count.
    }

    public void UpdateCoinText()
    {
        coinText.text = "COIN : " + coinCount; 

    }
}   