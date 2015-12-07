using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public GameObject Duck;
	
	
	// Use this for initialization
	void Start () 
	{
		GameManager.OnSpawnDucks += SpawnDuck;	
	}
	
	
	
	public void SpawnDuck()
	{
		Instantiate(Duck, transform.position, Quaternion.identity);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
