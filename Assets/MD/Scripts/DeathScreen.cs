using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public Text Message;
    public List<string> Deathmessages = new List<string>();

    private void Start()
    {
        Message.text = Deathmessages[Random.Range(0, 29)];
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
    

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
