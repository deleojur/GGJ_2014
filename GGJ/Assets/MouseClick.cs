using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour {

	public Color color;
	public Color pressed;
	public Color hover;

	void OnMouseEnter()
	{
		transform.GetComponent<MeshRenderer> ().material.color = hover;
	}
	
	void OnMouseExit()
	{
		transform.GetComponent<MeshRenderer> ().material.color = color;
	}
	
	void OnMouseDown()
	{
		//Assign scenes in build settings
		Application.LoadLevel("Scene1");
	}
	
	void OnMouseUp()
	{
		transform.GetComponent<MeshRenderer> ().material.color = color;
	}
}
