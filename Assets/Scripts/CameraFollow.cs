using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform cameraParent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position=Vector3.Lerp(transform.position, cameraParent.position, 0.2f); //Moves the camera towards the player's position smoothly.
	}
}
