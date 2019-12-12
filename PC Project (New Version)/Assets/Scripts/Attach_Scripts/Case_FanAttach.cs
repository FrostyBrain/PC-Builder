using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case_FanAttach : MonoBehaviour
{
    [SerializeField]
    private GameObject CaseFanMarker;
    [SerializeField]
    private OVRGrabbable GrabbableRef;
    private string currentPartName="Case_Fan";

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == currentPartName&&currentPartName=="Case_Fan")
        {
            //put part colliding with this collider in position/rotation of endmarker
            //Create fixed joint to fuse part to socket
            currentPartName = "rgb";
            Debug.Log("Things should be working");

            other.gameObject.transform.rotation = CaseFanMarker.transform.rotation;

            other.gameObject.transform.parent = CaseFanMarker.transform;
            //other.gameObject.transform.localPosition = new Vector3(0f, -5.577934e-17f, 0.9132603f);
            other.gameObject.transform.localScale = new Vector3 (15.07229f, 3.85198f, 2.818187f);

            //Object.Destroy(other.gameObject.GetComponent<Rigidbody>());

            //gameObject.transform.position = CPUMarker.transform.position;






            //FixedJoint joint = other.gameObject.AddComponent<FixedJoint>();
            //joint.connectedBody = other.gameObject.GetComponent<Rigidbody>();


            //change to next part
        }
        else if (other.tag == currentPartName&&currentPartName=="rgb")
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
