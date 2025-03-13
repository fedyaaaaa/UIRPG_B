using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyStats;
    
    
    void Start()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.name;
    }

    private void UpdateHealth()
    {
        playerHealth.text = player.health.ToString();
        enemyStats.text = enemy.health.ToString();
    }

    public void DoRound()
    {
        //int damage = player.Attack();
        enemy.GetHit(player.Weapon);
        player.Weapon.ApplyEffect(enemy);
        int enemyDamage = enemy.Attack();
        player.GetHit(enemyDamage);
        enemy.Weapon.ApplyEffect(player);
        UpdateHealth();
    }
    
}
