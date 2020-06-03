using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

	public void Mute(){
		AudioListener.pause = !AudioListener.pause;
	}
}
