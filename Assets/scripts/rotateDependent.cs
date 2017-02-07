using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateDependent : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () 
	{
		//Rotate object around its local X axis at 1 degree per second
		//transform.Rotate(0, 0, 1);

		//Rotate object around world's y axis
		//transform.Rotate(0, Time.deltaTime, 0, Space.terrain1);

		//transform.RotateAround((gameObject), Vector3.up, Time.deltaTime * 5);

	}

}
