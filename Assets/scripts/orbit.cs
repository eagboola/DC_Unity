﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(GameObject.Find("otherRockPlatform").transform.position, GameObject.Find("otherRockPlatform").transform.position, 300*Time.deltaTime);
	}
}
