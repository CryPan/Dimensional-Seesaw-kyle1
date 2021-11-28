using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour
{
    public void LoadMainMenuAtonce()
    {
        Settings.isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
}
