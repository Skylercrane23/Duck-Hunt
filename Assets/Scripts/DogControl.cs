using UnityEngine;
using System.Collections;

public class DogControl : MonoBehaviour 
{
	Animator anim;
	

	// Use this for initialization
	void Start () 
	{
		
		GameManager.OnDuckDeath += PlayDuck;
		GameManager.OnDuckFlyAway += PlayLaugh;
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	//void Update () 
	//{
	
	//}
	
	public void SpawnDucks()
	{
		GameManager.OnSpawnDucks();
	}
	
	public void PlayLaugh()
	{
		anim.Play ("DogLaugh");
	}	
	
	public void PlayDuck()
	{
		anim.Play ("DogDuckAnimation");
	}
}
