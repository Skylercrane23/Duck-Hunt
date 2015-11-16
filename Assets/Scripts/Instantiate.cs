using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public Transform duck;
	
	public void SpawnDuck()
	{
		Instantiate(duck, new Vector3(0,-3, 0), Quaternion.identity); 
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
