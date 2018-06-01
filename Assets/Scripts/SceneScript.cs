using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

	private GameObject mainMenuCamera;
	private AudioSource menuMusic;
	private GameObject ASIAMusicPlayer;
	private GameObject EGYPTMusicPlayer;
	private GameObject GRECOMusicPlayer;
	private GameObject RAINFORESTMusicPlayer;
	private bool gameBegun = false; 

	// Use this for initialization
	void Start () {

		mainMenuCamera = GameObject.Find ("Main Camera");
		menuMusic = mainMenuCamera.GetComponent<AudioSource> ();
		ASIAMusicPlayer = GameObject.Find ("ASIAMusicPlayer");
		EGYPTMusicPlayer = GameObject.Find ("EGYPTMusicPlayer");
		GRECOMusicPlayer = GameObject.Find ("GRECOMusicPlayer");
		RAINFORESTMusicPlayer = GameObject.Find ("RAINFORESTMusicPlayer");
	}
	
	// Update is called once per frame
	void Update () {

		//PlaySceneMusic ();
	}

	public void LoadScene() {
		SceneManager.LoadScene ("Levels");
		//DontDestroyOnLoad (gameObject);
		gameBegun = true;
	}

	void PlaySceneMusic() {


		if (!gameBegun) {
			return;
		}
			
		switch (Serialization.boardConfig.GetCurrentLevel()) {


		case "ASIA":
			//Debug.Log ("inside ASIA LEVEL");
			menuMusic.mute = true;
			//Debug.Log ("AMPPPPPPPPPPPPPPP: " + ASIAMusicPlayer);
			var asiaMusic = ASIAMusicPlayer.GetComponent<AudioSource> ();
			//asiaMusic.Play ();
			//Play Asia Music
			break;

		case "EGYPT":
			menuMusic.mute = true;
			var egyptMusic = EGYPTMusicPlayer.GetComponent<AudioSource> ();
			//egyptMusic.Play ();
			//PlayEgypt music
			break;

		case "GRECO":
			menuMusic.mute = true;
			var grecoMusic = GRECOMusicPlayer.GetComponent<AudioSource> ();
			grecoMusic.Play ();
			//Play Greco Music
			break;

		case "RAINFOREST":
			menuMusic.mute = true;
			var rainforestMusic = RAINFORESTMusicPlayer.GetComponent<AudioSource> ();
			rainforestMusic.Play ();
			//Play Rainforest music
			break;
		
		}
	}

}
