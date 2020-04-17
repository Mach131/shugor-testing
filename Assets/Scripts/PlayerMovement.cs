using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float horizontalSpeed = 0.2f;
	public float verticalSpeed = 0.2f;

	public Transform cameraLerp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var horiz = Input.GetAxis("Horizontal"); //set "horiz" to a float representing left and right.
		var vertic = Input.GetAxis("Vertical"); //set "vertic" to a float representing up and down.
		if (horiz!=0.0f || vertic!=0.0f) { //if left, right, up or down is pressed
			transform.position+=new Vector3(horizontalSpeed*horiz,0.0f,verticalSpeed*vertic)*0.1f; //movement
		}
			cameraLerp.localPosition = new Vector3(horiz*1.0f,0.0f,vertic*0.5f); //move the camera slightly ahead of the player's movement
	}
}
