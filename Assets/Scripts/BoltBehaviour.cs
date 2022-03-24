using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltBehaviour : MonoBehaviour
{
    public bool drillInCollider = false;
    Rigidbody rb;
    //value of bolt rotation
    public float boltRotation = -500f;

    //value of bolt when it's screwed into a board
    public float boltEndPositionValue;

    // value of turning speed of bolt
    public float smoooth = 5;

    //public GameObject boltTrigger;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        // position of bolt when it's screwed into a board
        Vector3 boltEndPosition = new Vector3(boltEndPositionValue, transform.localPosition.y, transform.localPosition.z);
        //checking if our drill top is in collision with bolt and is it drill turned on, if is bolt will be moving into board
        if(collision.gameObject.tag == "DrillTop" )
        {
            //// starts rotating the bolt when drill is turned on and when drill top is in collision with bolt
            //gameObject.transform.Rotate(new Vector3(0f, boltRotation, 0f) * Time.deltaTime);

            //lerping the bolt back when drill is turned on and when drill top is in collision with bolt
            //gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, boltEndPosition, Time.deltaTime * smoooth);
            //rb.drag = 1;
            drillInCollider = true;

        }

        //else if(isItTurnedOn == false)
        //{
        //    //rb.drag = 0;
        //    //gameObject.transform.Rotate(new Vector3(0f, 0f, 0f) * Time.deltaTime);
        //}

       



    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "DrillTop")
        {
            drillInCollider = false;
        }
    }





    //private void Update()
    //{
    //    isItTurnedOn = GetComponent<DrillTurningOn>().drillTurnedOn;
    //}
}
