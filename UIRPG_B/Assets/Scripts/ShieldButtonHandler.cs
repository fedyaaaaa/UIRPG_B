using UnityEngine;
using TMPro;

public class ShieldButtonHandler : MonoBehaviour
{
    [SerializeField] private Player player;  // Reference to the Player
    [SerializeField] private TMP_Text buttonText; // Reference to the TextMeshPro button text

    // Called when the shield button is clicked
    public void ToggleShield()
    {
        player.ToggleShield(); // Toggle shield status in the Player script

        // Update button text based on the shield's state
        buttonText.text = player.IsShieldActive() ? "Shield: ON" : "Shield: OFF";
    }
}