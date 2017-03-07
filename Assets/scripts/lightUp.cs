using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightUp : MonoBehaviour {

	public Light L;
	
	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter ()
	{
		L.intensity = 100;
		L.range = 125;
	}

	void OnCollisionStay ()
	{
		//GameObject.FindGameObjectsWithTag ("smallRock").transform.position = transform.RotateAround 

	}

	void OnCollisionExit ()
	{
		L.intensity = 0;
		L.range = 0;
	}


	// Update is called once per frame
	void Update () {
		
	}
}
