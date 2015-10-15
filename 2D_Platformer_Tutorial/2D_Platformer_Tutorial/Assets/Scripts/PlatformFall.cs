
/*
 * Source file name: 	PlatformFall.cs 
 * Author's name:		Alexander Man
 * Last Modified by:	Alexander Man
 * Date Last Modified:	October 14th, 2015
 * Description:
 * 
 * This controls the platform's falling movements.
 * 
*/

using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour {
	//declaring the properties of rigidbody2d and a delay so that the platform doesnt fall instantly
	public float fallDelay = 1f;
	
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () {
		rb2d = GetComponent<Rigidbody2D>();
	}

	//when the player touches the platform, there will be a delay before the platform fall and then the player cannot stay on the platform
	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))

		Invoke ("Fall", fallDelay);
	}
	void Fall()
	{
		rb2d.isKinematic = false;
	}
}
