using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningMethods : MonoBehaviour {

	void Awake () {

		Debug.Log("Awake method called.");

	}
	
	// Use this for initialization
	void Start () 	{

		Debug.Log("Start method called.");
	}
	
	// Update is called once per frame
	void Update () 	{

		Debug.Log("Update method called.");
		Debug.Log(Time.time);
	}
}
