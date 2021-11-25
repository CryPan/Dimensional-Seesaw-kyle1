using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour
{
    public void LoadMainMenuAtonce()
    {
        SceneManager.LoadScene(0);
    }
}
