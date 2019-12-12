using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUAttachment : MonoBehaviour
{
    [SerializeField]
    private GameObject CPUMarker;
    [SerializeField]
    private OVRGrabbable GrabbableRef;
    [SerializeField]
    public GameObject GrabbablePiece;
    [SerializeField]
    public GameObject FlashingPiece;
    private string currentPartName="CPU";

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == currentPartName&&currentPartName=="CPU")
        {
            //put part colliding with this collider in position/rotation of endmarker
            //Create fixed joint to fuse part to socket
            currentPartName = "cpu";
            Debug.Log("Things should be working");

            other.gameObject.transform.rotation = CPUMarker.transform.rotation;

            other.gameObject.transform.parent = CPUMarker.transform;
            //other.gameObject.transform.localPosition = new Vector3(0f, -5.577934e-17f, 0.9132603f);
            //other.gameObject.transform.localScale = new Vector3 (0.09728504f, 0.00933548f, 0.09728508f);

            //Object.Destroy(other.gameObject.GetComponent<Rigidbody>());

            //gameObject.transform.position = CPUMarker.transform.position;



            GameObject.Destroy(GrabbablePiece);
            Destroy(FlashingPiece.GetComponent<FadingScript>());



            //FixedJoint joint = other.gameObject.AddComponent<FixedJoint>();
            //joint.connectedBody = other.gameObject.GetComponent<Rigidbody>();


            //change to next part
        }
        else if (other.tag == currentPartName&&currentPartName=="motherboard")
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
