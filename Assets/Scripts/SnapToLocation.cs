using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToLocation : MonoBehaviour
{
    //boolean variable for checking if the object is currently held by the player
    private bool grabbed;

    //boolean that returns if the object is in the SnapZone radius
    public bool insideSnapZone;

    //returns true if the object is pluged in
    public bool plugedIn = false;

    // Hose cable that we want to snap to this location
    public GameObject hosePart;
    //Reference another object that we can use to set the rotation
    public GameObject snapRotationReference;

    private bool isItHoldedByHand;

   

    
    //Checking if hose part entered the snap zone radius
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hose")
        {
            insideSnapZone = true;
        }
    }
    //Checking if hose part has left the snap zone radius
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Hose")
        {
            insideSnapZone = false;
        }
    }

    /*Checking if player no longer holds the hose object and if hose is in pluged in */
    //If the condition is met, then the object location and rotation are set to desired snap coordinates
    // Also, sets the public boolean Snapped to true for the reference by SnapObject script

    void SnapObject()
    {
        if(grabbed == false && insideSnapZone == true)
        {
            hosePart.gameObject.transform.position = transform.position;
            hosePart.gameObject.transform.rotation = snapRotationReference.transform.rotation;
            plugedIn = true;
        }

        else if (grabbed == true && insideSnapZone == false)
        {
            plugedIn = false;
        }
    }

    private void Update()
    {
       
        //isItHoldedByHand = hosePart.GetComponent<SnapObject>().holdedByHand;
        //Checking every frame if the boolean value from the OVRGrabbable script is true or not
        grabbed = hosePart.GetComponent<OVRGrabbable>().isGrabbed;
        //Calling a method
        SnapObject();
    }
}
