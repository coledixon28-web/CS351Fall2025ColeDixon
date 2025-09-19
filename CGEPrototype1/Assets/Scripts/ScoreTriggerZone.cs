using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerZone : MonoBehaviour
{

	// create variable to keep track of whether thr trigger zone is active
	bool active = true;

   	private void OnTriggerEnter2D(Collider2D collision)
		{
		// if trigger zone is active
	if (active && collision.gameObject.tag == "Player")
	{
		// deactivate the trigger zone
	active = false;

		// add one to score when player enters trigger zone
		ScoreManager.score++;
		// destroy this gameobject
		Destroy(gameObject);

		}

	}


}
