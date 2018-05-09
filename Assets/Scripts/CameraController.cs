using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera mainCamera;
    public Camera subCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.C))
        {
            mainCamera.enabled = false;
            subCamera.enabled = true;
        }
        else {
            mainCamera.enabled = true;
            subCamera.enabled = false;
        }
	}
}
