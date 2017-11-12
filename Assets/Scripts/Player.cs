using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    private AudioSource ringBlip;
    public Text Score;
    [SerializeField]
    int playerScore;
    public GameObject gameRig;
    
    
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
            if (Drinking.drunkScore <= 100 && Drinking.drunkScore > 0)
            {
                playerScore = playerScore + 1;
            }
            else if(Drinking.drunkScore  <= 200 && Drinking.drunkScore > 100)
            {
                playerScore = playerScore + 5;
                Debug.Log("EEEEEE");
            }
            else if (Drinking.drunkScore  <= 300 && Drinking.drunkScore > 200)
            {
                playerScore = playerScore + 10;
            }
            else if (Drinking.drunkScore <= 400 && Drinking.drunkScore > 300)
            {
                playerScore = playerScore + 15;
            }
            else if (Drinking.drunkScore  <= 500 && Drinking.drunkScore > 400)
            {
                playerScore = playerScore + 20;
            }
            else if (Drinking.drunkScore <= 600 && Drinking.drunkScore > 500)
            {
                playerScore = playerScore + 25;
            }
            else if (Drinking.drunkScore <= 700 && Drinking.drunkScore > 600)
            {
                playerScore = playerScore + 30;
            }
            else if (Drinking.drunkScore <= 800 && Drinking.drunkScore > 700)
            {
                playerScore = playerScore + 35;
            }
            else if (Drinking.drunkScore <= 900 && Drinking.drunkScore > 800)
            {
                playerScore = playerScore + 40;
            }
            else if (Drinking.drunkScore <= 1000 && Drinking.drunkScore > 900)
            {
                playerScore = playerScore + 50;
            }

           

            Score.text = "Player Score: " + playerScore.ToString();

        }
    }

}
