using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

    public Camera vrCamera;

	// Use this for initialization
	void Start () {
        if (FindObjectOfType<Camera>().tag=="MainCamera")
        {
            vrCamera = GetComponent<Camera>();	
        }
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(transform.position + vrCamera.transform.rotation * Vector3.forward, vrCamera.transform.rotation * Vector3.up);
        transform.LookAt(vrCamera.transform.position);
    }
}
