using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   
   public int health;
   [SerializeField] private Weapon weapon;

   public Weapon Weapon
   {
      get { return weapon; }
   }

   public virtual int Attack()
   {
      return weapon.GetDamage();
   }

   public void GetHit(int damage)
   {
      Debug.Log(name + " starting health: " +health);
      health -= damage;
      Debug.Log(" heaalth after hit: "+ health);
   }

   public void GetHit(Weapon weapon) {
   
   Debug.Log(name + " starting health: " + health);
      health -= weapon.GetDamage();
      Debug.Log(" health after hit by"+ weapon.name+ ": " + health);
   }

   public void Shout()
   {
      Debug.Log(" I AM " + name.ToUpper());
   }
   
}
