using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {

	public MeshRenderer meshRenderer;
	private AudioSource noiseMaker;

	public AudioClip clip1;
	public AudioClip clip2;

	// Use this for initialization
	void Start () {
		meshRenderer = this.GetComponent<MeshRenderer> ();
		noiseMaker = this.GetComponent<AudioSource> ();
	}

	public void ChangeMyMaterial(Material newMaterial)
	{
		meshRenderer.material = newMaterial;
	}
			

	public void PlayAudioClip()
	{
		Debug.Log ("OH NOES!", noiseMaker.clip);
		noiseMaker.clip = (noiseMaker.clip == clip1) ? clip2 : clip1;
		noiseMaker.Play ();
	}
}
