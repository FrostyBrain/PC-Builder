using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    public string selectedSceneName;
    [SerializeField]
    public string secondaryScene;
    [SerializeField]
    public string Credits;
    // Awake is called before even the Start function
    void Awake()
    {
        Object scene1 = this.gameObject;
        Object.DontDestroyOnLoad(scene1);
    }

    public void LoadSelectedScene()
    {
        SceneManager.LoadScene(selectedSceneName);
        
    }

    public void SelectedSceneLoad()
    {
        SceneManager.LoadScene(secondaryScene);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(Credits);
    }

    public void MenuReturn()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
