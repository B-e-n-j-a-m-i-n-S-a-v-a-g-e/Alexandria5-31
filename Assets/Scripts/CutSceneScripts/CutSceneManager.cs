using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneManager : MonoBehaviour {

	private Utils utils;
	private string cutSceneID = "CUT_SCENE";
	private List<string> panelSequence;

	private int currentPanelNumber = 0;
	private int maxPanels = 4;

	private float initialCameraZ = -8.17f;
	private float cameraZoomIncrement = -0.1f;
	private float cameraPanIncrement = 0.1f;

	private bool canZoomCameraOut = false;
	private bool canCameraPan = false;

	void Start () {

		DontDestroyOnLoad (gameObject);
		Init ();
		//SetupSequence ();
		BuildCutScene ();
		InvokeRepeating ("ChangePanels", 0.0f, 5.0f);
	}

	void Update () {


		if (canZoomCameraOut) {
			Camera.main.transform.position += new Vector3 (0, 0, cameraZoomIncrement) * Time.deltaTime;

			if (currentPanelNumber == 2 && canCameraPan) {
				Camera.main.transform.position += new Vector3 (cameraPanIncrement, 0, 0) * Time.deltaTime;
			}
		}
	}

	void Init() {

		panelSequence = new List<string> ();
		utils = gameObject.GetComponent<Utils> ();
		InitializeCameraZoom ();
	}

	void InitializeCameraZoom() {

		Camera.main.transform.position = new Vector3 (0, 0, initialCameraZ);
		canZoomCameraOut = true;
	}

	void SetCameraPositions(float cameraXPos, float cameraYPos, float cameraZPos) {
		
		Camera.main.transform.position = new Vector3 (cameraXPos, cameraYPos, cameraZPos);
	}
		
		
	void BuildCutScene() {

		switch (currentPanelNumber) {
			
		case 1:
			utils.InstantiateObject ("CUT_SCENES/CUT_SCENES_Lab", new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_LabPositionX,
				Serialization.cutSceneConfig.CUT_SCENES_LabPositionY), new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_LabScaleX, 
				Serialization.cutSceneConfig.CUT_SCENES_LabScaleY));

			utils.InstantiateObject ("CUT_SCENES/CUT_SCENES_Scientist", new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_ScientistPositionX,
				Serialization.cutSceneConfig.CUT_SCENES_ScientistPositionY), new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_ScientistScaleX, 
				Serialization.cutSceneConfig.CUT_SCENES_ScientistScaleY));

			utils.InstantiateObject ("CUT_SCENES/CUT_SCENES_LabText", new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_LabTextPositionX,
				Serialization.cutSceneConfig.CUT_SCENES_LabTextPositionY), new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_LabTextScaleX, 
				Serialization.cutSceneConfig.CUT_SCENES_LabTextScaleY));
			break;

		case 2:

			Destroy (GameObject.Find("CUT_SCENES_LabText(Clone)"));
			SetCameraPositions (0,0,-7.4f);

			utils.InstantiateObject ("CUT_SCENES/CUT_SCENES_EgyptPyramids", new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_EgyptPyramidsPositionX,
				Serialization.cutSceneConfig.CUT_SCENES_EgyptPyramidsPositionY), new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_EgyptPyramidsScaleX, 
					Serialization.cutSceneConfig.CUT_SCENES_EgyptPyramidsScaleY));
			
			utils.InstantiateObject ("CUT_SCENES/CUT_SCENES_Jeep", new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_JeepPositionX,
				Serialization.cutSceneConfig.CUT_SCENES_JeepPositionY), new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_JeepScaleX, 
					Serialization.cutSceneConfig.CUT_SCENES_JeepScaleY));

			utils.InstantiateObject ("CUT_SCENES/CUT_SCENES_EgyptPyramidsText", new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_EgyptPyramidsTextPositionX,
				Serialization.cutSceneConfig.CUT_SCENES_EgyptPyramidsTextPositionY));

			break;

		case 3:

			Destroy (GameObject.Find("CUT_SCENES_EgyptPyramidsText(Clone)"));
			SetCameraPositions (0,0,-7.4f);

			utils.InstantiateObject ("CUT_SCENES/CUT_SCENES_Lab", new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_LabPositionX,
				Serialization.cutSceneConfig.CUT_SCENES_LabPositionY), new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_LabScaleX, 
					Serialization.cutSceneConfig.CUT_SCENES_LabScaleY));

			utils.InstantiateObject ("CUT_SCENES/CUT_SCENES_Map", new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_MapPositionX,
				Serialization.cutSceneConfig.CUT_SCENES_MapPositionY), new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_MapScaleX, 
					Serialization.cutSceneConfig.CUT_SCENES_MapScaleY));

			utils.InstantiateObject ("CUT_SCENES/CUT_SCENES_MapText", new Vector2 (Serialization.cutSceneConfig.CUT_SCENES_MapTextPositionX,
				Serialization.cutSceneConfig.CUT_SCENES_LabTextPositionY));

			break;

		case 4:
			canZoomCameraOut = false;
			break;
		}
	}

	void AddPanelToSequence(List<string> panel) {

		//panelSequence.Add (panel);
	}

	void SetupSequence(List<string>panels) {

	}

	void ChangePanels() {

		if (currentPanelNumber < maxPanels) {
			currentPanelNumber++;
			BuildCutScene ();
		}

	}

}
