using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Animator animator;
    AnimatorStateInfo animStateInfo;

    public int maxHealth = 1500;
    public int currentHealth = 1500;

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
        animator.Play("Death");
        Debug.Log("bro died");
        if (animator.GetCurrentAnimatorStateInfo(0).length < animator.GetCurrentAnimatorStateInfo(0).normalizedTime)
        {
            DestructionUnchained();
        }
    }

    void DestructionUnchained()
    {
        Destroy(gameObject);
    }
}