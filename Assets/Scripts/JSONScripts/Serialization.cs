using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Serialization : MonoBehaviour {

	string sequencePath;
	string sequenceJSONString;

	string boardPath;
	string boardJSONString;

	string menuPath;
	string menuJSONString;

	string chamberPath;
	string chamberJSONString;

	string cutScenePath;
	string cutSceneJSONString;


	public static SequenceConfig sequenceConfig;
	public static BoardConfig boardConfig;
	public static MenuConfig menuConfig;
	public static ChamberConfig chamberConfig;
	public static CutSceneConfig cutSceneConfig;

	void Awake () {

		//TODO: Find solution for JSON on Android

		sequencePath = Application.streamingAssetsPath + "/Sequence.json";
		menuPath = Application.streamingAssetsPath + "/MainMenu.json";
		boardPath = Application.streamingAssetsPath + "/TestLevel1.json";
		chamberPath = Application.streamingAssetsPath + "/Chamber.json";
		cutScenePath = Application.streamingAssetsPath + "/CutScene.json";

		//Fuck it. For now, not reading JSON from external JSON file, so config will go here for the time being.

		string jsonString = "{ \"sequences\": [{\"seq1\":\"8484239823\",\"seq2\":\"Powai\",\"seq3\":\"Random Nick\"}]}";
		string jsonString2 = "{ \"sequences\": [\"fuu fuu\",\"fee fee\",3,4]}";


		SeqArray seqArray = JsonUtility.FromJson<SeqArray> (jsonString2);
		//Debug.Log (seqArray.sequences [0]);

		for (int i = 0; i < seqArray.sequences.Count; i++){
			//Debug.Log(seqArray.sequences[i].faa_faa);
		}


		//MAKE THIS INTO A SINGLE FUNCTION ------------------------

		// Main Menu JSON
		if (Application.platform == RuntimePlatform.Android) { //Need to extract file from apk first
			WWW menuReader = new WWW (menuPath);

			while (!menuReader.isDone) {}

			menuJSONString = menuReader.text;
		} else {

			menuJSONString = File.ReadAllText (menuPath);
		}

		//Board JSON 
		if (Application.platform == RuntimePlatform.Android) { //Need to extract file from apk first
			WWW boardReader = new WWW (boardPath);

			while (!boardReader.isDone) {}

			boardJSONString = boardReader.text;
		} else {
			
			boardJSONString = File.ReadAllText (boardPath);
		}

		//Chamber JSON 
		if (Application.platform == RuntimePlatform.Android) { //Need to extract file from apk first
			WWW chamberReader = new WWW (chamberPath);

			while (!chamberReader.isDone) {}

			chamberJSONString = chamberReader.text;
		} else {

			chamberJSONString = File.ReadAllText (chamberPath);
		}

		//Cut Scene JSON 
		if (Application.platform == RuntimePlatform.Android) { //Need to extract file from apk first
			WWW cutSceneReader = new WWW (cutScenePath);

			while (!cutSceneReader.isDone) {}

			cutSceneJSONString = cutSceneReader.text;
		} else {

			cutSceneJSONString = File.ReadAllText (cutScenePath);
		}
		//--------------------------------------
	
		sequenceConfig = JsonUtility.FromJson<SequenceConfig> (sequenceJSONString);
		menuConfig = JsonUtility.FromJson<MenuConfig> (menuJSONString);
		boardConfig = JsonUtility.FromJson<BoardConfig> (boardJSONString);
		chamberConfig = JsonUtility.FromJson<ChamberConfig> (chamberJSONString);
		cutSceneConfig = JsonUtility.FromJson<CutSceneConfig> (cutSceneJSONString);

	}
}
