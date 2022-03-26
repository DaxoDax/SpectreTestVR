using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltBehaviour : MonoBehaviour
{
    /// <summary>
    /// This script serves to check if drill top is in collision with bolt. 
    //If it is, boolen value will be send in DrillTurningOn script as true and then
    //  if player turn on drill and start to screw a bolt, bolt will rotate in direction as drill top
    /// </summary>

    public bool drillInCollider = false;

    //value of bolt rotation
    public float boltRotation = -500f;

    //value of bolt when it's screwed into a board
    public float boltEndPositionValue;

    // value of turning speed of bolt
    public float smoooth = 5;

   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "DrillTop" )
        {
           
            drillInCollider = true;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "DrillTop")
        {
            drillInCollider = false;
        }
    }


}
