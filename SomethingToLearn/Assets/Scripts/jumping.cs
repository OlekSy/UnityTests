using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour {

    bool jump = false;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

        if (jump)
        {
            rb.velocity = new Vector3(0, 10, 0);
            jump = false;
        }
    }
}
