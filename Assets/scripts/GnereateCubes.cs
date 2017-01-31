/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GnereateCubes : MonoBehaviour {

	private float InstantiationTimer = 2f;
 
 void Update () {
     CreatePrefab();
 }
 
 void CreatePrefab()
 {
     InstantiationTimer -= Time.deltaTime;
     if (InstantiationTimer <= 0)
     {
         Instantiate(prefab, spawn.position, Quaternion.identity);
         InstantiationTimer = 2f;
     }
 }
 }
 */