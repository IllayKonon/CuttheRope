using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour {

	LevelLoss ll;

	int x;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Candy")) {
			ll.StartCoroutine (x);
		}
	}

	// Use this for initialization
	void Start () {
		ll = FindObjectOfType<LevelLoss> ();
	}

}
