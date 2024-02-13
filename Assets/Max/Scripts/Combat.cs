using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public int damageAmount = 10; 

    private Animator animator; 

    public Character opps;
    void Start()
    {

        animator = GetComponentInParent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("P2"))
        {
            opps.currentHealth -= damageAmount;
            Debug.Log("clapped");
        }

    }
}