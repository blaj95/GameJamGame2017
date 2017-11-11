using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandController : MonoBehaviour
{
    public static bool rightFly;

	// Update is called once per frame
	void Update ()
    {
        
        transform.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        transform.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "RightFly")
        {
            rightFly = true;
            Debug.Log("flyyyR");
        }
        
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "RightFly")
        {
            rightFly = false;
            Debug.Log("StopFlyingR");
        }
    }


}
