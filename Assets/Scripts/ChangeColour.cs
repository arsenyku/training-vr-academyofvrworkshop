using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {

	public MeshRenderer meshRenderer;

	// Use this for initialization
	void Start () {
		
		meshRenderer = this.GetComponent<MeshRenderer> ();
	}

	public void ChangeMyMaterial(Material newMaterial)
	{
		meshRenderer.material = newMaterial;
	}
			
}
