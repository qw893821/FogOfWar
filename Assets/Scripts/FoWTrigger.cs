using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoWTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        
        if (col.tag == "fog")
        {
            col.transform.GetComponent<Renderer>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "fog")
        {
            col.transform.GetComponent<Renderer>().enabled = true;
        }
    }
}
