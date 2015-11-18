using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public GameObject Duck;
	
	public void SpawnDuck()
	{
		Instantiate(Duck, transform.position, Quaternion.identity);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
