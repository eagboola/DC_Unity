using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerScript : MonoBehaviour 
{

	public Renderer rend;
	public Color col = new Color(Random.value, Random.value, Random.value);
	public Color transition = Color.blue;

	// Use this for initialization
	void Start () 
	{

		//Get the GameObject Component of Renderer

		rend = GetComponent<Renderer> ();

		//Set the start material color
		rend.material.color = Color.blue;
	}


	void OnTriggerEnter(Collider other)
	{
		//Check that we are colliding with the First Person Controller
		if (other.name == "FPSController") 
		{
			
			//Set the material to the new transition value
			//rend.material.color = transition;
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.name == "FPSController") 
		{
			//use linear interpolation between the current value of transition and the color yellow
			transition = Color.Lerp(transition, Color.yellow, 0.01f);

			//Set material to new transition value
			rend.material.color = col;
		}
	}

	void OnTriggerExit(Collider other)
	{
		//Check that we are colliding with the First Person Controller
		if (other.name == "FPSController") 
		{
			//Reset our transition value to the starting color - magenta
			//transition = Color.magenta;

			//Reset the object material to the starting color - blue
			//rend.material.color = Color.blue;
		
		}
	}
}
