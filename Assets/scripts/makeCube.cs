using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCube : MonoBehaviour {

	public GameObject cube;

void Start() {
    for (int i = 0; i < 5; i++) {
        Instantiate(cube);
    }
}
}
