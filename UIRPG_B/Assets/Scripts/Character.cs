using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   
   public int health;
   [SerializeField] private Weapon weapon;

   public int Attack()
   {
      return weapon.GetDamage();
   }

   public void GetHit(int damage)
   {
      Debug.Log(name + " starting health: " +health);
      health -= damage;
      Debug.Log(" heaalth after hit: "+health);
   }

   public void Shout()
   {
      Debug.Log(" I AM " + name.ToUpper());
   }
   
}
