using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSDAttach : MonoBehaviour
{
    [SerializeField]
    private GameObject SSDMarker;
    [SerializeField]
    private OVRGrabbable GrabbableRef;
    private string currentPartName= "SSD";

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == currentPartName&&currentPartName== "SSD")
        {
            //put part colliding with this collider in position/rotation of endmarker
            //Create fixed joint to fuse part to socket
            
            currentPartName = "hdd";
            Debug.Log("Things should be working");

            other.gameObject.transform.rotation = SSDMarker.transform.rotation;

            other.gameObject.transform.parent = SSDMarker.transform;
            //other.gameObject.transform.localPosition = new Vector3(-0.01417515f, 0.01416525f, -0.7377535f);
            other.gameObject.transform.localScale = new Vector3(1.3335678f, 0.3839786f, 0.36907f);

            //Object.Destroy(other.gameObject.GetComponent<Rigidbody>());

        // I swear to god if this fucking destroy script causes more clipping issues I will slam my head into this desk

            //gameObject.transform.position = CPUMarker.transform.position;






            //FixedJoint joint = other.gameObject.AddComponent<FixedJoint>();
            //joint.connectedBody = other.gameObject.GetComponent<Rigidbody>();


            //change to next part
        }
        else if (other.tag == currentPartName&&currentPartName=="hdd")
        {

        }
        //check if controller is inside of a box collider for a socket

        //check if part is the right part for the socket
        //check if player pulls the trigger
        //parent part to socket
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*If Cpu Collides with motherboard
     * {
     * Fixed joint and the CPU; 
     * }
     
     
     
     */
     
}

