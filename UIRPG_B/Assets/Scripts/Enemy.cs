using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] protected int aggression = 10;
    [SerializeField] private int maxHealth;  // Add MaxHealth variable to track the full health
    public int MaxHealth
    {
        get { return maxHealth; }
    }

    // Override the GetHit method to check for death
    public override void GetHit(int damage)
    {
        base.GetHit(damage);

        // Check if the enemy's health is 0 or less
        if (health <= 0)
        {
            // Call GameManager's method to respawn the enemy
            FindObjectOfType<GameManager>().OnEnemyDeath();
        }
    }

    // Method to reset the enemy's health to full
    public void ResetHealth()
    {
        health = MaxHealth;  // Reset health to the max value
    }
}