using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public int damageAmount = 10; 

    private Animator animator; 

    public Character opps;
    public GameObject self;
    void Start()
    {

        animator = GetComponentInParent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (self.tag == ("P1"))
        {
            if (other.CompareTag("P2"))
            {
                opps.currentHealth -= damageAmount;
                Debug.Log("clapped");
            }
        }

        if (self.tag == ("P2"))
        {
            if (other.CompareTag("P1"))
            {
                opps.currentHealth -= damageAmount;
                Debug.Log("clapped");
            }
        }

    }
}