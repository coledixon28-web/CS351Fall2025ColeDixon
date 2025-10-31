using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	private Rigidbody2D rb;
	public float speed = 20f;

	//damage of projectile w default value of 20
	public int damage = 20;
	
	//impact effect of projectile
	public GameObject impactEffect;


    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();

	rb.velocity = transform.right * speed;  




    }

//this function called when projectile collides with another object

void OnTriggerEnter2D(Collider2D hitInfo)
{
Enemy enemy = hitInfo.GetComponent<Enemy>();

if (enemy!= null)
{
enemy.TakeDamage(damage);
}

if (hitInfo.gameObject.tag != "Player")
{
//instantiate impact effect
Instantiate(impactEffect, transform.position, Quaternion.identity);



//destory projectile
Destroy(gameObject);
}

}
   
}
