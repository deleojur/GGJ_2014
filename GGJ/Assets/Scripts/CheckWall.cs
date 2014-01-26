using UnityEngine;
using System.Collections;

public class CheckWall : MonoBehaviour {
	
	void OnTriggerEnter(Collider other)
	{
		if ( other.tag != "Enemy" )
			this.transform.parent.GetComponent<EnemieMove>().SwitchDirection();
	}
}
