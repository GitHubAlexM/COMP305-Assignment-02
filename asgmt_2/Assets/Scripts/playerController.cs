using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {


	public Animator anim;


	// Update is called once per frame
	void Update () {
	if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetBool ("walking", true);
		} else {
			anim.SetBool ("walking", false);
		}
	}
}
