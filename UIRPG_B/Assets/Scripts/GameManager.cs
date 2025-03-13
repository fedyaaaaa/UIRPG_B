using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    
    
    void Start()
    {
        int damage = player.Attack();
        enemy.GetHit(damage);
        int enemyDamage = enemy.Attack();
        player.GetHit(enemyDamage);
    }

    
}
