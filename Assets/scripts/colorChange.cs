﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour {

	Renderer r;
	// public touching = GameObject.FindObjectOfType<AudioSource>();
	//AudioSource touching;
	//public Color colorEnter;
	public Color colorStay;
	public Color colorExit;


    // Use this for initialization
    void Start()    {
    	//eventManager.onContact
		//touching.GetComponent<AudioSource>();
        r = GetComponent<Renderer>();
		eventManager.onContact += OnCollisionEnter;
    }

    // Update is called once per frame

    /*void OnEnable ()
	{
		eventManager.onContact += OnCollisionEnter;
	}

	void OnDisable ()
	{
		eventManager.onContact -= OnCollisionExit;
	}
	*/

    

   void OnCollisionEnter()
    {
        Debug.Log("Enter");
        // r.material.color=new Color(190, 110, 0);
		//Color col = new Color (Random.value, Random.value, Random.value);
		//Color col2 = new Color (190,110,0);
		//r.material.color = colorEnter;

    }

    void OnCollisionStay ()
	{
		//Color col = new Color (Random.value, Random.value, Random.value);
		r.material.color = colorStay;
		//touching.Play();

		/*if (GameObject.FindGameObjectsWithTag ("smallRock") != null) {
			r.material.color = new Color (Random.value, Random.value, Random.value);
		}*/
	}

    void OnCollisionExit ()
	{
		Debug.Log ("Left");
		r.material.color = colorExit;
	}


	/*void turnColor ()
	{
		Color col = new Color (Random.value, Random.value, Random.value);
		r.material.color = col;
	}
	*/

	void update ()
	{
		OnCollisionStay();

	}
}

 