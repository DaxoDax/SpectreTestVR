using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DrillTurningOn : MonoBehaviour
{
   
    //okidac napraviti


    //button for turning on the drill
    public OVRInput.Button triggerButtonLeft;
    public OVRInput.Button triggerButtonRight;

    public AudioSource ass;
   
    //bool that references for drill if is grabbed and if hose is pluged in
    private bool plugedIn;
    private bool grabbed;
    public GameObject drill;
    public GameObject snapPointZone;

    //value for drill top for rotation and game object reference 
    private float drillTopRotation = -500f;
    public GameObject drillTop;

   // values for trigger position on z axis and game object reference
    public float minLocalTriggerZ;
    public float maxLocalTriggerZ;
    public GameObject drillTrigger;
    //speed of trigger when it's pressed
    public float smooth;

    private void Update()
    {
        plugedIn = snapPointZone.GetComponent<SnapToLocation>().plugedIn;
        grabbed = drill.GetComponent<OVRGrabbable>().isGrabbed;

        //position of trigger when drill is turned on
        Vector3 triggerOnPosition = new Vector3(drillTrigger.transform.localPosition.x, drillTrigger.transform.localPosition.y, minLocalTriggerZ);

        //position of trigger when drill is turned off
        Vector3 triggerOffPosition = new Vector3(drillTrigger.transform.localPosition.x, drillTrigger.transform.localPosition.y, maxLocalTriggerZ);

        //Checking if the drill is grabbed in and if hose is pluged in to turn on the drill 
        if (OVRInput.Get(triggerButtonLeft, OVRInput.Controller.LTouch) || OVRInput.Get(triggerButtonRight, OVRInput.Controller.RTouch) && grabbed == true && plugedIn == true)
        {
            //starts rotating drill top when drill is turned on
            drillTop.transform.Rotate(new Vector3(0f, drillTopRotation, 0f) * Time.deltaTime);

            //lerping the trigger back when trigger is pressed
            drillTrigger.transform.localPosition = Vector3.Lerp(drillTrigger.transform.localPosition, triggerOnPosition, Time.deltaTime * smooth);

            //playing a drill sound
            if (!ass.isPlaying)
            {
                ass.Play();
            }
        }

        
        else
        {
            //lerping the trigger forward when trigger is released
            drillTrigger.transform.localPosition = Vector3.Lerp(drillTrigger.transform.localPosition, triggerOffPosition, Time.deltaTime * smooth);
            //turning off drill sound
            if (ass.isPlaying)
            {
                ass.Stop();
            }
        }
       
    }
}
