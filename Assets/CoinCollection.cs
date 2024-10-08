using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object colliding with the coin is the player
        if (other.gameObject.CompareTag("Player"))
        {
            // Destroy the coin when it hits the player
            Destroy(gameObject);
        }
    }
}
