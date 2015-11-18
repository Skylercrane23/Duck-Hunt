using UnityEngine;
using System.Collections;

public class InvokeScript : MonoBehaviour {

	public GameObject Duck;

	
	void Start()
	{
		Invoke("SpawnDuck", 3);
	}
	
	void SpawnDuck()
	{
		Instantiate(Duck, new Vector3(0, 2, 0), Quaternion.identity);
	}
}