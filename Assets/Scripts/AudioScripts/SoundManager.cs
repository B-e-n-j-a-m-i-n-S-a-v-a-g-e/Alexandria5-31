using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	AudioSource audioSuccess;

	void Awake () {
		audioSuccess = GetComponent<AudioSource> ();
	}

	public void PlaySound(AudioSource audio) {
		//audio.Play ();
	}
}
