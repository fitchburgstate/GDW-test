using UnityEngine;
using System.Collections;

public class CubeSpawn : MonoBehaviour {

	public int Age = 20;
	public string name = "Jeff";
	public string thisClass;

	public GameObject cubePrefab;

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World");
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate (cubePrefab);
	}
}
