using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour {

	Renderer r;


    // Use this for initialization
    void Start()    {
		
         r = GetComponent<Renderer>();
    }

    // Update is called once per frame


    void OnCollisionEnter()
    {
        Debug.Log("Enter");
        r.material.color=new Color(255, 0, 0);
    }


}
 