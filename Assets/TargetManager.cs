using UnityEngine;
using System.Collections;

public class TargetManager : MonoBehaviour 
{
	private GameObject[] _targets;
	public int targetsLeft;

	public static TargetManager Instance;

	void Awake()
	{
		Instance = this;
	}

	void Start ()
	{
		_targets = GameObject.FindGameObjectsWithTag("Target");	
		targetsLeft = _targets.Length;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
