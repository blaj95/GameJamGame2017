using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandController : MonoBehaviour
{
    public static bool leftFly = false; 

	// Update is called once per frame
	void Update ()
    {
        transform.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        transform.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "LeftFly")
        {
            leftFly = true;
            Debug.Log("flyyyyyyL");
        }
        
    }

    public void OnTriggerExit(Collider col)
    {
        OVRPlayerController pCon = GetComponent<OVRPlayerController>();
        if (col.gameObject.tag == "LeftFly")
        {
            leftFly = false;
            
            Debug.Log("StopFlyL");
        }
    }
}
