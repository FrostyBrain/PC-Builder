using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;
using static OVRInput;

public class HaloScript : MonoBehaviour
{
    [SerializeField]
    public GameObject Part;


    private Component theHalo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("state of primary hand trigger is: " + OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch));

        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch) == 1f)
        {
            Part.GetComponent<Light>().enabled = true;

        }
        else if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch) < 1f)
        {
            Part.GetComponent<Light>().enabled = false;

        }
        // gives halo effect if grabbed with left hand


        /*
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) == 1f)
        {
            Part.GetComponent<Light>().enabled = true;

        }
        else if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) < 1f)
        {
            Part.GetComponent<Light>().enabled = false;

        }
        // supposed to give halo effect if grabbed with right hand, I'll worry about it later
        */
    }
}
