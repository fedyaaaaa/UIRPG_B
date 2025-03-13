using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PoisonedWeapon : Weapon
{
    [SerializeField] private int poisonStrength = 3;

    public override void ApplyEffect(Character target)
    {
        Debug.Log(target.name + "poisoned for " + poisonStrength);
        target.GetHit(poisonStrength);
    }


}
