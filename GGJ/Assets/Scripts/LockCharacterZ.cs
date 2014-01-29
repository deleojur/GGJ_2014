using UnityEngine;
using System.Collections;

public class LockCharacterZ : MonoBehaviour 
{
	public bool freezeX;
	public bool freezeY;
	public bool freezeZ;
	
	private float fixedX = 0;
	private float fixedY = 0;
	private float fixedZ = 0;
	
	
	public bool freezeXRot;
	public bool freezeYRot;
	public bool freezeZRot;
	
	private float fixedXRot = 0;
	private float fixedYRot = 0;
	private float fixedZRot = 0;
	
	void Start () 
	{
		if(freezeX) fixedX = transform.position.x;
		if(freezeY) fixedY = transform.position.y;
		if(freezeZ) fixedZ = transform.position.z;
		
		if(freezeXRot) fixedXRot = transform.rotation.eulerAngles.x;
		if(freezeYRot) fixedYRot = transform.rotation.eulerAngles.y;
		if(freezeZRot) fixedZRot = transform.rotation.eulerAngles.z;
		
		
	}
	
	void Freeze( ) 
	{
		float newX, newY, newZ;
		newX = freezeX ? fixedX : transform.position.x;
		newY = freezeY ? fixedY : transform.position.y;
		newZ = freezeZ ? fixedZ : transform.position.z;
		transform.position = new Vector3(newX, newY, newZ);
		
		float newXRot, newYRot, newZRot;
		newXRot = freezeXRot ? fixedXRot : transform.rotation.eulerAngles.x;
		newYRot = freezeYRot ? fixedYRot : transform.rotation.eulerAngles.y;
		newZRot = freezeZRot ? fixedZRot : transform.rotation.eulerAngles.z;
		Quaternion tempRot = Quaternion.identity;
		tempRot.eulerAngles = new Vector3(newX, newY, newZ);
		transform.rotation = tempRot;
		
	}
	
	void Update ()
	{
		Freeze();
	}
}