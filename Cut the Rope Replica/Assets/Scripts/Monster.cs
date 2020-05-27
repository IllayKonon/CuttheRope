using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

	LevelChanger lc;

	public Animator animator;

	int x;

	void OnTriggerEnter2D(Collider2D other)
	{
		Anim ();
		if (other.CompareTag ("Candy")) {
			lc.StartCoroutine (x);
			Destroy (other.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		lc = FindObjectOfType<LevelChanger> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Anim(){
		animator.SetTrigger ("Eat");
	}
}
