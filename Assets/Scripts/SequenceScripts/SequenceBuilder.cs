using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceBuilder : MonoBehaviour {

	string sequencePath;
	string[] sequences;

	// Use this for initialization
	void Awake () {
		//sequencePath = Application.streamingAssetsPath + "/Sequence.json";
		//sequences = JsonUtility.FromJson<string[]>(Application.streamingAssetsPath + "/Sequence.json");
		//Debug.Log (sequences);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
