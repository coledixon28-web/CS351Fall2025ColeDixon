using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{

	public GameObject projectilePrefab;
//reference to fire point transform


	public Transform firePoint;

       // Update is called once per frame
    void Update()
    {
        
	//if player presses fire button call shoot
	if(Input.GetButtonDown("Fire1"))
	{
	//call the shoot function
	Shoot();
	}





    }

void Shoot()
{
GameObject firedProjectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
//destroy projectile after 3 seconds
Destroy(firedProjectile, 3f);
}
}
