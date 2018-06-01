using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	private Utils utils;
	private string menuID = "MAIN_MENU";

	void Start () {

		DontDestroyOnLoad (gameObject);
		Init ();
		BuildMenu ();
	}
		
	void Init() {

		utils = gameObject.GetComponent<Utils> ();
	}

	void BuildMenu() {

		utils.InstantiateObject ("MAIN_MENU/BGComponents/MAIN_MENU_SkyBackground", new Vector2 (Serialization.menuConfig.MENU_SkyBackgroundPositionX,
			Serialization.menuConfig.MENU_SkyBackgroundPositionY), new Vector2 (Serialization.menuConfig.MENU_SkyBackgroundScaleX, 
				Serialization.menuConfig.MENU_SkyBackgroundScaleY));

		utils.InstantiateObject ("MAIN_MENU/BGComponents/MAIN_MENU_SkyTemple", new Vector2 (Serialization.menuConfig.MENU_SkyTemplePositionX,
			Serialization.menuConfig.MENU_SkyTemplePositionY), new Vector2 (Serialization.menuConfig.MENU_SkyTempleScaleX, 
				Serialization.menuConfig.MENU_SkyTempleScaleY));

		utils.InstantiateObject ("MAIN_MENU/BGComponents/MAIN_MENU_MiddleLayer", new Vector2 (Serialization.menuConfig.MENU_MiddleLayerPositionX,
			Serialization.menuConfig.MENU_MiddleLayerPositionY), new Vector2 (Serialization.menuConfig.MENU_MiddleLayerScaleX, 
				Serialization.menuConfig.MENU_MiddleLayerScaleY));

		utils.InstantiateObject ("MAIN_MENU/BGComponents/MAIN_MENU_FrontGrass", new Vector2 (Serialization.menuConfig.MENU_FrontGrassPositionX,
			Serialization.menuConfig.MENU_FrontGrassPositionY), new Vector2 (Serialization.menuConfig.MENU_FrontGrassScaleX, 
				Serialization.menuConfig.MENU_FrontGrassScaleY));

		utils.InstantiateObject ("MAIN_MENU/BGComponents/MAIN_MENU_Temple", new Vector2 (Serialization.menuConfig.MENU_TemplePositionX,
			Serialization.menuConfig.MENU_TemplePositionY), new Vector2 (Serialization.menuConfig.MENU_TempleScaleX, 
				Serialization.menuConfig.MENU_TempleScaleY));

		utils.InstantiateObject ("MAIN_MENU/BGComponents/MAIN_MENU_Christine", new Vector2 (Serialization.menuConfig.MENU_ChristinePositionX,
			Serialization.menuConfig.MENU_ChristinePositionY), new Vector2 (Serialization.menuConfig.MENU_ChristineScaleX, 
				Serialization.menuConfig.MENU_ChristineScaleY));

		utils.InstantiateObject ("MAIN_MENU/BGComponents/MAIN_MENU_LeftBeam", new Vector2 (Serialization.menuConfig.MENU_LeftBeamPositionX,
			Serialization.menuConfig.MENU_LeftBeamPositionY), new Vector2 (Serialization.menuConfig.MENU_LeftBeamScaleX, 
				Serialization.menuConfig.MENU_LeftBeamScaleY));

		utils.InstantiateObject ("MAIN_MENU/BGComponents/MAIN_MENU_LeftDownBeam", new Vector2 (Serialization.menuConfig.MENU_LeftDownBeamPositionX,
			Serialization.menuConfig.MENU_LeftDownBeamPositionY), new Vector2 (Serialization.menuConfig.MENU_LeftDownBeamScaleX, 
				Serialization.menuConfig.MENU_LeftDownBeamScaleY));

		utils.InstantiateObject ("MAIN_MENU/BGComponents/MAIN_MENU_RightBeam", new Vector2 (Serialization.menuConfig.MENU_RightBeamPositionX,
			Serialization.menuConfig.MENU_RightBeamPositionY), new Vector2 (Serialization.menuConfig.MENU_RightBeamScaleX, 
				Serialization.menuConfig.MENU_RightBeamScaleY));

		utils.InstantiateObject ("MAIN_MENU/MAIN_MENU_AdventureButtonReal", new Vector2 (Serialization.menuConfig.MENU_AdventureBtnPositionX,
			Serialization.menuConfig.MENU_AdventureBtnPositionY), new Vector2 (Serialization.menuConfig.MENU_AdventureBtnScaleX, 
				Serialization.menuConfig.MENU_AdventureBtnScaleY));

		utils.InstantiateObject ("MAIN_MENU/MAIN_MENU_TitleText", new Vector2 (Serialization.menuConfig.MENU_TitleTextPositionX, 
			Serialization.menuConfig.MENU_TitleTextPositionY));
	}
		
}
