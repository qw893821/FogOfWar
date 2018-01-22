using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager: MonoBehaviour {
    Renderer rend;
    public GameObject fog;
	// Use this for initialization
	void Start () {
        rend = transform.GetComponent<Renderer>();
        for(int i =(int)-rend.bounds.extents.magnitude; i < rend.bounds.extents.magnitude; i++)
        {
            for(int j = (int)rend.bounds.extents.magnitude; j > -rend.bounds.extents.magnitude; j--)
            {
                float posX;
                float posZ;
                Vector3 pos;
                posX = (float)i;
                posZ = (float)j;
                pos = new Vector3(posX, 4f, posZ);
                Instantiate(fog,pos,Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
