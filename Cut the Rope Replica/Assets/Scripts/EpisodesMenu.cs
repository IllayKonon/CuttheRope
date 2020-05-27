using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EpisodesMenu : MonoBehaviour {

	// Use this for initialization
	public void BackButton () {
		SceneManager.LoadScene ("Main Menu");
	}
	
	// Update is called once per frame
	public void FirstEpisode () {
		SceneManager.LoadScene ("Main");
	}

	public void SecondEpisode () {
		SceneManager.LoadScene ("Scene2");
	}

	public void ThirdEpisode () {
		SceneManager.LoadScene ("Scene3");
	}
}
