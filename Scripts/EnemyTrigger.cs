using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            col.transform.GetComponent<Renderer>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Enemy")
        {
            col.transform.GetComponent<Renderer>().enabled = false; 
        }
    }
}
