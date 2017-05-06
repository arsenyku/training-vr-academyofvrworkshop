using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement: MonoBehaviour {

	public float speed = 1.0f;
	public Transform cameraTransform;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.position = this.transform.position + (cameraTransform.forward * Time.deltaTime * speed);	
	}

	
}
