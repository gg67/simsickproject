using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]
public class Collectable : MonoBehaviour 
{
	public static bool collecting = false;
	public AudioClip audioClip;
	private float clipTime;

	// Use this for initialization
	void Start () 
	{
		audio.clip = audioClip;	
	}
	
	void OnTriggerEnter(Collider collider)
	{
		if(collider.tag == "Player" && !collecting)
		{
			StartCoroutine("CollectTarget");
		}
	}

	IEnumerator CollectTarget()
	{
		collecting = true;
		audio.Play();
		yield return new WaitForSeconds(0.5f);
		GameObject.Destroy(gameObject);
		TargetManager.Instance.targetsLeft--;
		collecting = false;
	}
}
