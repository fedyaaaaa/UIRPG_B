using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private TMP_Text gameOverText;

    private void Start()
    {
        gameOverText.gameObject.SetActive(false); // Hide "Game Over" text at start
    }

    public void TriggerGameOver()
    {
        gameOverText.gameObject.SetActive(true); // Show "Game Over" text
        Time.timeScale = 0f; // Pause the game
    }
}