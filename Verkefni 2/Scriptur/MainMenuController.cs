using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // �egar �tt er � START � MainMenu 
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // �egar �tt er � QUIT � MainMenu
    public void QuitGame()
    {
        print("Quit Game!");
        Application.Quit();
    }
}