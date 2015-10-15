
/*
 * Source file name: 	DeathTrigger.cs 
 * Author's name:		Alexander Man
 * Last Modified by:	Alexander Man
 * Date Last Modified:	October 14th, 2015
 * Description:
 * 
 * This controls the invisible cube that exists below the platforms.
 * When the player falls, instead of ever falling, the player resets on a new map.
 * 
*/

using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// OnTriggerEnter2D () function
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
