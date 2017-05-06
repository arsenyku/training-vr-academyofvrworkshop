using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {

	public Color newColour;

	// Use this for initialization
	void Start () {
		
	}

	public void ChangeMyColour()
	{
		this.GetComponent<MeshRenderer> ().material.color = newColour;
	}
			
}
