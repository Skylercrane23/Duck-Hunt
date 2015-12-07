using UnityEngine;
using System.Collections;

public class DuckHealth : MonoBehaviour 
{
	
	Animator anim;
	
	bool isInvincible; 
	
	void Start ()
	{
		GameManager.OnDuckMiss += MakeInvincible;
		GameManager.OnDuckShot += MakeInvincible;
		anim = GetComponent<Animator>();
		
	}

	void OnTriggerEnter(Collider hit)
	{
		if(hit.tag == "KillZone")
		{
			GameManager.OnDuckDeath();
			Destroy(this.gameObject);
		}
		if(hit.tag == "FlyZone")
		{
			GameManager.OnDuckFlyAway();
			Destroy(this.gameObject);
			
		}
	}
	public void KillDuck()
	{
		if(isInvincible == false)
		{
			anim.Play("DuckDead");
			GameManager.OnDuckShot();
		}
	}
	
	public void MakeInvincible()
	{
		isInvincible = true;
	}

}