using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionPopUp : MonoBehaviour
{
    [SerializeField]
    private GameObject InfoPlane;

    [SerializeField]
    private GameObject Part;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch) == 1f)
        {
            InfoPlane.gameObject.SetActive(true);

        }
        else if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch) < 1f)
        {
            InfoPlane.gameObject.SetActive(false);

        }
    }
}
