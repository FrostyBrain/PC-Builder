using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {

        Debug.Log("Play Should Start!");
        Loader.Load(Loader.Scene.PC_Builder);
        //SceneManager.LoadScene(1);
        //Older way to call the first scene, didn't allow me to add the loading screen function for the main game
        
    }

    public void Controls()
    {
        Debug.Log("Control menu should start!!!");
        SceneManager.LoadScene(2);
    }

    public void OnApplicationQuit()
    {
        Debug.Log("Application should quit");
        Application.Quit();
    }

    public void CreditsScene()
    {
        Debug.Log("Credits should roll");
        SceneManager.LoadScene(3);
    }

}

