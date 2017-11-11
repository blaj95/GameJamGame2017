using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    private AudioSource ringBlip;
    public Text Score;
    [SerializeField]
    int playerScore;
    
	// Use this for initialization
	public void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        

    }

    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Ring")
        {
            ringBlip = other.GetComponent<AudioSource>();
            ringBlip.Play();
            playerScore = playerScore + 1;
            Score.text = playerScore.ToString();

        }
    }

}
