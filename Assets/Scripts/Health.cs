using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    [NonSerialized]
    public int health;
    public int maxHealth = 10;

    private void Awake()
    {
        health = maxHealth;
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    protected abstract void Die();
}
