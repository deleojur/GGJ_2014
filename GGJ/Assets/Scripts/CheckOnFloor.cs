using UnityEngine;
using System.Collections;

public class CheckOnFloor : MonoBehaviour {
	
	private bool objectOnFloor;

	/*void OnTriggerEnter( Collider other )
	{
		Transform[] t	= LavaScript.lastPlatforms;
		for ( int i = 0; i < t.Length; ++i )
		{
			if ( other.transform == t[i] )
			{
				LavaScript.IncreaseLava( );
				GameObject.Destroy( gameObject );
			}
		}
	}*/
	
	void OnTriggerStay( )
	{
		objectOnFloor = true;
	}

	void OnTriggerExit()
	{
		objectOnFloor = false;
	}

	public bool GetIsOnFloor()
	{
		return objectOnFloor;
	}
}
