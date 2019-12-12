using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImenuButton : MonoBehaviour
{
    public void MenuReturn()
    {
        SceneManager.LoadScene(0);
    }

    [SerializeField]
    GameObject dontDestroy;
    // Awake is called before even the Start function
    void Awake()
    {
        Object sceneLoader = this.gameObject;
        Object.DontDestroyOnLoad(sceneLoader);
        Object.DontDestroyOnLoad(dontDestroy);
        //public void ()

    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
