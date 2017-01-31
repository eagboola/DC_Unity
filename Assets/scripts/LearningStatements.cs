using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningStatements : MonoBehaviour {

	public bool willItRainToday = true;

	// Use this for initialization
	void Start ()	{

		if (willItRainToday) {
			Debug.Log ("Yes, so you will need an umbrella.");
		} else {
			Debug.Log ("No, so you will not need an umbrella.");
		}
		}
	
	// Update is called once per frame
	void Update () {
		
	}
}
