using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour {

	private MechanicType mechanic;
	private string currentLevel;
	private bool levelComplete = false;

	private GameObject marbleManager;
	private MarbleManager mmComponent;
	private GameObject mainMenu;
	private Utils utils;

	private int numGates;
	private int numGoalPanelMultipliers;

	private int initialFreeMovesValue;
	private int initialMultiplierValue;
	private int initialGoalPanelMultiplier1Value;
	private int initialGoalPanelMultiplier2Value;
	private int initialManaValue;
	private float initialTimerValue;
	private int initialScoreValue;
	private int initialGoalPanelPointsValue;

	private GameObject timer;
	private GameObject timerText;
	private Text timerComponent;
	private float timerSeconds = 0;
	private float timerMiliseconds = 0;
	private int numIntervals;
	private bool timerComplete = false;

	private GameObject manaText;
	private Text manaTextComponent;

	private GameObject scoreText;
	private Text scoreTextComponent;

	private GameObject multiplier;
	private Text multiplierTextComponent;

	private GameObject freeMoves;
	private Text freeMovesTextComponent;

	private GameObject goalPanelPoints;
	private Text goalPanelPointsTextComponent;

	private GameObject goalPanelMultiplierText1;
	private Text goalPanelMultiplierTextComponent1;

	private GameObject goalPanelMultiplierText2;
	private Text goalPanelMultiplierTextComponent2;

	private GameObject enemy;
	private bool enemyMoving = false;
	private float enemyStartPosition = 1.5f;
	private float enemyEndPosition = -2.88f;
	private float enemyDistance;
	private float enemyIncrementValue;

	private GameObject mana;
	private float manaStartPosition;
	private float manaXPosition = -7.7f;
	private float manaTopPosition = -4.9f;
	private float manaBottomPosition = -6.2f;
	private float manaIncrementValue; 
	private bool manaEmpty = false;
	private float manaDistance;
	private int numManaIntervals = 10;

	private GameObject progressIndicator;
	private bool progressIndicatorMoving = false;
	private float progressIndicatorXPosition = 7.6f;
	private float progressIndicatorStartPosition = -2.8f;
	private float progressIndicatorEndPosition = 1.5f;
	private bool progressIndicatorAtDesitnation = false;
	private float progressIndicatorDistance;
	private float progressIndicatorIncrementValue;
	private int numProgressIndicatorIntervals = 10;

	void Start () {

		currentLevel = Serialization.boardConfig.GENERAL_CurrentLevel;
		SetMechanicType ();
	 
		InitializeBoardValues ();
		BuildBoard ();
		GetTextReferences ();
		GetGOReferences ();
		InitializeGameText ();
		InitializeManaPosition ();
		InitializeManaMovementValues ();
		InitializeProgressIndicatorPosition ();
		InitializeProgressIndicatorMovementValues ();
		DetermineNumTimeIntervals ();
		InvokeRepeating("MoveEnemy", 0.0f, 1.0f);
		InitializeEnemyMovementValues();
	}

	void Update () {

		if (!timerComplete && !levelComplete) {
			UpdateTimer ();
		}
	}
		
	void InitializeBoardValues() {

		initialFreeMovesValue = Serialization.boardConfig.GENERAL_FreeMovesValue;
		initialMultiplierValue = Serialization.boardConfig.GENERAL_MultiplierValue;
		initialGoalPanelMultiplier1Value = Serialization.boardConfig.GENERAL_GoalPanelMultiplier1Value;
		initialGoalPanelMultiplier2Value = Serialization.boardConfig.GENERAL_GoalPanelMultiplier2Value;

		initialManaValue = Serialization.boardConfig.GENERAL_ManaValue;
		initialTimerValue = Serialization.boardConfig.GENERAL_TimerValue;
		initialScoreValue = Serialization.boardConfig.GENERAL_ScoreValue;
		initialGoalPanelPointsValue = Serialization.boardConfig.GENERAL_GoalPanelPointsValue;

		numGates = Serialization.boardConfig.GENERAL_NumGates;
		numGoalPanelMultipliers = Serialization.boardConfig.GENERAL_NumGoalPanelMultipliers;
	
		mainMenu = GameObject.Find ("Main_Menu");
		marbleManager = GameObject.Find ("MarbleManager");

		utils = mainMenu.GetComponent<Utils>();
		mmComponent = marbleManager.GetComponent<MarbleManager> ();
	}

	void InitializeGameText() {

		SetFreeMovesValue (initialFreeMovesValue);
		SetMultiplierValue (initialMultiplierValue);
		SetGoalPanelMultiplier1Value (initialGoalPanelMultiplier1Value);
		SetGoalPanelMultiplier2Value (initialGoalPanelMultiplier2Value);
		SetManaValue (initialManaValue);
		SetScoreValue (initialScoreValue);
		SetInitialGoalPanelPointsValue (initialGoalPanelPointsValue);
	}

	void UpdateTimer() {
		 
		if(timerMiliseconds <= 0){

			if(timerSeconds <= 0){

				if (initialTimerValue == 0 && timerSeconds == 0) {
					timerComplete = true;
					mmComponent.DisplayLoseScenario ();
					levelComplete = true;
				} else {
					initialTimerValue--;
					timerSeconds = 59;
				}
			}
			else if(timerSeconds > 0 && !timerComplete){
				timerSeconds--;
			}

			if (!timerComplete) {
				timerMiliseconds = 100;
			}
		}

		if (initialTimerValue == 0 && timerSeconds == 0) {

			if (!GameObject.Find("MarbleExploder(Clone)")) {
				utils.InstantiateObject ("GENERAL/MarbleExploder", new Vector2 (0, 0), new Vector2 (1, 1));
			} else {
				GameObject.Find ("MarbleExploder(Clone)").transform.localScale += new Vector3 (0.04f, 0.04f, 0);
			}
		}

		timerMiliseconds -= Time.deltaTime * 100;

		timerComponent.text = string.Format("{0:00}:{1:00}", initialTimerValue, timerSeconds);
	}
		
	int DetermineNumTimeIntervals() {

		numIntervals = Convert.ToInt32(60 * (initialTimerValue));

		return numIntervals;
	}

	void InitializeEnemyMovementValues() {

		enemyDistance = enemyEndPosition - enemyStartPosition;
		enemyIncrementValue = enemyDistance / DetermineNumTimeIntervals();
	}
		
	void MoveEnemy() {
		
		if (enemy.transform.position.y > enemyEndPosition) {
			enemy.transform.position += new Vector3(0, enemyIncrementValue, 0);
		} 
	}

	void ResetEnemy() {

		enemy.transform.Translate (new Vector2 (0, enemyStartPosition));
	}

	void InitializeProgressIndicatorPosition() {
		progressIndicator.transform.position = new Vector2 (progressIndicatorXPosition,progressIndicatorStartPosition);
	}

	void InitializeProgressIndicatorMovementValues() {

		var pointsText = " points";
		var scoreText = goalPanelPointsTextComponent.text.Replace (pointsText, ""); 
		var curPoints = int.Parse (scoreText);

		progressIndicatorDistance = Math.Abs(progressIndicatorStartPosition - progressIndicatorEndPosition);
		progressIndicatorIncrementValue = progressIndicatorDistance / numProgressIndicatorIntervals;

	}

	public void MoveProgressIndicator() {

		if (progressIndicator.transform.position.y < progressIndicatorEndPosition) {
			progressIndicator.transform.Translate (new Vector2 (0, progressIndicatorIncrementValue));	
		}
	}

	void ResetProgressIndicator() {

		progressIndicator.transform.Translate (new Vector2 (0, progressIndicatorStartPosition));
	}
		
	void InitializeManaPosition() {
		mana.transform.position = new Vector2 (manaXPosition,manaBottomPosition);
	}

	void InitializeManaMovementValues() {

		manaDistance = Math.Abs(manaBottomPosition - manaTopPosition);
		manaIncrementValue = manaDistance / numManaIntervals;
	}

	public void MoveMana() {

		if (mana.transform.position.y < manaTopPosition) {
			mana.transform.Translate (new Vector2 (0, manaIncrementValue));	
		}
	}
		
	void BuildBoard() {

		BuildUI (currentLevel);
		BuildManaPanel (currentLevel);
		BuildGates (currentLevel);
		BuildMovableObjects (currentLevel);
		BuildGoalPanelMultipliers (currentLevel);
		BuildTextObjects (currentLevel);
		AssignLevelMarbles (currentLevel);
	}

	void AssignLevelMarbles(string level) {

		//TODO: VILE. Refactor this abomination.

		GameObject go = Instantiate (Resources.Load ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_MarbleType1)) as GameObject;
		mmComponent.MarblePrefabs [0] = go; 
		go.transform.position = new Vector2 (100, 100);

		go = Instantiate (Resources.Load ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_MarbleType2)) as GameObject;
		mmComponent.MarblePrefabs [1] = go; 
		go.transform.position = new Vector2 (100, 100);

		go = Instantiate (Resources.Load ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_MarbleType3)) as GameObject;
		mmComponent.MarblePrefabs [2] = go; 
		go.transform.position = new Vector2 (100, 100);

		go = Instantiate (Resources.Load ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_MarbleType4)) as GameObject;
		mmComponent.MarblePrefabs [3] = go; 
		go.transform.position = new Vector2 (100, 100);

		go = Instantiate (Resources.Load ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_MarbleType5)) as GameObject;
		mmComponent.MarblePrefabs [4] = go; 
		go.transform.position = new Vector2 (100, 100);
	}

	void BuildTextObjects(string level) {

		utils.InstantiateObject ("GENERAL/" + "GENERAL_Timer", new Vector2 (Serialization.boardConfig.GENERAL_TimerPositionX,
			Serialization.boardConfig.GENERAL_TimerPositionY),  new Vector2 (Serialization.boardConfig.GENERAL_TimerScaleX,
				Serialization.boardConfig.GENERAL_TimerScaleY));


		utils.InstantiateObject ("GENERAL/" + "GENERAL_Score", new Vector2 (Serialization.boardConfig.GENERAL_ScorePositionX,
			Serialization.boardConfig.GENERAL_ScorePositionY),  new Vector2 (Serialization.boardConfig.GENERAL_ScoreScaleX,
				Serialization.boardConfig.GENERAL_ScoreScaleY));

		utils.InstantiateObject ("GENERAL/" + "GENERAL_Multiplier", new Vector2 (Serialization.boardConfig.GENERAL_MultiplierTextPositionX,
			Serialization.boardConfig.GENERAL_MultiplierTextPositionY), new Vector2 (Serialization.boardConfig.GENERAL_MultiplierTextScaleX,
				Serialization.boardConfig.GENERAL_MultiplierTextScaleY));

		utils.InstantiateObject ("GENERAL/" + "GENERAL_FreeMoves", new Vector2 (Serialization.boardConfig.GENERAL_FreeMovesPositionX,
			Serialization.boardConfig.GENERAL_FreeMovesPositionY), new Vector2 (Serialization.boardConfig.GENERAL_FreeMovesScaleX,
				Serialization.boardConfig.GENERAL_FreeMovesScaleY));
	}

	void BuildUI(string level) {

		utils.InstantiateObject (level + "/" + level + "_BG", new Vector2 (Serialization.boardConfig.GetBoardPositionX(level),
			Serialization.boardConfig.GetBoardPositionY(level)), new Vector2 (Serialization.boardConfig.GetBoardScaleX(level), 
				Serialization.boardConfig.GetBoardScaleY(level)));

		utils.InstantiateObject (level + "/" + level + "_LeftUI", new Vector2 (Serialization.boardConfig.GetLeftUIPositionX(level),
			Serialization.boardConfig.GetLeftUIPositionY(level)), new Vector2 (Serialization.boardConfig.GetLeftUIScaleX(level), 
				Serialization.boardConfig.GetLeftUIScaleY(level)));

		utils.InstantiateObject (level + "/" + level + "_RightUI", new Vector2 (Serialization.boardConfig.GetRightUIPositionX(level),
			Serialization.boardConfig.GetRightUIPositionY(level)), new Vector2 (Serialization.boardConfig.GetRightUIScaleX(level), 
				Serialization.boardConfig.GetRightUIScaleY(level)));


		utils.InstantiateObject (level + "/" + level + "_TopUI", new Vector2 (Serialization.boardConfig.GetTopUI1PositionX(level),
			Serialization.boardConfig.GetTopUI1PositionY(level)), new Vector2 (Serialization.boardConfig.GetTopUI1ScaleX(level),
				Serialization.boardConfig.GetTopUI1ScaleY(level)));

		utils.InstantiateObject (level + "/" + level + "_TopUI", new Vector2 (Serialization.boardConfig.GetTopUI2PositionX(level),
			Serialization.boardConfig.GetTopUI2PositionY(level)), new Vector2 (Serialization.boardConfig.GetTopUI2ScaleX(level),
				Serialization.boardConfig.GetTopUI2ScaleY(level)));

		utils.InstantiateObject (level + "/" + level + "_TopUI", new Vector2 (Serialization.boardConfig.GetTopUI3PositionX(level),
			Serialization.boardConfig.GetTopUI3PositionY(level)), new Vector2 (Serialization.boardConfig.GetTopUI3ScaleX(level),
				Serialization.boardConfig.GetTopUI3ScaleY(level)));

		utils.InstantiateObject (level + "/" + level + "_BottomUI", new Vector2 (Serialization.boardConfig.GetBottomUI1PositionX(level),
			Serialization.boardConfig.GetBottomUI1PositionY(level)), new Vector2 (Serialization.boardConfig.GetBottomUI1ScaleX(level),
				Serialization.boardConfig.GetBottomUI1ScaleY(level)));

		utils.InstantiateObject (level + "/" + level + "_BottomUI", new Vector2 (Serialization.boardConfig.GetBottomUI2PositionX(level),
			Serialization.boardConfig.GetBottomUI2PositionY(level)), new Vector2 (Serialization.boardConfig.GetBottomUI2ScaleX(level),
				Serialization.boardConfig.GetBottomUI2ScaleY(level)));

		utils.InstantiateObject (level + "/" + level + "_BottomUI", new Vector2 (Serialization.boardConfig.GetBottomUI3PositionX(level),
			Serialization.boardConfig.GetBottomUI3PositionY(level)), new Vector2 (Serialization.boardConfig.GetBottomUI3ScaleX(level),
				Serialization.boardConfig.GetBottomUI3ScaleY(level)));

	}

	void BuildGates(string level) {

		switch (numGates) {

		case 1:
			utils.InstantiateObject (level + "/" + level + "_Gate", new Vector2 (Serialization.boardConfig.GetGate3PositionX(level),
				Serialization.boardConfig.GetGate3PositionY(level)), new Vector2 (Serialization.boardConfig.GetGate3ScaleX(level),
					Serialization.boardConfig.GetGate3ScaleY(level)));
			break;
		case 2:
			utils.InstantiateObject (level + "/" + level + "_Gate", new Vector2 (Serialization.boardConfig.GetGate2PositionX(level),
				Serialization.boardConfig.GetGate2PositionY(level)), new Vector2 (Serialization.boardConfig.GetGate2ScaleX(level),
					Serialization.boardConfig.GetGate2ScaleY(level)));
			utils.InstantiateObject (level + "/" + level + "_Gate", new Vector2 (Serialization.boardConfig.GetGate3PositionX(level),
				Serialization.boardConfig.GetGate3PositionY(level)), new Vector2 (Serialization.boardConfig.GetGate3ScaleX(level),
					Serialization.boardConfig.GetGate3ScaleY(level)));
			break;
		case 3:
			utils.InstantiateObject (level + "/" + level + "_Gate", new Vector2 (Serialization.boardConfig.GetGate1PositionX(level),
				Serialization.boardConfig.GetGate1PositionY(level)), new Vector2 (Serialization.boardConfig.GetGate1ScaleX(level),
					Serialization.boardConfig.GetGate1ScaleY(level)));
			utils.InstantiateObject (level + "/" + level + "_Gate", new Vector2 (Serialization.boardConfig.GetGate2PositionX(level),
				Serialization.boardConfig.GetGate2PositionY(level)), new Vector2 (Serialization.boardConfig.GetGate2ScaleX(level),
					Serialization.boardConfig.GetGate2ScaleY(level)));
			utils.InstantiateObject (level + "/" + level + "_Gate", new Vector2 (Serialization.boardConfig.GetGate3PositionX(level),
				Serialization.boardConfig.GetGate3PositionY(level)), new Vector2 (Serialization.boardConfig.GetGate3ScaleX(level),
					Serialization.boardConfig.GetGate3ScaleY(level)));
			break;
		}
	}

	void BuildMovableObjects(string level) {

		utils.InstantiateObject (level + "/" + level + "_Enemy", new Vector2 (Serialization.boardConfig.GetEnemyPositionX(level),
			Serialization.boardConfig.GetEnemyPositionY(level)), new Vector2 (Serialization.boardConfig.GetEnemyScaleX(level),
				Serialization.boardConfig.GetEnemyScaleY(level)));

		utils.InstantiateObject (level + "/" + level + "_ProgressIndicator", new Vector2 (Serialization.boardConfig.GetProgressIndicatorPositionX(level),
			Serialization.boardConfig.GetProgressIndicatorPositionY(level)), new Vector2 (Serialization.boardConfig.GetProgressIndicatorScaleX(level),
				Serialization.boardConfig.GetProgressIndicatorScaleY(level)));
	}

	void BuildGoalPanelMultipliers(string level) {

		utils.InstantiateObject ("GENERAL/" + "GENERAL_GoalPanelPoints", new Vector2 (Serialization.boardConfig.GENERAL_GoalPanelPointsPositionX,
			Serialization.boardConfig.GENERAL_GoalPanelPointsPositionY), new Vector2 (Serialization.boardConfig.GENERAL_GoalPanelPointsScaleX,
				Serialization.boardConfig.GENERAL_GoalPanelPointsScaleY));

		switch (numGoalPanelMultipliers) {

		case 1:

			utils.InstantiateObject ("GENERAL/" + "GENERAL_GoalPanelMultiplier", new Vector2 (Serialization.boardConfig.GENERAL_GoalPanelMultiplierPositionX,
				Serialization.boardConfig.GENERAL_GoalPanelMultiplierPositionY), new Vector2 (Serialization.boardConfig.GENERAL_GoalPanelMultiplierScaleX,
					Serialization.boardConfig.GENERAL_GoalPanelMultiplierScaleY));

			utils.InstantiateObject ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_GoalPanelMarbleType1, new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1LeftPositionX,
				Serialization.boardConfig.MARBLE_GoalPanelMarbleType1LeftPositionY), new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1LeftScaleX,
					Serialization.boardConfig.MARBLE_GoalPanelMarbleType1LeftScaleY));

			utils.InstantiateObject ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_GoalPanelMarbleType1, new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1MiddlePositionX,
				Serialization.boardConfig.MARBLE_GoalPanelMarbleType1MiddlePositionY), new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1MiddleScaleX,
					Serialization.boardConfig.MARBLE_GoalPanelMarbleType1MiddleScaleY));

			utils.InstantiateObject ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_GoalPanelMarbleType1, new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1RightPositionX,
				Serialization.boardConfig.MARBLE_GoalPanelMarbleType1RightPositionY), new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1RightScaleX,
					Serialization.boardConfig.MARBLE_GoalPanelMarbleType1RightScaleY));
			break;
		case 2:
			

			utils.InstantiateObject ("GENERAL/" + "GENERAL_GoalPanelMultiplier", new Vector2 (Serialization.boardConfig.GENERAL_GoalPanelMultiplierPositionX,
				Serialization.boardConfig.GENERAL_GoalPanelMultiplierPositionY), new Vector2 (Serialization.boardConfig.GENERAL_GoalPanelMultiplierScaleX,
					Serialization.boardConfig.GENERAL_GoalPanelMultiplierScaleY));

			utils.InstantiateObject ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_GoalPanelMarbleType1, new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1LeftPositionX,
				Serialization.boardConfig.MARBLE_GoalPanelMarbleType1LeftPositionY), new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1LeftScaleX,
					Serialization.boardConfig.MARBLE_GoalPanelMarbleType1LeftScaleY));

			utils.InstantiateObject ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_GoalPanelMarbleType1, new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1MiddlePositionX,
				Serialization.boardConfig.MARBLE_GoalPanelMarbleType1MiddlePositionY), new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1MiddleScaleX,
					Serialization.boardConfig.MARBLE_GoalPanelMarbleType1MiddleScaleY));

			utils.InstantiateObject ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_GoalPanelMarbleType1, new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1RightPositionX,
				Serialization.boardConfig.MARBLE_GoalPanelMarbleType1RightPositionY), new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType1RightScaleX,
					Serialization.boardConfig.MARBLE_GoalPanelMarbleType1RightScaleY));

			utils.InstantiateObject ("GENERAL/" + "GENERAL_GoalPanelMultiplier2", new Vector2 (Serialization.boardConfig.GENERAL_GoalPanelMultiplier2PositionX,
				Serialization.boardConfig.GENERAL_GoalPanelMultiplier2PositionY), new Vector2 (Serialization.boardConfig.GENERAL_GoalPanelMultiplier2ScaleX,
					Serialization.boardConfig.GENERAL_GoalPanelMultiplier2ScaleY));

			utils.InstantiateObject ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_GoalPanelMarbleType1, new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType2LeftPositionX,
				Serialization.boardConfig.MARBLE_GoalPanelMarbleType2LeftPositionY), new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType2LeftScaleX,
					Serialization.boardConfig.MARBLE_GoalPanelMarbleType2LeftScaleY));

			utils.InstantiateObject ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_GoalPanelMarbleType1, new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType2MiddlePositionX,
				Serialization.boardConfig.MARBLE_GoalPanelMarbleType2MiddlePositionY), new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType2MiddleScaleX,
					Serialization.boardConfig.MARBLE_GoalPanelMarbleType2MiddleScaleY));

			utils.InstantiateObject ("MARBLE/" + "MARBLE" + Serialization.boardConfig.MARBLE_GoalPanelMarbleType1, new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType2RightPositionX,
				Serialization.boardConfig.MARBLE_GoalPanelMarbleType2RightPositionY), new Vector2 (Serialization.boardConfig.MARBLE_GoalPanelMarbleType2RightScaleX,
					Serialization.boardConfig.MARBLE_GoalPanelMarbleType2RightScaleY));
			break;
		}
	}

	void BuildManaPanel(string level) {

		utils.InstantiateObject ("GENERAL/" + "GENERAL_Mana", new Vector2 (Serialization.boardConfig.GENERAL_ManaPositionX,
			Serialization.boardConfig.GENERAL_ManaPositionY), new Vector2 (Serialization.boardConfig.GENERAL_ManaScaleX,
				Serialization.boardConfig.GENERAL_ManaScaleY));

		utils.InstantiateObject (level + "/" + level + "_ManaOverlay", new Vector2 (Serialization.boardConfig.GetManaOverlayPositionX(level),
			Serialization.boardConfig.GetManaOverlayPositionY(level)), new Vector2 (Serialization.boardConfig.GetManaOverlayScaleX(level),
				Serialization.boardConfig.GetManaOverlayScaleY(level)));

		utils.InstantiateObject ("GENERAL/" + "GENERAL_ManaText", new Vector2 (Serialization.boardConfig.GENERAL_ManaTextPositionX,
			Serialization.boardConfig.GENERAL_ManaTextPositionY),  new Vector2 (Serialization.boardConfig.GENERAL_ManaTextScaleX,
				Serialization.boardConfig.GENERAL_ManaTextScaleY));

		utils.InstantiateObject ("GENERAL/" + "GENERAL_AirSphere", new Vector2 (Serialization.boardConfig.GENERAL_AirSpherePositionX,
			Serialization.boardConfig.GENERAL_AirSpherePositionY), new Vector2 (Serialization.boardConfig.GENERAL_AirSphereScaleX,
				Serialization.boardConfig.GENERAL_AirSphereScaleY));

		utils.InstantiateObject ("GENERAL/" + "GENERAL_EarthSphere", new Vector2 (Serialization.boardConfig.GENERAL_EarthSpherePositionX,
			Serialization.boardConfig.GENERAL_EarthSpherePositionY), new Vector2 (Serialization.boardConfig.GENERAL_EarthSphereScaleX,
				Serialization.boardConfig.GENERAL_EarthSphereScaleY));

		utils.InstantiateObject ("GENERAL/" + "GENERAL_FireSphere", new Vector2 (Serialization.boardConfig.GENERAL_FireSpherePositionX,
			Serialization.boardConfig.GENERAL_FireSpherePositionY), new Vector2 (Serialization.boardConfig.GENERAL_FireSphereScaleX,
				Serialization.boardConfig.GENERAL_FireSphereScaleY));

		utils.InstantiateObject ("GENERAL/" + "GENERAL_WaterSphere", new Vector2 (Serialization.boardConfig.GENERAL_WaterSpherePositionX,
			Serialization.boardConfig.GENERAL_WaterSpherePositionY), new Vector2 (Serialization.boardConfig.GENERAL_WaterSphereScaleX,
				Serialization.boardConfig.GENERAL_WaterSphereScaleY));

	}

	void GetTextReferences() {

		timer = GameObject.Find ("GENERAL_Timer(Clone)");
		timerText = GameObject.Find("TimerText");
		timerComponent = timerText.GetComponent<Text> ();

		manaText = GameObject.Find ("ManaText");
		manaTextComponent = manaText.GetComponent<Text> ();

		scoreText = GameObject.Find ("ScoreText");
		scoreTextComponent = scoreText.GetComponent<Text> ();

		multiplier = GameObject.Find ("MultiplierText");
		multiplierTextComponent = multiplier.GetComponent<Text> ();

		freeMoves = GameObject.Find ("FreeMovesText");
		freeMovesTextComponent = freeMoves.GetComponent<Text> ();

		goalPanelPoints = GameObject.Find ("GoalPanelPointsText");
		goalPanelPointsTextComponent = goalPanelPoints.GetComponent<Text> ();

		goalPanelMultiplierText1 = GameObject.Find ("GoalPanelMultiplierText1");
		goalPanelMultiplierTextComponent1 = goalPanelMultiplierText1.GetComponent<Text> ();
		goalPanelMultiplierText2 = GameObject.Find ("GoalPanelMultiplierText2");
		goalPanelMultiplierTextComponent2 = goalPanelMultiplierText2.GetComponent<Text> ();
	}

	void GetGOReferences() {

		string level = currentLevel.ToString();

		enemy = GameObject.Find (level + "_Enemy(Clone)");
		mana = GameObject.Find ("GENERAL_Mana(Clone)");
		progressIndicator = GameObject.Find (level + "_ProgressIndicator(Clone)");
	}
				
	void SetManaValue(int val) {
		manaTextComponent.text = val.ToString();
	}

	public void DecrementMana(int increment) {


	}

	void SetFreeMovesValue(int value) {
		freeMovesTextComponent.text =  value.ToString();
	}

	void SetScoreValue(int value) {
		scoreTextComponent.text = value.ToString ();
	}

	void SetMultiplierValue(int value) {
		multiplierTextComponent.text = "X" + value.ToString ();
	}

	void SetGoalPanelMultiplier1Value(int value) {
		goalPanelMultiplierTextComponent1.text = "X" + value.ToString ();
	}

	void SetGoalPanelMultiplier2Value(int value) {
		goalPanelMultiplierTextComponent2.text = "X" + value.ToString ();
	}
		
	void SetInitialGoalPanelPointsValue(int value) {
		goalPanelPointsTextComponent.text = value.ToString () + " points";
	}


	public void DecrementGoalPanelPoints(int value) {

		var pointsText = " points";
		var scoreText = goalPanelPointsTextComponent.text.Replace (pointsText, ""); 
		var curPoints = int.Parse (scoreText);
		curPoints -= value;
		goalPanelPointsTextComponent.text = curPoints.ToString () + " points";
	}
		
	public void IncrementScore(int value) {

		var curScore = int.Parse (scoreTextComponent.text);
		curScore += value;
		scoreTextComponent.text = curScore.ToString ();
	}

	public void CheckForWin() {

		var pointsText = " points";
		var scoreText = goalPanelPointsTextComponent.text.Replace (pointsText, ""); 
		var curPoints = int.Parse (scoreText);

		if (curPoints <= 0) {
			mmComponent.DisplayWinScenario ();
			levelComplete = true;
		}

	}

	void StartEnemyMovement() {
		
		enemyMoving = true;
	}

	void StopEnemyMovement() {
		
		enemyMoving = false;
	}

	void StartMusic() {

	}

	void StopMusic() {

	}

	void ShowTutorial() {

	}
		
	void SetMechanicType(MechanicType mt = MechanicType.Match3) {
		mechanic = mt;
	}
}
