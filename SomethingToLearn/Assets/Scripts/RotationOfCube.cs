using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Starting...");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.left * 10 * Time.deltaTime);
	}
}
