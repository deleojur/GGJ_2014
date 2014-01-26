using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour 
{
	public 	GameObject   	spawnObject;
	public 	float    		spawnDelay 			= 1f;
	public 	bool    		spawnAtRandomSpeed 	= false;
	public 	float    		randomRangeMin 		= 1f;
	public	float    		randomRangeMax 		= 10f;
		
	 // Use this for initialization
	void Start( ) 
	{
		
		StartCoroutine( StartSpawning( ) );
	}
	
	//0 for left, 1 for right.
	public static int direction { get; private set; }
	
	IEnumerator StartSpawning( )
	{
		yield return new WaitForSeconds( 5 );
		while ( true )
		{
	   		Instantiate( spawnObject, transform.position, spawnObject.transform.rotation );
			direction		= ( int )Random.Range( 0, 2 );
	   		if( spawnAtRandomSpeed ) 
				spawnDelay = Random.Range( randomRangeMin, randomRangeMax );
	   		yield return new WaitForSeconds( spawnDelay );
		}
	}
}