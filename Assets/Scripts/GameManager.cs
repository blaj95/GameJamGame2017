using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Drinking.isDrunk == true)
        {
            StartCoroutine("Puke");
        }
	}

    IEnumerator Puke()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
