using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMotion : MonoBehaviour {

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () 
	{
		this.transform.Translate (new Vector3 (-0.1f, 0, 0) * speed, Space.World);
//		this.transform.position = this.transform.position + (this.transform.up * Time.deltaTime * speed);	
		//		this.transform.position = this.transform.position + (this.transform.right * Time.deltaTime * speed);	
		//		this.transform.position = this.transform.position + (this.transform.forward * Time.deltaTime * speed);	

		this.transform.Rotate (new Vector3 (2, 2, 2) * speed);

//		float y = this.transform.position.y;
		//		this.transform.localScale += 0.1f * speed * (new Vector3 (Mathf.Sin (y), Mathf.Sin (y), Mathf.Sin (y)));
	}
}
