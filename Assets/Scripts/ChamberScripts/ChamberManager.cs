using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChamberManager : MonoBehaviour {

	private Utils utils;
	private string menuID = "CHAMBER";

	private int pieceToMoveValue = 1;
	private int maxNumberOfPieces = 5;

	private float lerpRate = 2.0f;

	void Start () {

		Init ();
		BuildChamber ();

		InvokeRepeating("MovePieces", 0.0f, 3.0f);
	}

	void Update () {
		
	}

	void Init() {

		utils = gameObject.GetComponent<Utils> ();
	}

	void BuildChamber() {
		
		utils.InstantiateObject ("CHAMBER/CHAMBER_BG", new Vector2 (Serialization.chamberConfig.CHAMBER_BGPositionX, Serialization.chamberConfig.CHAMBER_BGPositionY), 
			new Vector2 (Serialization.chamberConfig.CHAMBER_BGScaleX, Serialization.chamberConfig.CHAMBER_BGScaleY));
		
		utils.InstantiateObject ("CHAMBER/CHAMBER_Piece1", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece1StartPositionX, Serialization.chamberConfig.CHAMBER_Piece1StartPositionY), 
			new Vector2 (Serialization.chamberConfig.CHAMBER_Piece1ScaleX, Serialization.chamberConfig.CHAMBER_Piece1ScaleY));

		utils.InstantiateObject ("CHAMBER/CHAMBER_Piece2", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece2StartPositionX, Serialization.chamberConfig.CHAMBER_Piece2StartPositionY), 
			new Vector2 (Serialization.chamberConfig.CHAMBER_Piece2ScaleX, Serialization.chamberConfig.CHAMBER_Piece2ScaleY));

		utils.InstantiateObject ("CHAMBER/CHAMBER_Piece3", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece3StartPositionX, Serialization.chamberConfig.CHAMBER_Piece3StartPositionY), 
			new Vector2 (Serialization.chamberConfig.CHAMBER_Piece3ScaleX, Serialization.chamberConfig.CHAMBER_Piece3ScaleY));

		utils.InstantiateObject ("CHAMBER/CHAMBER_Piece4", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece4StartPositionX, Serialization.chamberConfig.CHAMBER_Piece4StartPositionY), 
			new Vector2 (Serialization.chamberConfig.CHAMBER_Piece4ScaleX, Serialization.chamberConfig.CHAMBER_Piece4ScaleY));

		utils .InstantiateObject ("CHAMBER/CHAMBER_Piece5", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece5StartPositionX, Serialization.chamberConfig.CHAMBER_Piece5StartPositionY), 
			new Vector2 (Serialization.chamberConfig.CHAMBER_Piece5ScaleX, Serialization.chamberConfig.CHAMBER_Piece5ScaleY));
	}

	void MovePiece(string gameObjName, Vector2 startVector, Vector2 endVector) {

			StartCoroutine (utils.MoveObject (GameObject.Find (gameObjName).transform, startVector, endVector, lerpRate));
	}

	void MovePieces() {

		if (pieceToMoveValue >= maxNumberOfPieces + 1) {
			CancelInvoke ();
		}

		switch (pieceToMoveValue) {

		case 1:
			MovePiece ("CHAMBER_Piece1(Clone)", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece1StartPositionX, 
				Serialization.chamberConfig.CHAMBER_Piece1StartPositionY),
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece1EndPositionX, 
					Serialization.chamberConfig.CHAMBER_Piece1EndPositionY));
			pieceToMoveValue++;
			break;
		case 2:
			SwapPieces ("CHAMBER_Piece1(Clone)", "CHAMBER/CHAMBER_LitPiece1", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece1EndPositionX, Serialization.chamberConfig.CHAMBER_Piece1EndPositionY), 
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece1ScaleX, Serialization.chamberConfig.CHAMBER_Piece1ScaleY));
			MovePiece ("CHAMBER_Piece2(Clone)", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece2StartPositionX, 
				Serialization.chamberConfig.CHAMBER_Piece2StartPositionY),
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece2EndPositionX, 
					Serialization.chamberConfig.CHAMBER_Piece2EndPositionY));
			pieceToMoveValue++;
			break;
		case 3:
			SwapPieces ("CHAMBER_Piece2(Clone)", "CHAMBER/CHAMBER_LitPiece2", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece2EndPositionX, Serialization.chamberConfig.CHAMBER_Piece2EndPositionY), 
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece2ScaleX, Serialization.chamberConfig.CHAMBER_Piece2ScaleY));
			MovePiece ("CHAMBER_Piece3(Clone)", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece3StartPositionX, 
				Serialization.chamberConfig.CHAMBER_Piece3StartPositionY),
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece3EndPositionX, 
					Serialization.chamberConfig.CHAMBER_Piece3EndPositionY));
			pieceToMoveValue++;
			break;
		case 4:
			SwapPieces ("CHAMBER_Piece3(Clone)", "CHAMBER/CHAMBER_LitPiece3", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece3EndPositionX, Serialization.chamberConfig.CHAMBER_Piece3EndPositionY), 
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece3ScaleX, Serialization.chamberConfig.CHAMBER_Piece3ScaleY));
			MovePiece ("CHAMBER_Piece4(Clone)", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece4StartPositionX, 
				Serialization.chamberConfig.CHAMBER_Piece4StartPositionY),
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece4EndPositionX, 
					Serialization.chamberConfig.CHAMBER_Piece4EndPositionY));
			pieceToMoveValue++;
			break;
		case 5:
			SwapPieces ("CHAMBER_Piece4(Clone)", "CHAMBER/CHAMBER_LitPiece4", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece4EndPositionX, Serialization.chamberConfig.CHAMBER_Piece4EndPositionY), 
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece4ScaleX, Serialization.chamberConfig.CHAMBER_Piece4ScaleY));
			MovePiece ("CHAMBER_Piece5(Clone)", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece5StartPositionX, 
				Serialization.chamberConfig.CHAMBER_Piece5StartPositionY),
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece5EndPositionX, 
					Serialization.chamberConfig.CHAMBER_Piece5EndPositionY));
			pieceToMoveValue++;
			break;
		case 6:
			SwapPieces ("CHAMBER_Piece5(Clone)", "CHAMBER/CHAMBER_LitPiece5", new Vector2 (Serialization.chamberConfig.CHAMBER_Piece5EndPositionX, Serialization.chamberConfig.CHAMBER_Piece5EndPositionY), 
				new Vector2 (Serialization.chamberConfig.CHAMBER_Piece5ScaleX, Serialization.chamberConfig.CHAMBER_Piece5ScaleY));
			break;
		}
	}

	void SwapPieces(string go1ID, string path, Vector2 position, Vector2 scale) {
		Debug.Log("ACCESSED");
		Destroy(GameObject.Find(go1ID));
		utils.InstantiateObject (path, position, scale);

	}

	void SwitchPieceWithGlowingPiece(string name, Vector2 position, Vector2 scale) {

		//Do Later...
	}
		
}
