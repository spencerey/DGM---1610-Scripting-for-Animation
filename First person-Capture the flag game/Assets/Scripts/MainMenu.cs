using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Indexed scene to load
        Debug.Log("New Scene loaded!");
    }

    public void  QuitGame()
    {
        Application.Quit(); // quit game
        Debug.Log("You have quit the game! Good bye ");
    }
}
