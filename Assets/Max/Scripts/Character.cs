using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health
    public int currentHealth; // Current health
    public Hpbar healthBar; // Reference to the health bar UI

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); // Set the maximum health for the health bar
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth); // Update the health bar UI
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Show end screen or game over screen
        // For now, let's just disable the GameObject
        gameObject.SetActive(false);
    }
}