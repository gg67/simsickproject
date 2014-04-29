using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour 
{
	public float turnRate = 1f;
	public float moveRate = 1f;

	private float moveheight = 0.5f;
	private bool movingUp = false;
	private float distanceTravelled = 0f;


	public Vector3 _startPos;
	public Vector3 _finishPos;

	// Use this for initialization
	void Start ()
	{
		_startPos = transform.position;	
		_finishPos = _startPos;
		_finishPos.y += moveheight;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.RotateAround(transform.position, Vector3.up, turnRate*Time.deltaTime);

		if(movingUp)
		{
			transform.position = Vector3.Lerp(_startPos, _finishPos, distanceTravelled);
			if(distanceTravelled >= 1)
			{
				movingUp = false;
				distanceTravelled = 0f;
			}
		}
		else
		{
			transform.position = Vector3.Lerp(_finishPos, _startPos, distanceTravelled);
			if(distanceTravelled >= 1)
			{
				movingUp = true;
				distanceTravelled = 0f;
			}
		}
		distanceTravelled += moveRate*Time.deltaTime;
	}
}
