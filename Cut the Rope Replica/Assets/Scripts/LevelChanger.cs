using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChanger : MonoBehaviour {

	public int index;
	public string levelName;

	public Image black;
	public Animator animator;

	public void StartCoroutine(int x)
	{ 
			StartCoroutine (Fading ());
	}

	IEnumerator Fading()
	{
		animator.SetBool ("Fade", true);
		yield return new WaitUntil (() => black.color.a == 1);
		SceneManager.LoadScene (index);
	}
}
