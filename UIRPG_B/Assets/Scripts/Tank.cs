using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tank enemy: High health, low damage, takes reduced damage from attacks
public class Tank : Enemy
{
    [SerializeField] private float damageReduction = 0.5f; // Reduces incoming damage by 50%
    
    public override void GetHit(int damage)
    {
        int reducedDamage = Mathf.RoundToInt(damage * damageReduction);
        Debug.Log("Tank absorbs some damage! Actual damage taken: " + reducedDamage);
        base.GetHit(reducedDamage);
    }
}
