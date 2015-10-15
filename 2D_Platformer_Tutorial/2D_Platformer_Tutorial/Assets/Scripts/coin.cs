
/*
 * Source file name: 	coin.cs 
 * Author's name:		Alexander Man
 * Last Modified by:	Alexander Man
 * Date Last Modified:	October 14th, 2015
 * Description:
 * 
 * This controls the coin properties.
 * 
*/

using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//if the player touches the collider of the coin then the coin disapears
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}
