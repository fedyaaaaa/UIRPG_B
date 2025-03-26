using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Assassin enemy: Low health, high damage, has a chance to deal critical hits
public class Assassin : Enemy
{
    [SerializeField] private int critChance = 30; // 30% chance to crit
    [SerializeField] private float critMultiplier = 2f; // Critical hits do double damage
    
    public override int Attack()
    {
        int baseDamage = Weapon.GetDamage();
        bool isCritical = Random.Range(0, 100) < critChance; // Determine if attack is a crit
        
        if (isCritical)
        {
            Debug.Log("Assassin landed a CRITICAL HIT!");
            return Mathf.RoundToInt(baseDamage * critMultiplier);
        }
        return baseDamage;
    }
}

