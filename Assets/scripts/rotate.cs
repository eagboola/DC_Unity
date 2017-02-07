using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () 
	{
		//Rotate object around its local X axis at 1 degree per second
		transform.Rotate(0, 0, Time.fixedDeltaTime*10);

		//Rotate object around world's y axis
		//transform.Rotate(0, Time.deltaTime, 0, Space.World);

	}

}
