using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        Debug.Log("Player has quit the simulation, If you are in test window, Please stop the game.");
        Application.Quit();
    }
}