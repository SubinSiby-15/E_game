using UnityEngine;


public class CoinCollect : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    Collider2D boxCollider2D;
    ParticleSystem coinCollectEffect;

    private void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<Collider2D>();
            coinCollectEffect = GetComponentInChildren<ParticleSystem>();
    }


    public int Coin_Value = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {

            spriteRenderer.enabled = false; // Disable the sprite renderer to make the coin invisible after it has been collected.
            boxCollider2D.enabled = false; // Disable the collider to prevent further collisions with the coin after it has been collected.
                coinCollectEffect.Play(); // Play the coin collection particle effect when the coin is collected.
          

            CoinManger.instance.AddCoins(Coin_Value); // Increment the coin count by 1 using the CoinManger singleton instance.
            AudioManger.instance.CoinCollectedClip(); // Play the coin collection sound effect using the AudioManger singleton instance.
            Destroy(gameObject,2f); // Destroy the coin GameObject after it has been collected to prevent it from being collected again.
           
         


        }
    }
}
