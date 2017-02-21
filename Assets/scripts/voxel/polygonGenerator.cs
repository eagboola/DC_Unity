using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polygonGenerator : MonoBehaviour {

	//This first list contains every vertex of the mesh that will be rendered
	public List<Vector3> newVertices = new List<Vector3>();

	//The triangles tell Unity how to build each section of the mesh joining the vertices
	public List<int> newTriangles = new List<int>();

	//The UV list is unimportant now, but tells Unity how the texture is aligned on each polygon
	public List<Vector2> newUV = new List<Vector2>();

	//A mesh is made of the vertices, triangles, and UVs we are going to define. After they are made they will be saved as a mesh
	private Mesh mesh;

	private float tUnit = 0.25f;
		private Vector2 tStone = new Vector2 (0, 0);
		private Vector2 tGrass = new Vector2 (0, 1);



	// Use this for initialization
	void Start () {
		mesh = GetComponent<MeshFilter> ().mesh;



		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;

		newVertices.Add(new Vector3 (x, y, z));
		newVertices.Add(new Vector3 (x +1, y, z));
		newVertices.Add( new Vector3 (x+1, y-1, z));
		newVertices.Add( new Vector3 (x, y-1, z));

		newTriangles.Add(0);
		newTriangles.Add(1);
		newTriangles.Add(3);
		newTriangles.Add(1);
		newTriangles.Add(2);
		newTriangles.Add(3);

		mesh.Clear();
		mesh.vertices = newVertices.ToArray();
		mesh.triangles = newTriangles.ToArray();
		//mesh.Optimize();
		//MeshUtility.optimize(Mesh "mesh");
		mesh.RecalculateNormals();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
