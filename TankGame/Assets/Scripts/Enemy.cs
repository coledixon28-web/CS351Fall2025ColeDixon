using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
//enemy health
	public int health = 100;

	public GameObject deathEffect;

	public void TakeDamage(int damage)
{

	//subtract the damage dealt
	health -= damage;
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
