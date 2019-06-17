using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// temporary debugging code
		Vector3 position = transform.position;
		position.x = 1;
		
		// say something
		print("I am the best teddy bear ever!");
	}
	
}
