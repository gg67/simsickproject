using UnityEngine;
using System.Collections;

public class StartGUI : MonoBehaviour 
{

	void OnGUI() 
	{
		if (GUI.Button(new Rect(10, 10, 150, 100), "HeadLook"))
			Application.LoadLevel("HeadLook");

		if (GUI.Button(new Rect(10, 110, 150, 100), "No HeadLook"))
			Application.LoadLevel("NoHeadLook");
	}
}
