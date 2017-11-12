using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Drinking : MonoBehaviour {

    public int drunkScore = 0;
    public Text drunkText;
    private AudioSource gulp;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnTriggerStay(Collider other)
    {
       
        if(other.gameObject.tag == "Drink")
        {
            
            Debug.Log("Chug Chug Chug");
            drunkScore = drunkScore + 1;
            

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        gulp = GetComponent<AudioSource>();
        gulp.enabled = true;
        gulp.Play();
        
        gulp.loop = true;
       
    }

    public void OnTriggerExit(Collider other)
    {
        gulp.loop = false;
        gulp.enabled = false;
    }
}
