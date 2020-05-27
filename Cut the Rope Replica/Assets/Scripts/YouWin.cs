using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour {

	public void BackButton () {
		SceneManager.LoadScene ("Main Menu");
	}
		
	public void Episodes () {
		SceneManager.LoadScene ("Episodes Menu");
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void Continue(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);	
			}

	public void OverAgain(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);	
	}

}
