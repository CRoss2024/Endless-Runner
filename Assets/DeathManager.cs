using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public GameObject Canvas; // Reference to the Death Screen Canvas

    // Restart the game (called by a button)
    public void RestartGame()
    {
        // Reset time and reload the current scene
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void MainMenu()
    {
        // Reset time and reload the current scene
        SceneManager.LoadSceneAsync("Main Menu");
    }

    // Quit the game (called by a button)
    public void QuitGame()
    {
        // Reset time scale and quit the application
        Application.Quit();
    }
}
