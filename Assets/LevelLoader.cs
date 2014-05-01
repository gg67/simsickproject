﻿using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad(this);			
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevelName);
		}
	}
}
