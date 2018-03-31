using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal2 : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        other.transform.Translate(20F, 1F, -5F, Space.World);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
