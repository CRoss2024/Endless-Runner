using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public DeathManager deathManager;

    private void Start()
    {
        deathManager = FindAnyObjectByType<DeathManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deathManager.ShowDeathScreen();
        }
    }
}
