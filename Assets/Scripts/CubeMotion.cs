using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMotion : MonoBehaviour {

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.position = this.transform.position + (this.transform.up * Time.deltaTime * speed);	
//		this.transform.position = this.transform.position + (this.transform.right * Time.deltaTime * speed);	
//		this.transform.position = this.transform.position + (this.transform.forward * Time.deltaTime * speed);	

		Vector3 x = new Vector3 (0, 2, 0);
		this.transform.Rotate (x * speed);
	}
}
