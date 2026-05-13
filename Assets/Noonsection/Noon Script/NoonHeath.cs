using UnityEngine;
using UnityEngine.UI;

public class NoonHeath : MonoBehaviour
{
    private int MaxHealth = 100;
    private int MinHealth = 0;
    private int currentHealth;
    public int Health_damage;

    private Image healthBarFill;
    Animator anim;
    void Start()
    {
        currentHealth = MaxHealth;
        healthBarFill = GameObject.Find("HealthBarFill").GetComponent<Image>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(Health_damage);

        }
    }

    [ContextMenu("Take Damage")]
    public void TakeDamageContextMenu()
    {
        TakeDamage(Health_damage);
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage; //currentHealth = currentHealth - damage;
 
        currentHealth = Mathf.Clamp(currentHealth, MinHealth, MaxHealth);
        Debug.Log("Current Health: " + currentHealth);
        UpdateHealthUI();

    }
    public void TakeHeal(int healAmount)
    {
        currentHealth += healAmount; //currentHealth = currentHealth - damage;
 
        currentHealth = Mathf.Clamp(currentHealth, MinHealth, MaxHealth);
        Debug.Log("Current Health: " + currentHealth);
        UpdateHealthUI();

    }
    public void UpdateHealthUI()
    {
        if (healthBarFill != null)
        {
            healthBarFill.fillAmount = (float)currentHealth / MaxHealth;
        }


    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spike"))
        {

           anim.SetTrigger("Hurt");
            TakeDamage(Health_damage);
        }
    }



}
