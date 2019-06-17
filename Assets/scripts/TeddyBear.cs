using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

// Moves the game object
public class TeddyBear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		// get the game object moving
		// Rigidbody2D is the data type of the component we want to move
		
		/* Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
		rb2d.AddForce(new Vector2(1, 0), 
			ForceMode2D.Impulse); */
		
		/* GetComponent<Rigidbody2D>().AddForce(
			new Vector2(1, 0), 
			ForceMode2D.Impulse); */

		// range of impulse forces to apply
		const float MinImpulseForce = 3f;
		const float MaxImpulseForce = 5f;
		
		// get a random angle between 0 to 2pi (0 to 180 degrees)
		float angle = Random.Range(0, 2 * Mathf.PI);
		
		Vector2 direction = new Vector2(
			Mathf.Cos(angle), Mathf.Sin(angle));
		
		// get a random magnitude within our range of impulse forces
		float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
		GetComponent<Rigidbody2D>().AddForce(
			direction * magnitude,
			ForceMode2D.Impulse);
	}

	private void OnCollisionEnter2D(Collision2D other) {
		print("ouch");
	}
}

