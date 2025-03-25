using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private string charName;
    private bool shieldActive = false; // true if shield is on, false if off

    public string CharName
    {
        get { return charName; }
    }

    // Toggle the shield status
    public void ToggleShield()
    {
        shieldActive = !shieldActive; // Toggle shield status
        Debug.Log("Shield is now: " + (shieldActive ? "On" : "Off"));
    }

    // Check if shield is active
    public bool IsShieldActive()
    {
        return shieldActive;
    }

    // Override GetHit method to apply shield effect
    public override void GetHit(int damage)
    {
        if (shieldActive)
        {
            float shieldBreakChance = Random.Range(0f, 1f);
            if (shieldBreakChance < 0.1f) // 10% chance to break the shield
            {
                Debug.Log("Shield is broken!");
                shieldActive = false; // Shield is broken, turn it off
            }
            else
            {
                damage /= 2; // Reduce damage by half if shield is active
            }
        }

        health -= damage; // Apply the remaining damage to the player
        Debug.Log(name + " health after hit: " + health);
    }
}