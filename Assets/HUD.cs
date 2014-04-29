using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour 
{
	private TextMesh _targetsLeftTM;

	void Awake()
	{
		_targetsLeftTM = GetComponent<TextMesh>();
	}

	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		_targetsLeftTM.text = TargetManager.Instance.targetsLeft.ToString() + " targets left";			
	}
}
