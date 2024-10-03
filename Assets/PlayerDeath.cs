using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public float fallThreshold = -10f; // Y position threshold at which player dies
    private DeathManager deathManager; // Reference to the DeathManager script

    void Start()
    {
        // Get reference to the DeathManager
        deathManager = FindObjectOfType<DeathManager>();
    }

    void Update()
    {
        // Check if the player falls below the Y-axis threshold
        if (transform.position.y < fallThreshold)
        {
            // Call the method to show the death screen
            deathManager.ShowDeathScreen();
        }
    }
}
