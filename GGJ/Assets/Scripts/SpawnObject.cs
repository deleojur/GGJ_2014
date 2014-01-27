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
		yield return new WaitForSeconds( 12 );
		while ( true )
		{
	   		GameObject go = Instantiate( spawnObject, transform.position, spawnObject.transform.rotation ) as GameObject;
			direction		= ( int )Random.Range( 0, 2 );
			if(direction == 1) go.GetComponent<EnemieMove>().SwitchDirection();
	   		if( spawnAtRandomSpeed ) 
				spawnDelay = Random.Range( randomRangeMin, randomRangeMax );
	   		yield return new WaitForSeconds( spawnDelay );
		}
	}
}