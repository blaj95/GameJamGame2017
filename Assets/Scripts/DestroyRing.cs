using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRing : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("Wait");
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
