using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCamera : MonoBehaviour {

	public Transform camera;
	public CameraMovement cameraMovement;
	public float teleportDistance = 10.0f;

	// Update is called once per frame
	void Update () 
	{ 
		if (GvrViewer.Instance.Triggered) 
		{
			TeleportForward ();
		}
	}

	void TeleportForward()
	{
		if (camera == null)
			return;

		Vector3 moveForward = new Vector3(0,0,teleportDistance);
		this.transform.position = this.transform.position + camera.forward + moveForward;

		if (cameraMovement != null)
			cameraMovement.speed = 0.0f;
	}
}
