using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWeapon : Weapon
{
   public override void ApplyEffect()
   {
      Debug.Log("no additional effect");
   }
}
