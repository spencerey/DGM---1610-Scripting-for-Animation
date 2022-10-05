using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{
    [SerializeField]

    private int sceneToLoad ; 

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); //Indexed scene to load
        Debug.Log("New Scene loaded!");
    }

    public void  QuitGame()
    {
        Application.Quit(); // quit game
        Debug.Log("You have quit the game! Good bye ");
    }
}
