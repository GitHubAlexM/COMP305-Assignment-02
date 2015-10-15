
/*
 * Source file name: 	SpawnCoins.cs 
 * Author's name:		Alexander Man
 * Last Modified by:	Alexander Man
 * Date Last Modified:	October 14th, 2015
 * Description:
 * 
 * This controls the spawning of coins.
 * 
*/

using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {
	//declaring array, and the coin gameobject
	public Transform[] coinSpawns;
	public GameObject coin;
	
	// Use this for initialization
	void Start () {
		//calling spawn()
		Spawn();
	}
	//the spawn() function
	void Spawn()
	{
		for (int i = 0; i < coinSpawns.Length; i++)
		{
			int coinFlip = Random.Range (0,2);
			if (coinFlip > 0)
				Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
		}
	}
}
