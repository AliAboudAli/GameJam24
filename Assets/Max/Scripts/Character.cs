using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int Health;
    public int MaxHealth;


    public void Death()
    {
        if (Health <= 0)
        {
            Debug.Log("nigga you dead");
        }
    }
}