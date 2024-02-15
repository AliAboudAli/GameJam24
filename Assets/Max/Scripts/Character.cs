using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    public int maxHealth = 100; // Maximum health
    public int currentHealth; // Current health

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Update()
    {

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}