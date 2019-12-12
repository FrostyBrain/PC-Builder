using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPUAttach : MonoBehaviour
{
    [SerializeField]
    private GameObject GPUMarker;
    [SerializeField]
    private OVRGrabbable GrabbableRef;
    [SerializeField]
    public GameObject GrabbablePiece;
    [SerializeField]
    public GameObject FlashingPiece;
    private string currentPartName="GPU";

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == currentPartName&&currentPartName=="GPU")
        {
            //put part colliding with this collider in position/rotation of endmarker
            //Create fixed joint to fuse part to socket
            
            currentPartName = "gpu";
            Debug.Log("Things should be working");

            other.gameObject.transform.rotation = GPUMarker.transform.rotation;

            other.gameObject.transform.parent = GPUMarker.transform;
            //other.gameObject.transform.localPosition = new Vector3(-0.01417515f, 0.01416525f, -0.7377535f);
            other.gameObject.transform.localScale = new Vector3(2.5f, 2.500001f, 20.500001f);

            //Object.Destroy(other.gameObject.GetComponent<Rigidbody>());

            GameObject.Destroy(GrabbablePiece);
            Destroy(FlashingPiece.GetComponent<FadingScript>());
            

            //gameObject.transform.position = CPUMarker.transform.position;



            //FixedJoint joint = other.gameObject.AddComponent<FixedJoint>();
            //joint.connectedBody = other.gameObject.GetComponent<Rigidbody>();


            //change to next part
        }
        else if (other.tag == currentPartName&&currentPartName=="ram")
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

