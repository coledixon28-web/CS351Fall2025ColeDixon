using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
//enemy health
	public int health = 100;

	public GameObject deathEffect;

	//reference to healthbar
	private DisplayBar healthBar;

private void Start()
{
//find healthbar in children of enemy
healthBar = GetComponentInChildren<DisplayBar>();

if (healthBar == null )
{
Debug.LogError("HealthBar (DisplayBar script) not found");
return;
}


healthBar.SetMaxValue(health);


}


	public void TakeDamage(int damage)
{

	//subtract the damage dealt
	health -= damage;

// update health bar

	healthBar.SetValue(health);

if(health <= 0)
	{
	Die();
	}

	}
void Die()
	{
	Instantiate(deathEffect, transform.position, Quaternion.identity);
	
	Destroy(gameObject);
	}




  }
