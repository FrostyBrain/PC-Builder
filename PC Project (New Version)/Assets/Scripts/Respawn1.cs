using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn1 : MonoBehaviour
{
    public GameObject Desktop;
    public GameObject Piece;

    // Start is called before the first frame update
    void Start()
    {
        //respawn = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Out Of Bounds")
        {
            Piece.gameObject.transform.position = Desktop.gameObject.transform.position;
        }

        else if (other.gameObject.tag == "Wrong")
        {
            Piece.gameObject.transform.position = Desktop.gameObject.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
