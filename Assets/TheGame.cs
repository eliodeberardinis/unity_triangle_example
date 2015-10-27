using UnityEngine;
using System.Collections;

public class TheGame : MonoBehaviour {
	static readonly int[] triangle_indices = { 0, 1, 2,2,3,0 };
	static readonly int[] line_indices = { 0, 1, 1, 2, 2,3,3, 0 };
	static readonly Vector3[] vertices = {
		new Vector3(-5, -5, 0),
		new Vector3(-5, 5, 0),
		new Vector3( 5, 5, 0),
		new Vector3( 5,-5, 0),
	};

	void make_triangle(Vector3 pos) {
		GameObject go = new GameObject ();
		go.name = "Square";
		
		go.transform.localPosition = new Vector3 (-15, 0, 20);
		go.transform.Translate(new Vector3(pos.x, pos.y, pos.z));
		
		MeshFilter mf = go.AddComponent<MeshFilter> ();
		go.AddComponent<MeshRenderer> ();
		
		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.triangles = triangle_indices;
		mf.mesh = mesh;
	}
	
	
	
	
	
	void make_wireframe() {
		GameObject go = new GameObject ();
		go.name = "wireframe";
		go.transform.localPosition = new Vector3 (10, 0, 20);

		MeshFilter mf = go.AddComponent<MeshFilter> ();
		go.AddComponent<MeshRenderer> ();

		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.SetIndices (line_indices, MeshTopology.Lines, 0);
		mf.mesh = mesh;
	}
	
	// Use this for initialization
	void Start () {
		int i;
		for (i=0;i<3;i++)
		{
			Vector3 temp = new Vector3(15*i, -5 + i*10, i*10);
			make_triangle (temp);
		
		}
		
		//make_wireframe ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
