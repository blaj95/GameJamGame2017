﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Quit")
        {
            Application.Quit();
            print("QUIT PLZ");
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
