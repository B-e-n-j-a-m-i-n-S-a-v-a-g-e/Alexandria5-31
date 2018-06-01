using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class BoardConfig {

	public string GetCurrentLevel() {
		return GENERAL_CurrentLevel;
	}
		
				
	public int GENERAL_FreeMovesValue;
	public int GENERAL_MultiplierValue;
	public int GENERAL_GoalPanelMultiplier1Value;
	public int GENERAL_GoalPanelMultiplier2Value;
	public int GENERAL_ManaValue;
	public int GENERAL_TimerValue;
	public int GENERAL_ScoreValue;
	public int GENERAL_MatchValue;
	public int GENERAL_GoalPanelPointsValue;

	public string GENERAL_CurrentLevel;
	public string GENERAL_MechanicType;

	public int GENERAL_NumGates;
	public int GENERAL_NumGoalPanelMultipliers;

	public float GENERAL_TimerPositionX;
	public float GENERAL_TimerPositionY;
	public float GENERAL_TimerScaleX;
	public float GENERAL_TimerScaleY;
	public float GENERAL_TimerInitialValue;

	public float GENERAL_MultiplierTextPositionX;
	public float GENERAL_MultiplierTextPositionY;
	public float GENERAL_MultiplierTextScaleX;
	public float GENERAL_MultiplierTextScaleY;

	public float GENERAL_ManaPositionX;
	public float GENERAL_ManaPositionY;
	public float GENERAL_ManaScaleX;
	public float GENERAL_ManaScaleY;

	public float GENERAL_ManaTextPositionX;
	public float GENERAL_ManaTextPositionY;
	public float GENERAL_ManaTextScaleX;
	public float GENERAL_ManaTextScaleY;

	public float GENERAL_FreeMovesPositionX;
	public float GENERAL_FreeMovesPositionY;
	public float GENERAL_FreeMovesScaleX;
	public float GENERAL_FreeMovesScaleY;

	public float GENERAL_ScorePositionX;
	public float GENERAL_ScorePositionY;
	public float GENERAL_ScoreScaleX;
	public float GENERAL_ScoreScaleY;

	public float GENERAL_GoalPanelPointsPositionX;
	public float GENERAL_GoalPanelPointsPositionY;
	public float GENERAL_GoalPanelPointsScaleX;
	public float GENERAL_GoalPanelPointsScaleY;

	public float GENERAL_GoalPanelMultiplierPositionX;
	public float GENERAL_GoalPanelMultiplierPositionY;
	public float GENERAL_GoalPanelMultiplierScaleX;
	public float GENERAL_GoalPanelMultiplierScaleY;

	public float GENERAL_GoalPanelMultiplier2PositionX;
	public float GENERAL_GoalPanelMultiplier2PositionY;
	public float GENERAL_GoalPanelMultiplier2ScaleX;
	public float GENERAL_GoalPanelMultiplier2ScaleY;

	public float GENERAL_MarbleSetPlacementX;
	public float GENERAL_MarbleSetPlacementY;

	public float GENERAL_MarbleDistX;
	public float GENERAL_MarbleDistY;

	public float GENERAL_MarbleScaleX;
	public float GENERAL_MarbleScaleY;

	public int GENERAL_NumRows;
	public int GENERAL_NumColumns;

	public float GENERAL_AirSpherePositionX;
	public float GENERAL_AirSpherePositionY;
	public float GENERAL_AirSphereScaleX;
	public float GENERAL_AirSphereScaleY;

	public float GENERAL_EarthSpherePositionX;
	public float GENERAL_EarthSpherePositionY;
	public float GENERAL_EarthSphereScaleX;
	public float GENERAL_EarthSphereScaleY;

	public float GENERAL_FireSpherePositionX;
	public float GENERAL_FireSpherePositionY;
	public float GENERAL_FireSphereScaleX;
	public float GENERAL_FireSphereScaleY;

	public float GENERAL_WaterSpherePositionX;
	public float GENERAL_WaterSpherePositionY;
	public float GENERAL_WaterSphereScaleX;
	public float GENERAL_WaterSphereScaleY;

	public string MARBLE_MarbleType1;
	public string MARBLE_MarbleType2;
	public string MARBLE_MarbleType3;
	public string MARBLE_MarbleType4;
	public string MARBLE_MarbleType5;

	public float MARBLE_GoalPanelMarbleType1LeftPositionX;
	public float MARBLE_GoalPanelMarbleType1LeftPositionY;
	public float MARBLE_GoalPanelMarbleType1LeftScaleX;
	public float MARBLE_GoalPanelMarbleType1LeftScaleY;

	public float MARBLE_GoalPanelMarbleType1MiddlePositionX;
	public float MARBLE_GoalPanelMarbleType1MiddlePositionY;
	public float MARBLE_GoalPanelMarbleType1MiddleScaleX;
	public float MARBLE_GoalPanelMarbleType1MiddleScaleY;

	public float MARBLE_GoalPanelMarbleType1RightPositionX;
	public float MARBLE_GoalPanelMarbleType1RightPositionY;
	public float MARBLE_GoalPanelMarbleType1RightScaleX;
	public float MARBLE_GoalPanelMarbleType1RightScaleY;

	public float MARBLE_GoalPanelMarbleType2LeftPositionX;
	public float MARBLE_GoalPanelMarbleType2LeftPositionY;
	public float MARBLE_GoalPanelMarbleType2LeftScaleX;
	public float MARBLE_GoalPanelMarbleType2LeftScaleY;

	public float MARBLE_GoalPanelMarbleType2MiddlePositionX;
	public float MARBLE_GoalPanelMarbleType2MiddlePositionY;
	public float MARBLE_GoalPanelMarbleType2MiddleScaleX;
	public float MARBLE_GoalPanelMarbleType2MiddleScaleY;

	public float MARBLE_GoalPanelMarbleType2RightPositionX;
	public float MARBLE_GoalPanelMarbleType2RightPositionY;
	public float MARBLE_GoalPanelMarbleType2RightScaleX;
	public float MARBLE_GoalPanelMarbleType2RightScaleY;

	public string MARBLE_GoalPanelMarbleType1;
	public string MARBLE_GoalPanelMarbleType2;

	public float ASIA_ManaOverlayPositionX;
	public float ASIA_ManaOverlayPositionY;
	public float ASIA_ManaOverlayScaleX;
	public float ASIA_ManaOverlayScaleY;

	public float ASIA_BoardPositionX;
	public float ASIA_BoardPositionY;
	public float ASIA_BoardScaleX;
	public float ASIA_BoardScaleY;

	public float ASIA_LeftUIPositionX;
	public float ASIA_LeftUIPositionY;
	public float ASIA_LeftUIScaleX;
	public float ASIA_LeftUIScaleY;

	public float ASIA_RightUIPositionX;
	public float ASIA_RightUIPositionY;
	public float ASIA_RightUIScaleX;
	public float ASIA_RightUIScaleY;

	public float ASIA_TopUI1PositionX;
	public float ASIA_TopUI1PositionY;
	public float ASIA_TopUI1ScaleX;
	public float ASIA_TopUI1ScaleY;

	public float ASIA_TopUI2PositionX;
	public float ASIA_TopUI2PositionY;
	public float ASIA_TopUI2ScaleX;
	public float ASIA_TopUI2ScaleY;

	public float ASIA_TopUI3PositionX;
	public float ASIA_TopUI3PositionY;
	public float ASIA_TopUI3ScaleX;
	public float ASIA_TopUI3ScaleY;

	public float ASIA_BottomUI1PositionX;
	public float ASIA_BottomUI1PositionY;
	public float ASIA_BottomUI1ScaleX;
	public float ASIA_BottomUI1ScaleY;

	public float ASIA_BottomUI2PositionX;
	public float ASIA_BottomUI2PositionY;
	public float ASIA_BottomUI2ScaleX;
	public float ASIA_BottomUI2ScaleY;

	public float ASIA_BottomUI3PositionX;
	public float ASIA_BottomUI3PositionY;
	public float ASIA_BottomUI3ScaleX;
	public float ASIA_BottomUI3ScaleY;

	public float ASIA_EnemyPositionX;
	public float ASIA_EnemyPositionY;
	public float ASIA_EnemyScaleX;
	public float ASIA_EnemyScaleY;

	public float ASIA_ProgressIndicatorPositionX;
	public float ASIA_ProgressIndicatorPositionY;
	public float ASIA_ProgressIndicatorScaleX;
	public float ASIA_ProgressIndicatorScaleY;

	public float ASIA_Gate1PositionX;
	public float ASIA_Gate1PositionY;
	public float ASIA_Gate1ScaleX;
	public float ASIA_Gate1ScaleY;

	public float ASIA_Gate2PositionX;
	public float ASIA_Gate2PositionY;
	public float ASIA_Gate2ScaleX;
	public float ASIA_Gate2ScaleY;

	public float ASIA_Gate3PositionX;
	public float ASIA_Gate3PositionY;
	public float ASIA_Gate3ScaleX;
	public float ASIA_Gate3ScaleY;

	public float ASIA_GoalPanelMarbleDragon1PositionX;
	public float ASIA_GoalPanelMarbleDragon1PositionY;
	public float ASIA_GoalPanelMarbleDragon1ScaleX;
	public float ASIA_GoalPanelMarbleDragon1ScaleY;

	public float ASIA_GoalPanelMarbleDragon2PositionX;
	public float ASIA_GoalPanelMarbleDragon2PositionY;
	public float ASIA_GoalPanelMarbleDragon2ScaleX;
	public float ASIA_GoalPanelMarbleDragon2ScaleY;

	public float ASIA_GoalPanelMarbleDragon3PositionX;
	public float ASIA_GoalPanelMarbleDragon3PositionY;
	public float ASIA_GoalPanelMarbleDragon3ScaleX;
	public float ASIA_GoalPanelMarbleDragon3ScaleY;

	public float ASIA_GoalPanelMarbleFan1PositionX;
	public float ASIA_GoalPanelMarbleFan1PositionY;
	public float ASIA_GoalPanelMarbleFan1ScaleX;
	public float ASIA_GoalPanelMarbleFan1ScaleY;

	public float ASIA_GoalPanelMarbleFan2PositionX;
	public float ASIA_GoalPanelMarbleFan2PositionY;
	public float ASIA_GoalPanelMarbleFan2ScaleX;
	public float ASIA_GoalPanelMarbleFan2ScaleY;

	public float ASIA_GoalPanelMarbleFan3PositionX;
	public float ASIA_GoalPanelMarbleFan3PositionY;
	public float ASIA_GoalPanelMarbleFan3ScaleX;
	public float ASIA_GoalPanelMarbleFan3ScaleY;



	public string EGYPT_GoalPanelMarbleType1;
	public string EGYPT_GoalPanelMarbleType2;

	public float EGYPT_ManaOverlayPositionX;
	public float EGYPT_ManaOverlayPositionY;
	public float EGYPT_ManaOverlayScaleX;
	public float EGYPT_ManaOverlayScaleY;

	public float EGYPT_BoardPositionX;
	public float EGYPT_BoardPositionY;
	public float EGYPT_BoardScaleX;
	public float EGYPT_BoardScaleY;

	public float EGYPT_LeftUIPositionX;
	public float EGYPT_LeftUIPositionY;
	public float EGYPT_LeftUIScaleX;
	public float EGYPT_LeftUIScaleY;

	public float EGYPT_RightUIPositionX;
	public float EGYPT_RightUIPositionY;
	public float EGYPT_RightUIScaleX;
	public float EGYPT_RightUIScaleY;

	public float EGYPT_TopUI1PositionX;
	public float EGYPT_TopUI1PositionY;
	public float EGYPT_TopUI1ScaleX;
	public float EGYPT_TopUI1ScaleY;

	public float EGYPT_TopUI2PositionX;
	public float EGYPT_TopUI2PositionY;
	public float EGYPT_TopUI2ScaleX;
	public float EGYPT_TopUI2ScaleY;

	public float EGYPT_TopUI3PositionX;
	public float EGYPT_TopUI3PositionY;
	public float EGYPT_TopUI3ScaleX;
	public float EGYPT_TopUI3ScaleY;

	public float EGYPT_BottomUI1PositionX;
	public float EGYPT_BottomUI1PositionY;
	public float EGYPT_BottomUI1ScaleX;
	public float EGYPT_BottomUI1ScaleY;

	public float EGYPT_BottomUI2PositionX;
	public float EGYPT_BottomUI2PositionY;
	public float EGYPT_BottomUI2ScaleX;
	public float EGYPT_BottomUI2ScaleY;

	public float EGYPT_BottomUI3PositionX;
	public float EGYPT_BottomUI3PositionY;
	public float EGYPT_BottomUI3ScaleX;
	public float EGYPT_BottomUI3ScaleY;

	public float EGYPT_EnemyPositionX;
	public float EGYPT_EnemyPositionY;
	public float EGYPT_EnemyScaleX;
	public float EGYPT_EnemyScaleY;

	public float EGYPT_ProgressIndicatorPositionX;
	public float EGYPT_ProgressIndicatorPositionY;
	public float EGYPT_ProgressIndicatorScaleX;
	public float EGYPT_ProgressIndicatorScaleY;

	public float EGYPT_Gate1PositionX;
	public float EGYPT_Gate1PositionY;
	public float EGYPT_Gate1ScaleX;
	public float EGYPT_Gate1ScaleY;

	public float EGYPT_Gate2PositionX;
	public float EGYPT_Gate2PositionY;
	public float EGYPT_Gate2ScaleX;
	public float EGYPT_Gate2ScaleY;

	public float EGYPT_Gate3PositionX;
	public float EGYPT_Gate3PositionY;
	public float EGYPT_Gate3ScaleX;
	public float EGYPT_Gate3ScaleY;


	public string GRECO_GoalPanelMarbleType1;
	public string GRECO_GoalPanelMarbleType2;

	public float GRECO_ManaOverlayPositionX;
	public float GRECO_ManaOverlayPositionY;
	public float GRECO_ManaOverlayScaleX;
	public float GRECO_ManaOverlayScaleY;

	public float GRECO_BoardPositionX;
	public float GRECO_BoardPositionY;
	public float GRECO_BoardScaleX;
	public float GRECO_BoardScaleY;

	public float GRECO_LeftUIPositionX;
	public float GRECO_LeftUIPositionY;
	public float GRECO_LeftUIScaleX;
	public float GRECO_LeftUIScaleY;

	public float GRECO_RightUIPositionX;
	public float GRECO_RightUIPositionY;
	public float GRECO_RightUIScaleX;
	public float GRECO_RightUIScaleY;

	public float GRECO_TopUI1PositionX;
	public float GRECO_TopUI1PositionY;
	public float GRECO_TopUI1ScaleX;
	public float GRECO_TopUI1ScaleY;

	public float GRECO_TopUI2PositionX;
	public float GRECO_TopUI2PositionY;
	public float GRECO_TopUI2ScaleX;
	public float GRECO_TopUI2ScaleY;

	public float GRECO_TopUI3PositionX;
	public float GRECO_TopUI3PositionY;
	public float GRECO_TopUI3ScaleX;
	public float GRECO_TopUI3ScaleY;

	public float GRECO_BottomUI1PositionX;
	public float GRECO_BottomUI1PositionY;
	public float GRECO_BottomUI1ScaleX;
	public float GRECO_BottomUI1ScaleY;

	public float GRECO_BottomUI2PositionX;
	public float GRECO_BottomUI2PositionY;
	public float GRECO_BottomUI2ScaleX;
	public float GRECO_BottomUI2ScaleY;

	public float GRECO_BottomUI3PositionX;
	public float GRECO_BottomUI3PositionY;
	public float GRECO_BottomUI3ScaleX;
	public float GRECO_BottomUI3ScaleY;

	public float GRECO_EnemyPositionX;
	public float GRECO_EnemyPositionY;
	public float GRECO_EnemyScaleX;
	public float GRECO_EnemyScaleY;

	public float GRECO_ProgressIndicatorPositionX;
	public float GRECO_ProgressIndicatorPositionY;
	public float GRECO_ProgressIndicatorScaleX;
	public float GRECO_ProgressIndicatorScaleY;

	public float GRECO_Gate1PositionX;
	public float GRECO_Gate1PositionY;
	public float GRECO_Gate1ScaleX;
	public float GRECO_Gate1ScaleY;

	public float GRECO_Gate2PositionX;
	public float GRECO_Gate2PositionY;
	public float GRECO_Gate2ScaleX;
	public float GRECO_Gate2ScaleY;

	public float GRECO_Gate3PositionX;
	public float GRECO_Gate3PositionY;
	public float GRECO_Gate3ScaleX;
	public float GRECO_Gate3ScaleY;

	public float GRECO_GoalPanelMarbleDragon1PositionX;
	public float GRECO_GoalPanelMarbleDragon1PositionY;
	public float GRECO_GoalPanelMarbleDragon1ScaleX;
	public float GRECO_GoalPanelMarbleDragon1ScaleY;

	public float GRECO_GoalPanelMarbleDragon2PositionX;
	public float GRECO_GoalPanelMarbleDragon2PositionY;
	public float GRECO_GoalPanelMarbleDragon2ScaleX;
	public float GRECO_GoalPanelMarbleDragon2ScaleY;

	public float GRECO_GoalPanelMarbleDragon3PositionX;
	public float GRECO_GoalPanelMarbleDragon3PositionY;
	public float GRECO_GoalPanelMarbleDragon3ScaleX;
	public float GRECO_GoalPanelMarbleDragon3ScaleY;

	public float GRECO_GoalPanelMarbleFan1PositionX;
	public float GRECO_GoalPanelMarbleFan1PositionY;
	public float GRECO_GoalPanelMarbleFan1ScaleX;
	public float GRECO_GoalPanelMarbleFan1ScaleY;

	public float GRECO_GoalPanelMarbleFan2PositionX;
	public float GRECO_GoalPanelMarbleFan2PositionY;
	public float GRECO_GoalPanelMarbleFan2ScaleX;
	public float GRECO_GoalPanelMarbleFan2ScaleY;

	public float GRECO_GoalPanelMarbleFan3PositionX;
	public float GRECO_GoalPanelMarbleFan3PositionY;
	public float GRECO_GoalPanelMarbleFan3ScaleX;
	public float GRECO_GoalPanelMarbleFan3ScaleY;




	public string RAINFOREST_GoalPanelMarbleType1;
	public string RAINFOREST_GoalPanelMarbleType2;

	public float RAINFOREST_ManaOverlayPositionX;
	public float RAINFOREST_ManaOverlayPositionY;
	public float RAINFOREST_ManaOverlayScaleX;
	public float RAINFOREST_ManaOverlayScaleY;

	public float RAINFOREST_BoardPositionX;
	public float RAINFOREST_BoardPositionY;
	public float RAINFOREST_BoardScaleX;
	public float RAINFOREST_BoardScaleY;

	public float RAINFOREST_LeftUIPositionX;
	public float RAINFOREST_LeftUIPositionY;
	public float RAINFOREST_LeftUIScaleX;
	public float RAINFOREST_LeftUIScaleY;

	public float RAINFOREST_RightUIPositionX;
	public float RAINFOREST_RightUIPositionY;
	public float RAINFOREST_RightUIScaleX;
	public float RAINFOREST_RightUIScaleY;

	public float RAINFOREST_TopUI1PositionX;
	public float RAINFOREST_TopUI1PositionY;
	public float RAINFOREST_TopUI1ScaleX;
	public float RAINFOREST_TopUI1ScaleY;

	public float RAINFOREST_TopUI2PositionX;
	public float RAINFOREST_TopUI2PositionY;
	public float RAINFOREST_TopUI2ScaleX;
	public float RAINFOREST_TopUI2ScaleY;

	public float RAINFOREST_TopUI3PositionX;
	public float RAINFOREST_TopUI3PositionY;
	public float RAINFOREST_TopUI3ScaleX;
	public float RAINFOREST_TopUI3ScaleY;

	public float RAINFOREST_BottomUI1PositionX;
	public float RAINFOREST_BottomUI1PositionY;
	public float RAINFOREST_BottomUI1ScaleX;
	public float RAINFOREST_BottomUI1ScaleY;

	public float RAINFOREST_BottomUI2PositionX;
	public float RAINFOREST_BottomUI2PositionY;
	public float RAINFOREST_BottomUI2ScaleX;
	public float RAINFOREST_BottomUI2ScaleY;

	public float RAINFOREST_BottomUI3PositionX;
	public float RAINFOREST_BottomUI3PositionY;
	public float RAINFOREST_BottomUI3ScaleX;
	public float RAINFOREST_BottomUI3ScaleY;

	public float RAINFOREST_EnemyPositionX;
	public float RAINFOREST_EnemyPositionY;
	public float RAINFOREST_EnemyScaleX;
	public float RAINFOREST_EnemyScaleY;

	public float RAINFOREST_ProgressIndicatorPositionX;
	public float RAINFOREST_ProgressIndicatorPositionY;
	public float RAINFOREST_ProgressIndicatorScaleX;
	public float RAINFOREST_ProgressIndicatorScaleY;

	public float RAINFOREST_Gate1PositionX;
	public float RAINFOREST_Gate1PositionY;
	public float RAINFOREST_Gate1ScaleX;
	public float RAINFOREST_Gate1ScaleY;

	public float RAINFOREST_Gate2PositionX;
	public float RAINFOREST_Gate2PositionY;
	public float RAINFOREST_Gate2ScaleX;
	public float RAINFOREST_Gate2ScaleY;

	public float RAINFOREST_Gate3PositionX;
	public float RAINFOREST_Gate3PositionY;
	public float RAINFOREST_Gate3ScaleX;
	public float RAINFOREST_Gate3ScaleY;

	public float RAINFOREST_GoalPanelMarbleDragon1PositionX;
	public float RAINFOREST_GoalPanelMarbleDragon1PositionY;
	public float RAINFOREST_GoalPanelMarbleDragon1ScaleX;
	public float RAINFOREST_GoalPanelMarbleDragon1ScaleY;

	public float RAINFOREST_GoalPanelMarbleDragon2PositionX;
	public float RAINFOREST_GoalPanelMarbleDragon2PositionY;
	public float RAINFOREST_GoalPanelMarbleDragon2ScaleX;
	public float RAINFOREST_GoalPanelMarbleDragon2ScaleY;

	public float RAINFOREST_GoalPanelMarbleDragon3PositionX;
	public float RAINFOREST_GoalPanelMarbleDragon3PositionY;
	public float RAINFOREST_GoalPanelMarbleDragon3ScaleX;
	public float RAINFOREST_GoalPanelMarbleDragon3ScaleY;

	public float RAINFOREST_GoalPanelMarbleFan1PositionX;
	public float RAINFOREST_GoalPanelMarbleFan1PositionY;
	public float RAINFOREST_GoalPanelMarbleFan1ScaleX;
	public float RAINFOREST_GoalPanelMarbleFan1ScaleY;

	public float RAINFOREST_GoalPanelMarbleFan2PositionX;
	public float RAINFOREST_GoalPanelMarbleFan2PositionY;
	public float RAINFOREST_GoalPanelMarbleFan2ScaleX;
	public float RAINFOREST_GoalPanelMarbleFan2ScaleY;

	public float RAINFOREST_GoalPanelMarbleFan3PositionX;
	public float RAINFOREST_GoalPanelMarbleFan3PositionY;
	public float RAINFOREST_GoalPanelMarbleFan3ScaleX;
	public float RAINFOREST_GoalPanelMarbleFan3ScaleY;



	public float GetManaOverlayPositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_ManaOverlayPositionX;
			break;
		case "EGYPT":
			return EGYPT_ManaOverlayPositionX;
			break;
		case "GRECO":
			return GRECO_ManaOverlayPositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_ManaOverlayPositionX;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_ManaOverlayPositionX;
			//break;
		////case "HOPI":
			//return HOPI_ManaOverlayPositionX;
			//break;
		} return 0.0f;
	}

	public float GetManaOverlayPositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_ManaOverlayPositionY;
			break;
		case "EGYPT":
			return EGYPT_ManaOverlayPositionY;
			break;
		case "GRECO":
			return GRECO_ManaOverlayPositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_ManaOverlayPositionY;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_ManaOverlayPositionY;
			//break;
		////case "HOPI":
			//return HOPI_ManaOverlayPositionY;
			//break;
		} return 0.0f;
	}

	public float GetManaOverlayScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_ManaOverlayScaleX;
			break;
		case "EGYPT":
			return EGYPT_ManaOverlayScaleX;
			break;
		case "GRECO":
			return GRECO_ManaOverlayScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_ManaOverlayScaleX;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_ManaOverlayScaleX;
			//break;
		////case "HOPI":
			//return HOPI_ManaOverlayScaleX;
			//break;
		} return 0.0f;
	}

	public float GetManaOverlayScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_ManaOverlayScaleY;
			break;
		case "EGYPT":
			return EGYPT_ManaOverlayScaleY;
			break;
		case "GRECO":
			return GRECO_ManaOverlayScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_ManaOverlayScaleY;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_ManaOverlayScaleY;
			//break;
		////case "HOPI":
			//return HOPI_ManaOverlayScaleY;
			//break;
		} return 0.0f;
	}

	public float GetBoardPositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BoardPositionX;
			break;
		case "EGYPT":
			return EGYPT_BoardPositionX;
			break;
		case "GRECO":
			return GRECO_BoardPositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_BoardPositionX;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_BoardPositionX;
			//break;
		////case "HOPI":
			//return HOPI_BoardPositionX;
			//break;
		} return 0.0f;
	}

	public float GetBoardPositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BoardPositionY;
			break;
		case "EGYPT":
			return EGYPT_BoardPositionY;
			break;
		case "GRECO":
			return GRECO_BoardPositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_BoardPositionY;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_BoardPositionY;
			//break;
		////case "HOPI":
			//return HOPI_BoardPositionY;
			//break;
		} return 0.0f;
	}

	public float GetBoardScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BoardScaleX;
			break;
		case "EGYPT":
			return EGYPT_BoardScaleX;
			break;
		case "GRECO":
			return GRECO_BoardScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_BoardScaleX;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_BoardScaleX;
		//	break;
		////case "HOPI":
			//return HOPI_BoardScaleX;
		//	break;
		} return 0.0f;
	} 

	public float GetBoardScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BoardScaleY;
			break;
		case "EGYPT":
			return EGYPT_BoardScaleY;
			break;
		case "GRECO":
			return GRECO_BoardScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_BoardScaleY;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_BoardScaleY;
		//	break;
		////case "HOPI":
			//return HOPI_BoardScaleY;
		//	break;
		} return 0.0f;
	}

	public float GetLeftUIPositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_LeftUIPositionX;
			break;
		case "EGYPT":
			return EGYPT_LeftUIPositionX;
			break;
		case "GRECO":
			return GRECO_LeftUIPositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_LeftUIPositionX;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_LeftUIPositionX;
		//	break;
		////case "HOPI":
			//return HOPI_LeftUIPositionX;
		//	break;
		} return 0.0f;
	}

	public float GetLeftUIPositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_LeftUIPositionY;
			break;
		case "EGYPT":
			return EGYPT_LeftUIPositionY;
			break;
		case "GRECO":
			return GRECO_LeftUIPositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_LeftUIPositionY;
			break;
		//////case "MEDIEVAL":
			//return MEDIEVAL_LeftUIPositionY;
		//	break;
		////case "HOPI":
			//return HOPI_LeftUIPositionY;
		//	break;
		} return 0.0f;
	}

	public float GetLeftUIScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_LeftUIScaleX;
			break;
		case "EGYPT":
			return EGYPT_LeftUIScaleX;
			break;
		case "GRECO":
			return GRECO_LeftUIScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_LeftUIScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_LeftUIScaleX;
			break;
		//case "HOPI":
			//return HOPI_LeftUIScaleX;
			break;
		} return 0.0f;
	}

	public float GetLeftUIScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_LeftUIScaleY;
			break;
		case "EGYPT":
			return EGYPT_LeftUIScaleY;
			break;
		case "GRECO":
			return GRECO_LeftUIScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_LeftUIScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_LeftUIScaleY;
			break;
		//case "HOPI":
			//return HOPI_LeftUIScaleY;
			break;
		} return 0.0f;
	}


	public float GetRightUIPositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_RightUIPositionX;
			break;
		case "EGYPT":
			return EGYPT_RightUIPositionX;
			break;
		case "GRECO":
			return GRECO_RightUIPositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_RightUIPositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_RightUIPositionX;
			break;
		//case "HOPI":
			//return HOPI_RightUIPositionX;
			break;
		} return 0.0f;
	} 

	public float GetRightUIPositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_RightUIPositionY;
			break;
		case "EGYPT":
			return EGYPT_RightUIPositionY;
			break;
		case "GRECO":
			return GRECO_RightUIPositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_RightUIPositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_RightUIPositionY;
			break;
		//case "HOPI":
			//return HOPI_RightUIPositionY;
			break;
		} return 0.0f;
	}

	public float GetRightUIScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_RightUIScaleX;
			break;
		case "EGYPT":
			return EGYPT_RightUIScaleX;
			break;
		case "GRECO":
			return GRECO_RightUIScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_RightUIScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_RightUIScaleX;
			break;
		//case "HOPI":
			//return HOPI_RightUIScaleX;
			break;
		} return 0.0f;
	}

	public float GetRightUIScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_RightUIScaleY;
			break;
		case "EGYPT":
			return EGYPT_RightUIScaleY;
			break;
		case "GRECO":
			return GRECO_RightUIScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_RightUIScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_RightUIScaleY;
			break;
		//case "HOPI":
			//return HOPI_RightUIScaleY;
			break;
		} return 0.0f;
	}


	public float GetTopUI1PositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI1PositionX;
			break;
		case "EGYPT":
			return EGYPT_TopUI1PositionX;
			break;
		case "GRECO":
			return GRECO_TopUI1PositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI1PositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI1PositionX;
			break;
		//case "HOPI":
			//return HOPI_TopUI1PositionX;
			break;
		} return 0.0f;
	}

	public float GetTopUI1PositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI1PositionY;
			break;
		case "EGYPT":
			return EGYPT_TopUI1PositionY;
			break;
		case "GRECO":
			return GRECO_TopUI1PositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI1PositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI1PositionY;
			break;
		//case "HOPI":
			//return HOPI_TopUI1PositionY;
			break;
		} return 0.0f;
	}

	public float GetTopUI1ScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI1ScaleX;
			break;
		case "EGYPT":
			return EGYPT_TopUI1ScaleX;
			break;
		case "GRECO":
			return GRECO_TopUI1ScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI1ScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI1ScaleX;
			break;
		//case "HOPI":
			//return HOPI_TopUI1ScaleX;
			break;
		} return 0.0f;
	}

	public float GetTopUI1ScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI1ScaleY;
			break;
		case "EGYPT":
			return EGYPT_TopUI1ScaleY;
			break;
		case "GRECO":
			return GRECO_TopUI1ScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI1ScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI1ScaleY;
			break;
		//case "HOPI":
			//return HOPI_TopUI1ScaleY;
			break;
		} return 0.0f;
	}


	public float GetTopUI2PositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI2PositionX;
			break;
		case "EGYPT":
			return EGYPT_TopUI2PositionX;
			break;
		case "GRECO":
			return GRECO_TopUI2PositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI2PositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI2PositionX;
			break;
		//case "HOPI":
			//return HOPI_TopUI2PositionX;
			break;
		} return 0.0f;
	}

	public float GetTopUI2PositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI2PositionY;
			break;
		case "EGYPT":
			return EGYPT_TopUI2PositionY;
			break;
		case "GRECO":
			return GRECO_TopUI2PositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI2PositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI2PositionY;
			break;
		//case "HOPI":
			//return HOPI_TopUI2PositionY;
			break;
		} return 0.0f;
	}

	public float GetTopUI2ScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI2ScaleX;
			break;
		case "EGYPT":
			return EGYPT_TopUI2ScaleX;
			break;
		case "GRECO":
			return GRECO_TopUI2ScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI2ScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI2ScaleX;
			break;
		//case "HOPI":
			//return HOPI_TopUI2ScaleX;
			break;
		} return 0.0f;
	}

	public float GetTopUI2ScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI2ScaleY;
			break;
		case "EGYPT":
			return EGYPT_TopUI2ScaleY;
			break;
		case "GRECO":
			return GRECO_TopUI2ScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI2ScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI2ScaleY;
			break;
		//case "HOPI":
			//return HOPI_TopUI2ScaleY;
			break;
		} return 0.0f;
	}


	public float GetTopUI3PositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI3PositionX;
			break;
		case "EGYPT":
			return EGYPT_TopUI3PositionX;
			break;
		case "GRECO":
			return GRECO_TopUI3PositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI3PositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI3PositionX;
			break;
		//case "HOPI":
			//return HOPI_TopUI3PositionX;
			break;
		} return 0.0f;
	}

	public float GetTopUI3PositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI3PositionY;
			break;
		case "EGYPT":
			return EGYPT_TopUI3PositionY;
			break;
		case "GRECO":
			return GRECO_TopUI3PositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI3PositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI3PositionY;
			break;
		//case "HOPI":
			//return HOPI_TopUI3PositionY;
			break;
		} return 0.0f;
	}

	public float GetTopUI3ScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI3ScaleX;
			break;
		case "EGYPT":
			return EGYPT_TopUI3ScaleX;
			break;
		case "GRECO":
			return GRECO_TopUI3ScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI3ScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI3ScaleX;
			break;
		//case "HOPI":
			//return HOPI_TopUI3ScaleX;
			break;
		} return 0.0f;
	}

	public float GetTopUI3ScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_TopUI3ScaleY;
			break;
		case "EGYPT":
			return EGYPT_TopUI3ScaleY;
			break;
		case "GRECO":
			return GRECO_TopUI3ScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_TopUI3ScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_TopUI3ScaleY;
			break;
		//case "HOPI":
			//return HOPI_TopUI3ScaleY;
			break;
		} return 0.0f;
	}


	public float GetBottomUI1PositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI1PositionX;
			break;
		case "EGYPT":
			return EGYPT_BottomUI1PositionX;
			break;
		case "GRECO":
			return GRECO_BottomUI1PositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI1PositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI1PositionX;
			break;
		//case "HOPI":
			//return HOPI_BottomUI1PositionX;
			break;
		} return 0.0f;
	}

	public float GetBottomUI1PositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI1PositionY;
			break;
		case "EGYPT":
			return EGYPT_BottomUI1PositionY;
			break;
		case "GRECO":
			return GRECO_BottomUI1PositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI1PositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI1PositionY;
			break;
		//case "HOPI":
			//return HOPI_BottomUI1PositionY;
			break;
		} return 0.0f;
	}

	public float GetBottomUI1ScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI1ScaleX;
			break;
		case "EGYPT":
			return EGYPT_BottomUI1ScaleX;
			break;
		case "GRECO":
			return GRECO_BottomUI1ScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI1ScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI1ScaleX;
			break;
		//case "HOPI":
			//return HOPI_BottomUI1ScaleX;
			break;
		} return 0.0f;
	}

	public float GetBottomUI1ScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI1ScaleY;
			break;
		case "EGYPT":
			return EGYPT_BottomUI1ScaleY;
			break;
		case "GRECO":
			return GRECO_BottomUI1ScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI1ScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI1ScaleY;
			break;
		//case "HOPI":
			//return HOPI_BottomUI1ScaleY;
			break;
		} return 0.0f;
	}


	public float GetBottomUI2PositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI2PositionX;
			break;
		case "EGYPT":
			return EGYPT_BottomUI2PositionX;
			break;
		case "GRECO":
			return GRECO_BottomUI2PositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI2PositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI2PositionX;
			break;
		//case "HOPI":
			//return HOPI_BottomUI2PositionX;
			break;
		} return 0.0f;
	}

	public float GetBottomUI2PositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI2PositionY;
			break;
		case "EGYPT":
			return EGYPT_BottomUI2PositionY;
			break;
		case "GRECO":
			return GRECO_BottomUI2PositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI2PositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI2PositionY;
			break;
		//case "HOPI":
			//return HOPI_BottomUI2PositionY;
			break;
		} return 0.0f;
	}

	public float GetBottomUI2ScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI2ScaleX;
			break;
		case "EGYPT":
			return EGYPT_BottomUI2ScaleX;
			break;
		case "GRECO":
			return GRECO_BottomUI2ScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI2ScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI2ScaleX;
			break;
		//case "HOPI":
			//return HOPI_BottomUI2ScaleX;
			break;
		} return 0.0f;
	}

	public float GetBottomUI2ScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI2ScaleY;
			break;
		case "EGYPT":
			return EGYPT_BottomUI2ScaleY;
			break;
		case "GRECO":
			return GRECO_BottomUI2ScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI2ScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI2ScaleY;
			break;
		//case "HOPI":
			//return HOPI_BottomUI2ScaleY;
			break;
		} return 0.0f;
	}


	public float GetBottomUI3PositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI3PositionX;
			break;
		case "EGYPT":
			return EGYPT_BottomUI3PositionX;
			break;
		case "GRECO":
			return GRECO_BottomUI3PositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI3PositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI3PositionX;
			break;
		//case "HOPI":
			//return HOPI_BottomUI3PositionX;
			break;
		} return 0.0f;
	}

	public float GetBottomUI3PositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI3PositionY;
			break;
		case "EGYPT":
			return EGYPT_BottomUI3PositionY;
			break;
		case "GRECO":
			return GRECO_BottomUI3PositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI3PositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI3PositionY;
			break;
		//case "HOPI":
			//return HOPI_BottomUI3PositionY;
			break;
		} return 0.0f;
	}

	public float GetBottomUI3ScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI3ScaleX;
			break;
		case "EGYPT":
			return EGYPT_BottomUI3ScaleX;
			break;
		case "GRECO":
			return GRECO_BottomUI3ScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI3ScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI3ScaleX;
			break;
		//case "HOPI":
			//return HOPI_BottomUI3ScaleX;
			break;
		} return 0.0f;
	}

	public float GetBottomUI3ScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_BottomUI3ScaleY;
			break;
		case "EGYPT":
			return EGYPT_BottomUI3ScaleY;
			break;
		case "GRECO":
			return GRECO_BottomUI3ScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_BottomUI3ScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_BottomUI3ScaleY;
			break;
		//case "HOPI":
			//return HOPI_BottomUI3ScaleY;
			break;
		} return 0.0f;
	}



	public float GetEnemyPositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_EnemyPositionX;
			break;
		case "EGYPT":
			return EGYPT_EnemyPositionX;
			break;
		case "GRECO":
			return GRECO_EnemyPositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_EnemyPositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_EnemyPositionX;
			break;
		//case "HOPI":
			//return HOPI_EnemyPositionX;
			break;
		} return 0.0f;
	}

	public float GetEnemyPositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_EnemyPositionY;
			break;
		case "EGYPT":
			return EGYPT_EnemyPositionY;
			break;
		case "GRECO":
			return GRECO_EnemyPositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_EnemyPositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_EnemyPositionY;
			break;
		//case "HOPI":
			//return HOPI_EnemyPositionY;
			break;
		} return 0.0f;
	}

	public float GetEnemyScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_EnemyScaleX;
			break;
		case "EGYPT":
			return EGYPT_EnemyScaleX;
			break;
		case "GRECO":
			return GRECO_EnemyScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_EnemyScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_EnemyScaleX;
			break;
		//case "HOPI":
			//return HOPI_EnemyScaleX;
			break;
		} return 0.0f;
	}

	public float GetEnemyScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_EnemyScaleY;
			break;
		case "EGYPT":
			return EGYPT_EnemyScaleY;
			break;
		case "GRECO":
			return GRECO_EnemyScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_EnemyScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_EnemyScaleY;
			break;
		//case "HOPI":
			//return HOPI_EnemyScaleY;
			break;
		} return 0.0f;
	}


	public float GetProgressIndicatorPositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_ProgressIndicatorPositionX;
			break;
		case "EGYPT":
			return EGYPT_ProgressIndicatorPositionX;
			break;
		case "GRECO":
			return GRECO_ProgressIndicatorPositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_ProgressIndicatorPositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_ProgressIndicatorPositionX;
			break;
		//case "HOPI":
			//return HOPI_ProgressIndicatorPositionX;
			break;
		} return 0.0f;
	}

	public float GetProgressIndicatorPositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_ProgressIndicatorPositionY;
			break;
		case "EGYPT":
			return EGYPT_ProgressIndicatorPositionY;
			break;
		case "GRECO":
			return GRECO_ProgressIndicatorPositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_ProgressIndicatorPositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_ProgressIndicatorPositionY;
			break;
		//case "HOPI":
			//return HOPI_ProgressIndicatorPositionY;
			break;
		} return 0.0f;
	}

	public float GetProgressIndicatorScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_ProgressIndicatorScaleX;
			break;
		case "EGYPT":
			return EGYPT_ProgressIndicatorScaleX;
			break;
		case "GRECO":
			return GRECO_ProgressIndicatorScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_ProgressIndicatorScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_ProgressIndicatorScaleX;
			break;
		//case "HOPI":
			//return HOPI_ProgressIndicatorScaleX;
			break;
		} return 0.0f;
	}

	public float GetProgressIndicatorScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_ProgressIndicatorScaleY;
			break;
		case "EGYPT":
			return EGYPT_ProgressIndicatorScaleY;
			break;
		case "GRECO":
			return GRECO_ProgressIndicatorScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_ProgressIndicatorScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_ProgressIndicatorScaleY;
			break;
		//case "HOPI":
			//return HOPI_ProgressIndicatorScaleY;
			break;
		} return 0.0f;
	}


	public float GetGate1PositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate1PositionX;
			break;
		case "EGYPT":
			return EGYPT_Gate1PositionX;
			break;
		case "GRECO":
			return GRECO_Gate1PositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate1PositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate1PositionX;
			break;
		//case "HOPI":
			//return HOPI_Gate1PositionX;
			break;
		} return 0.0f;
	}

	public float GetGate1PositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate1PositionY;
			break;
		case "EGYPT":
			return EGYPT_Gate1PositionY;
			break;
		case "GRECO":
			return GRECO_Gate1PositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate1PositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate1PositionY;
			break;
		//case "HOPI":
			//return HOPI_Gate1PositionY;
			break;
		} return 0.0f;
	}

	public float GetGate1ScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate1ScaleX;
			break;
		case "EGYPT":
			return EGYPT_Gate1ScaleX;
			break;
		case "GRECO":
			return GRECO_Gate1ScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate1ScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate1ScaleX;
			break;
		//case "HOPI":
			//return HOPI_Gate1ScaleX;
			break;
		} return 0.0f;
	}

	public float GetGate1ScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate1ScaleY;
			break;
		case "EGYPT":
			return EGYPT_Gate1ScaleY;
			break;
		case "GRECO":
			return GRECO_Gate1ScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate1ScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate1ScaleY;
			break;
		//case "HOPI":
			//return HOPI_Gate1ScaleY;
			break;
		} return 0.0f;
	}

	public float GetGate2PositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate2PositionX;
			break;
		case "EGYPT":
			return EGYPT_Gate2PositionX;
			break;
		case "GRECO":
			return GRECO_Gate2PositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate2PositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate2PositionX;
			break;
		//case "HOPI":
			//return HOPI_Gate2PositionX;
			break;
		} return 0.0f;
	}

	public float GetGate2PositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate2PositionY;
			break;
		case "EGYPT":
			return EGYPT_Gate2PositionY;
			break;
		case "GRECO":
			return GRECO_Gate2PositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate2PositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate2PositionY;
			break;
		//case "HOPI":
			//return HOPI_Gate2PositionY;
			break;
		} return 0.0f;
	}

	public float GetGate2ScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate2ScaleX;
			break;
		case "EGYPT":
			return EGYPT_Gate2ScaleX;
			break;
		case "GRECO":
			return GRECO_Gate2ScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate2ScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate2ScaleX;
			break;
		//case "HOPI":
			//return HOPI_Gate2ScaleX;
			break;
		} return 0.0f;
	}

	public float GetGate2ScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate2ScaleY;
			break;
		case "EGYPT":
			return EGYPT_Gate2ScaleY;
			break;
		case "GRECO":
			return GRECO_Gate2ScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate2ScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate2ScaleY;
			break;
		//case "HOPI":
			//return HOPI_Gate2ScaleY;
			break;
		} return 0.0f;
	}

	public float GetGate3PositionX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate3PositionX;
			break;
		case "EGYPT":
			return EGYPT_Gate3PositionX;
			break;
		case "GRECO":
			return GRECO_Gate3PositionX;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate3PositionX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate3PositionX;
			break;
		//case "HOPI":
			//return HOPI_Gate3PositionX;
			break;
		} return 0.0f;
	}

	public float GetGate3PositionY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate3PositionY;
			break;
		case "EGYPT":
			return EGYPT_Gate3PositionY;
			break;
		case "GRECO":
			return GRECO_Gate3PositionY;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate3PositionY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate3PositionY;
			break;
		//case "HOPI":
			//return HOPI_Gate3PositionY;
			break;
		} return 0.0f;
	}

	public float GetGate3ScaleX(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate3ScaleX;
			break;
		case "EGYPT":
			return EGYPT_Gate3ScaleX;
			break;
		case "GRECO":
			return GRECO_Gate3ScaleX;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate3ScaleX;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate3ScaleX;
			break;
		//case "HOPI":
			//return HOPI_Gate3ScaleX;
			break;
		} return 0.0f;
	}

	public float GetGate3ScaleY(string currentLvl) {

		switch(currentLvl) {

		case "ASIA":
			return ASIA_Gate3ScaleY;
			break;
		case "EGYPT":
			return EGYPT_Gate3ScaleY;
			break;
		case "GRECO":
			return GRECO_Gate3ScaleY;
			break;
		case "RAINFOREST":
			return RAINFOREST_Gate3ScaleY;
			break;
		////case "MEDIEVAL":
			//return MEDIEVAL_Gate3ScaleY;
			break;
		//case "HOPI":
			//return HOPI_Gate3ScaleY;
			break;
		} return 0.0f;
	}
}

