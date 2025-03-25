using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Player player;
    public List<Enemy> enemyPrefabs;  // List to hold different enemy prefabs
    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyStats;

    private Enemy currentEnemy;

    void Start()
    {
        playerName.text = player.CharName;
        SpawnNewEnemy();  // Spawn the first enemy when the game starts
    }

    private void UpdateHealth()
    {
        playerHealth.text = player.health.ToString();
        enemyStats.text = currentEnemy.health.ToString();
    }

    public void DoRound()
    {
        // Player attacks first
        int damage = player.Attack();
        currentEnemy.GetHit(damage);
        player.Weapon.ApplyEffect(currentEnemy);

        // Enemy counterattacks
        int enemyDamage = currentEnemy.Attack();
        player.GetHit(enemyDamage);
        currentEnemy.Weapon.ApplyEffect(player);
        UpdateHealth();
    }

    // Method to handle enemy death and respawn
    public void OnEnemyDeath()
    {
        // Destroy the current enemy before spawning a new one
        Destroy(currentEnemy.gameObject);

        // Spawn a new enemy
        SpawnNewEnemy();  // Get a new enemy reference
    }

    // Method to spawn a new enemy (randomly selecting one from the list)
    private void SpawnNewEnemy()
    {
        // Randomly choose an enemy prefab from the list
        int randomIndex = Random.Range(0, enemyPrefabs.Count);
        currentEnemy = Instantiate(enemyPrefabs[randomIndex], new Vector3(0, 0, 0), Quaternion.identity);  // Spawn at (0,0,0)

        // Remove "(clone)" from the enemy's name
        currentEnemy.gameObject.name = currentEnemy.gameObject.name.Replace("(Clone)", "").Trim();

        // Update the UI with the new enemy's name and health
        enemyName.text = currentEnemy.name;
        currentEnemy.health = currentEnemy.MaxHealth;  // Reset enemy health to full
        enemyStats.text = currentEnemy.health.ToString();  // Update stats UI
    }

}