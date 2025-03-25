using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Player player;
    public List<Enemy> enemyPrefabs;  
    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyStats;
    [SerializeField] private GameOverManager gameOverManager; // Reference to GameOverManager

    private Enemy currentEnemy;

    void Start()
    {
        playerName.text = player.CharName;
        SpawnNewEnemy();
    }

    private void UpdateHealth()
    {
        playerHealth.text = player.health.ToString();
        enemyStats.text = currentEnemy.health.ToString();
    }

    public void DoRound()
    {
        if (player.health <= 0) return; // Stop if the player is already dead

        int damage = player.Attack();
        currentEnemy.GetHit(damage);
        player.Weapon.ApplyEffect(currentEnemy);

        int enemyDamage = currentEnemy.Attack();
        player.GetHit(enemyDamage);
        currentEnemy.Weapon.ApplyEffect(player);
        UpdateHealth();

        if (player.health <= 0)
        {
            gameOverManager.TriggerGameOver(); // Notify GameOverManager
        }
    }

    public void OnEnemyDeath()
    {
        Destroy(currentEnemy.gameObject);
        SpawnNewEnemy();
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
