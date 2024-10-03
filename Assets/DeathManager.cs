using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public GameObject deathScreenCanvas; // Reference to the Death Screen Canvas

    // Show the death screen
    public void ShowDeathScreen()
    {
        // Activate the death screen UI
        deathScreenCanvas.SetActive(true);

        // Pause the game
        Time.timeScale = 0f;
    }

    // Restart the game (called by a button)
    public void RestartGame()
    {
        // Reset time and reload the current scene
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Quit the game (called by a button)
    public void QuitGame()
    {
        // Reset time scale and quit the application
        Time.timeScale = 1f;
        Application.Quit();
    }
}
