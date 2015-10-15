
/*
 * Source file name: 	SpawnManager.cs 
 * Author's name:		Alexander Man
 * Last Modified by:	Alexander Man
 * Date Last Modified:	October 14th, 2015
 * Description:
 * 
 * This controls the spawning of platforms.
 * 
*/

using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	//declaring variables
	public int maxPlatforms = 20;
	public GameObject platform;
	public float horizontalMin = 3.5f;
	public float horizontalMax = 4.5f;
	public float verticalMin = -6f;
	public float verticalMax = 6f;
	
	private Vector2 originPosition;


	// Use this for initialization
	void Start () {
		//calling the origin frame to frame updates on position
		originPosition = transform.position;

		//calling the Spawn() function
		Spawn ();
	}
	//Spawn() function
	void Spawn()
	{
		for (int i = 0; i < maxPlatforms; i++)
		{
			Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			//creates a platform via random position with no rotation
			Instantiate(platform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
	}
}
