using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ProcessUpdate();
		
	}

    private void ProcessUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Space Pressed");
        }
    }
}
