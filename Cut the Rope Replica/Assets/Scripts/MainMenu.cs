using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void Episodes (){
		SceneManager.LoadScene ("Episodes Menu");
	}

	public void Quit (){
		Debug.Log ("QUIT");
		Application.Quit ();
	}
}
