using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventManager : MonoBehaviour {

	
	public delegate void UnitEventHandler ();
	public delegate void CollisionAction();
	public static event CollisionAction onContact;

	void colorChange ()
	{
		//if(
	}

	// Use this for initialization
	void Start () {
		
	}

	void Collision ()
	{
		if (onContact != null) {
			onContact();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
