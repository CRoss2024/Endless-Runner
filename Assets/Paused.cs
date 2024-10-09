using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject PauseMenu;
    private int count = 0;

    public void MainMenu()
    {
        // Reset time and reload the current scene
        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void counter()
    {
        count += 1;
        if (count == 1)
        {
            Time.timeScale = 0f;
        }

        if (count == 2)
        {
            Time.timeScale = 1f;
            count -= 2;
        }
    }
}
