using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    [SerializeField]
    private GameObject Floatingtext;
    [SerializeField]
    private GameObject target;


    
    void Update()
    {
        if (Floatingtext)
        {
            ShowFloatingText();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void ShowFloatingText()
    {
        Instantiate(Floatingtext, transform.position, Quaternion.identity, transform);
        this.gameObject.transform.LookAt(target.gameObject.transform);
        Debug.Log("Should Rotate Work");
        //Floatingtext.transform.rotation = target.transform.rotation;

    }
   
}
