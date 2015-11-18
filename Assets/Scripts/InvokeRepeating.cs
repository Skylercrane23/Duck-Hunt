using UnityEngine;
using System.Collections;

public class InvokeRepeating : MonoBehaviour {

	public GameObject Duck;
	
	
	void Start()
	{
		InvokeRepeating("SpawnDuck", 2, 1);
	}
	
	void SpawnDuck()
	{
		float x = Random.Range(-2.0f, 2.0f);
		float z = Random.Range(-2.0f, 2.0f);
		Instantiate(Duck, new Vector3(x, 2, z), Quaternion.identity);
	}
}