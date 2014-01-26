using UnityEngine;
using System.Collections;

public class SequenceComponentScript : MonoBehaviour 
{
	public Sequence sequenceManager	{ get; set; }
	public int sequenceID			{ get; set; }
	
	
	void OnTriggerEnter( Collider other )
	{
		if ( other.tag == "Player" )
		{
			sequenceManager.OnPlayerPicksUpSequenceComponent( sequenceID );
		}
	}
}
