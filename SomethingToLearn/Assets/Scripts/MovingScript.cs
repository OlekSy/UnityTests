using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour {

    bool isMovingForward = false;
    bool isMovingBack    = false;
    bool isMovingLeft    = false;
    bool isMovingRight   = false;

    // Use this for initialization
    void Start () {
        Debug.Log("Starting");
	}
	
	// Update is called once per frame
	void Update () {
        // W key pressed or realesed
        if (Input.GetKeyDown(KeyCode.W))
        {
            isMovingForward = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            isMovingForward = false;
        }

        // S key pressed or realesed
        if (Input.GetKeyDown(KeyCode.S))
        {
            isMovingBack = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            isMovingBack = false;
        }

        // A key pressed or realesed
        if (Input.GetKeyDown(KeyCode.A))
        {
            isMovingLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            isMovingLeft = false;
        }

        // D key pressed or realesed
        if (Input.GetKeyDown(KeyCode.D))
        {
            isMovingRight = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            isMovingRight = false;
        }

        if (isMovingForward)
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }
        if (isMovingBack)
        {
            transform.Translate(Vector3.back * 10 * Time.deltaTime);
        }
        if (isMovingLeft)
        {
            transform.Translate(Vector3.left * 10 * Time.deltaTime);
        }
        if (isMovingRight)
        {
            transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
    }
}
