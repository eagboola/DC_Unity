using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

	public AudioSource audio;


	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame

	void ExampleClass () 
	{

	}

	void orbit ()
	{
		/*if (G.tag == ("smallRock")) {
			orbit.stop;

		}*/
	}

	void OnCollisionEnter ()
	{
		
	}

	}


