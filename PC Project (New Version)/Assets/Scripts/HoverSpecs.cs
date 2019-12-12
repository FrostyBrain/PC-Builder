using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverSpecs : MonoBehaviour
{
    //[SerializeField]
    //private Collider LHand;

    //[SerializeField]
    //private Collider RHand;

    [SerializeField]
    private GameObject info;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LHand" || collision.gameObject.tag == "RHand")
        {
            info.gameObject.SetActive(true);
            Debug.Log("General Kenibi");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "LHand" || collision.gameObject.tag == "RHand")
        {
            info.gameObject.SetActive(false);
            Debug.Log("Hello there");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        info.gameObject.SetActive(false);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
