using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour 
{
	void OnTriggerEnter( Collider other )
	{
		//Debug.Log( other.gameObject.tag );
		if ( other.tag	== "Enemy" )// || other.gameObject.tag == "Lava" )
		{
			GameStats.setScore( 0 );
			Application.LoadLevel( "Level1" );
		}
	}
}
