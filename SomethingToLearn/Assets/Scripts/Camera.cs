using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    Vector3 axis = new Vector3(0, 0, 1);
    float angle = 0.0F;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate((Input.GetAxis("Mouse Y") * -100 * Time.deltaTime), (Input.GetAxis("Mouse X") * 100 * Time.deltaTime), 0, Space.World);
        if(transform.rotation.z != 0)
        {
            transform.Rotate(0, 0, -transform.rotation.z * 100);
        }
    }
}
