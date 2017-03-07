using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour {

	GameObject platform;

	public Transform center;
	public Vector3 axis = Vector3.up;
	public Vector3 desiredPosition;
	public float radius = 15.0f;
	public float radiusSpeed = 0.5f;
	public float rotationspeed = 80.0f;

	// Use this for initialization
	void Start () {
		platform = GameObject.Find("p7");
		center = platform.transform;
		transform.position = (transform.position - center.position).normalized * radius + center.position;
		radius = 2.0f;
			
	}
	
	// Update is called once per frame
	void Update () {
		//transform.RotateAround(GameObject.Find("p7").transform,.position, GameObject.Find("p7").transform.position, 30*Time.deltaTime);
		//transform.RotateAround(GameObject.Find("p7").transform.position, axis, 30*Time.deltaTime);

		transform.RotateAround(center.position, axis, rotationspeed * Time.deltaTime);
		//desiredPosition = (transform.position - center.position).normalized*radius+center.position;
		//transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime*radiusSpeed);
	}
}
