using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFly : MonoBehaviour {

    public float speed = 10f;

    public Vector3 startPos;

	// Use this for initialization
	public void Start ()
    {
        





    }
	
	// Update is called once per frame
	public void Update ()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            transform.Translate(startPos);
        }
        OVRPlayerController pCon = GetComponent<OVRPlayerController>();
        bool LeftHandFly = LeftHandController.leftFly;
        bool RightHandFly = RightHandController.rightFly;

        if (LeftHandFly == true && RightHandFly == true)
        {


            transform.position = transform.position + Camera.main.transform.forward * Time.deltaTime * speed;

            Debug.Log("NOWFLYYYYY");
            pCon.GravityModifier = 0.0f;
        }
        //else if (LeftHandFly == false || RightHandFly == false)
        //{
        //    pCon.GravityModifier = 0.3f;
        //}
        //else
        //{
        //    pCon.GravityModifier = 0.0f;
        //}
       

        


    }
}
