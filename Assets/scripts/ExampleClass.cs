using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExampleClass : MonoBehaviour {
    void Start ()
	{
		GameObject lightGameObject = new GameObject ("The Light");
		Light lightComp = lightGameObject.AddComponent<Light> ();
		lightComp.color = Color.blue;
		lightGameObject.transform.position = new Vector3 (0, 5, 0);
	}

}
