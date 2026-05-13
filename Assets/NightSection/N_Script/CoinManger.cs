using UnityEngine;
using TMPro;

public class CoinManger : MonoBehaviour
{

    public static CoinManger instance; /* Singleton instance used for global access and management of coin-related functionalities. 
                                          Instance is assigned in the Awake method to ensure only one instance exists throughout the game.*/

    public int coinCount; 
    public TextMeshProUGUI coinText; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; // Assign the current instance to the static variable
            DontDestroyOnLoad(gameObject);// Prevent this GameObject from being destroyed when loading new scenes, ensuring the coin manager persists across the game.
        }
        else
        {
            Destroy(gameObject);        // If an instance already exists, destroy this duplicate to maintain the singleton pattern and prevent multiple instances of the coin manager.
        }
    }

    private void Start()
    {
        UpdateCoinText();
    }


    public void AddCoins( int amount)
    {
        coinCount += amount;
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
       
           // coinText.text = coinCount.ToString();
            coinText.text = "" + coinCount;

        
    }

}
