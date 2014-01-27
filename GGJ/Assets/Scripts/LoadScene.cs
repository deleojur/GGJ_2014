using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public string sceneName;

	void OnMouseDown()
	{
		//Assign scenes in build settings
		Application.LoadLevel(sceneName);
	}

}
