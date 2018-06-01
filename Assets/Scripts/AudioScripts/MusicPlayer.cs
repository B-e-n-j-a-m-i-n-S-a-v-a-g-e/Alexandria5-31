using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	public AudioSource efxSource;              
	public AudioSource musicSource;               
	public static MusicPlayer instance = null;               
	public float lowPitchRange = .95f;   
	public float highPitchRange = 1.05f;


	void Awake ()
	{

		if (instance == null) {
			instance = this;
		} else if (instance != this) {	
			Destroy (gameObject);
		}

		//DontDestroyOnLoad (gameObject);
	}


	public void PlaySingle(AudioClip clip)
	{
		efxSource.clip = clip;

		efxSource.Play ();
	}

}
