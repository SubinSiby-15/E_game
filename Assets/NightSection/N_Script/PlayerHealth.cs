using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    

    private int MaxHealth = 100;
    private int MinHealth = 0;
    private int currentHealth;


    public Image HelathBarFill;

   // public Slider HealthSliderBar;

    public int PlayerdDamage;

    void Start()
    {
        HelathBarFill = GameObject.Find("HelathBarFill").GetComponent<Image>();
    if(HelathBarFill == null)
        {
            Debug.LogError("HealthFill Image component not found in the scene.");
        }
    
         currentHealth= MaxHealth;
        UpdateHealthBar();

  
    }
        
     
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDaamge(PlayerdDamage);
        }   

       
    }

    [ContextMenu("Take Damage")]
    public void TakeDamageContextMenu()
    {
        TakeDaamge(PlayerdDamage);
    }

    public  void TakeDaamge(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, MinHealth, MaxHealth);
        Debug.Log("Current Health: " + currentHealth);
        UpdateHealthBar(); 
    }
   
    private void UpdateHealthBar()
    {
       
            HelathBarFill.fillAmount = (float)currentHealth / MaxHealth;

            //HealthSliderBar.value = (float)currentHealth / MaxHealth;
        
    }
}