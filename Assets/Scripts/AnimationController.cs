using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		var horiz = Input.GetAxis("Horizontal");
		var vertic = Input.GetAxis("Vertical");
		anim.SetFloat("Horizontal",horiz); //Sending the horizontal value to the animator component.
		anim.SetFloat("Vertical",vertic); //Sending the vertical value to the animator component.
		if (horiz!=0.0f) {
			transform.localScale = new Vector3(Mathf.Sign(horiz)*-1f*Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z); //sets the player model's direction.
		}
	}
}
