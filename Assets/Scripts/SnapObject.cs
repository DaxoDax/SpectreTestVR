using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    //Reference for snap zone collider we'll be using
    public GameObject SnapLocation;

    //Reference the game object that the snapped objects will become part of
    public GameObject drill;

    //Reference for boolean variable for "Snapped" boolean from the SnapLocation script
    private bool objectSnapped;

    //boolean variable for checking if the object is currently held by the player
    private bool grabbed;

    public bool holdedByHand;





    /*In these two collision methods we are checking is it hose holded by hand, otherwise we could just
     get drill to the place where hose is on the workbench and plug it in without grabbing a hose with other hand*/
    //private void OnCollisionEnter(Collision collision)
    //{
        
    //    if (collision.gameObject.tag == "Workbench")
    //    {
    //        holdedByHand = false;
    //    }
    //    if(collision.gameObject.tag == "Workbench" && grabbed == false && objectSnapped == true)
    //    {
    //        holdedByHand = true;
    //    }
    //}

    //private void //OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Workbench" && grabbed == true)
    //    {
    //        holdedByHand = true;
    //    }
    //}


    private void Update()
    {

        holdedByHand = GetComponent<SnapToLocation>().insideSnapZone;

        //set grabbed to be equal to boolean value from the OVRGrabbable script
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;

        //set objectSnapped boolean to be equal to boolean from SnapToLocation
        objectSnapped = GetComponent<SnapToLocation>().snapped;

        //Setting object Rigidbody after it has been snapped into position so it can't fall
        // Setting object to be a parent of the drill after it has been snapped into position 

        if(objectSnapped)
        {
            GetComponent<Rigidbody>().useGravity = false;
            //GetComponent<Rigidbody>().isKinematic = true;
            transform.SetParent(drill.transform);
        }

        //Makes sure that the object can still be grabbed by the OVRGrabber script
        if (objectSnapped == false && grabbed == false)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
            
        }
    }
}
