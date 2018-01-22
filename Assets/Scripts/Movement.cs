using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    
    float speed;
    Rigidbody rg;
    Vector3 targetPos;
	// Use this for initialization
	void Start () {
        speed = 4f;
	}
	
	// Update is called once per frame
	void Update () {
        Move();
    }

    void Move()
    {
        float x;
        float z;
        z= Input.GetAxisRaw("Vertical");
        x = Input.GetAxisRaw("Horizontal");
        targetPos = transform.position + new Vector3(x, 0, z).normalized;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}
