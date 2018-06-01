using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;


public class MarbleManager : MonoBehaviour {

	public Text scoreText;

	private int score;
	private bool levelComplete = false;

	public MarbleArray marbles;

	private Vector2 BottomRight = new Vector2(Serialization.boardConfig.GENERAL_MarbleSetPlacementX, Serialization.boardConfig.GENERAL_MarbleSetPlacementY);
	private Vector2 MarbleSize = new Vector2(Serialization.boardConfig.GENERAL_MarbleDistX, Serialization.boardConfig.GENERAL_MarbleDistY);

	private GameState state = GameState.None;
	//private RotateState rotateState = RotateState.None;

	private GameObject hitGo = null;

	private Vector2[] SpawnPositions;

	public GameObject[] MarblePrefabs;
	public GameObject[] ExplosionPrefabs;
	public GameObject[] BonusPrefabs;

	public GameManager gm;

	public ParticleScript ps;
	public MyLogScript log;

	private Vector3 fp;   //First touch position
	private Vector3 lp;   //Last touch position
	private float dragDistance  = 2.0f; //minimum distance for a swipe to be registered

	private IEnumerator CheckPotentialMatchesCoroutine;
	private IEnumerator AnimatePotentialMatchesCoroutine;

	IEnumerable<GameObject> potentialMatches;

	public SoundManager soundManager;

	public AudioSource successSwapSFX;
	public AudioSource failSwapSFX;

	void Start () {
		InitializeTypesOnPrefabShapesAndBonuses ();
		InitializeMarbleAndSpawnPositions ();
		StartCheckForPotentialMatches ();
	}


	void Update () {


		//****** START TOUCH CONTROLS
		/*
			if (Input.touchCount == 1) {

				Touch touch = Input.GetTouch (0);

				Vector2 v = Camera.main.ScreenToWorldPoint(touch.position);

				if (touch.phase == TouchPhase.Began) {

					var hit = Physics2D.OverlapPointAll(v);

					foreach(Collider2D c in hit)
					{
						hitGo = c.GetComponent<Collider2D>().gameObject;
						state = GameState.SelectionStarted;
					//Debug.Log ("hit!");
						fp = touch.position;
						lp = touch.position;
					}
						
				} else if (touch.phase == TouchPhase.Ended) {
					//Debug.Log ("touch ended!");
					var hit = Physics2D.OverlapPointAll(v);

					lp = touch.position;

					if (Mathf.Abs (lp.x - fp.x) > dragDistance || Mathf.Abs (lp.y - fp.y) > dragDistance) {
						//Debug.Log ("it's a swipe!");

						foreach (Collider2D c in hit) {

							if (c.GetComponent<Collider2D> () != null && hitGo != c.GetComponent<Collider2D> ().gameObject) {

								StopCheckForPotentialMatches ();

								if (!MatchChecker.AreHorizontalOrVerticalNeighbors (hitGo.GetComponent<Marble> (), 
									c.GetComponent<Collider2D> ().gameObject.GetComponent<Marble> ())) {
									state = GameState.None;
								} else {
									state = GameState.Animating;
									FixSortingLayer (hitGo, c.GetComponent<Collider2D> ().gameObject);
									StartCoroutine (FindMatchesAndCollapse (c));
								}
							}
						}
					} else {
						//Debug.Log ("just a tap");
						state = GameState.None;
					}
				}
			}
		*/	 
		//***** END TOUCH CONTROLS
	
		//***** START MOUSE CONTROLS

		var mousePos = Input.mousePosition;

		if (state == GameState.None) {

			if (Input.GetMouseButtonDown (0)) {
				mousePos.z = -10;
				Vector2 v = Camera.main.ScreenToWorldPoint (mousePos);
				var hit = Physics2D.OverlapPointAll (v);

				if (hit.Length > 0) {
					foreach (Collider2D c in hit) {
						hitGo = c.GetComponent<Collider2D> ().gameObject;

						//if (hitGo.tag != "ElementalSphere") {
							state = GameState.SelectionStarted;
						//} else if (hitGo.tag == "ElementalSphere")  {
						//	Debug.Log ("ok, so it's a sphere. Now what?");
						//}
					}
				}
			}
		
		} else if (state == GameState.SelectionStarted) {
			
			if (Input.GetMouseButtonDown (0)) {

				mousePos.z = -10;
				Vector2 v = Camera.main.ScreenToWorldPoint (mousePos);
				var hit = Physics2D.OverlapPointAll (v);

				if (hit.Length > 0) {
					foreach (Collider2D c in hit) {

						if (c.GetComponent<Collider2D> () != null && hitGo != c.GetComponent<Collider2D> ().gameObject) {
							
							StopCheckForPotentialMatches ();

							if (!MatchChecker.AreHorizontalOrVerticalNeighbors (hitGo.GetComponent<Marble> (), 
								    c.GetComponent<Collider2D> ().gameObject.GetComponent<Marble> ())) {

								state = GameState.None;
							} else {
								state = GameState.Animating;
								FixSortingLayer (hitGo, c.GetComponent<Collider2D> ().gameObject);
								StartCoroutine (FindMatchesAndCollapse (c));
							}
						}
					}
				}
			}
		} 
		// ****** END MOUSE CONTROLS
		
	} //End Update Function


	private void InitializeVariables() {
		score = 0;
		ShowScore ();
	}

	private void ShowScore() {
		//scoreText.text = "Score " + score.ToString();
	}

	private void IncreaseScore(int amount) {
		score += amount;
		ShowScore ();
	}

	private void DestroyAllMarbles() {
		for(int row = 0; row < GameVariables.Rows; row++) {
			for(int column = 0; column < GameVariables.Columns; column++) {
				Destroy(marbles[row, column]);
			}
		}
	}

	private void InitializeTypesOnPrefabShapesAndBonuses() {
		foreach (var item in MarblePrefabs) {
			//Debug.Log (item);
			item.GetComponent<Marble>().Type = item.name;
		}

		for(int i = 0; i < BonusPrefabs.Length; i++) {
			BonusPrefabs[i].GetComponent<Marble>().Type = MarblePrefabs[i].name;
		}
	}

	private void InstantiateAndPlaceNewMarble(int row, int column, GameObject newMarble) {

		GameObject go = Instantiate (newMarble,
			BottomRight + new Vector2(column * MarbleSize.x, row * MarbleSize.y),
		                             Quaternion.identity) as GameObject;

		go.GetComponent<Marble> ().Initialize (newMarble.GetComponent<Marble>().Type, row, column);

		marbles [row, column] = go;

	}

	private void SetupSpawnPositions() {
		for(int column = 0; column < GameVariables.Columns; column++) {
			SpawnPositions[column] = BottomRight +
				new Vector2(column * MarbleSize.x, GameVariables.Rows * MarbleSize.y);
		}
	}

	private GameObject GetRandomMarble() {
		return MarblePrefabs [Random.Range (0, MarblePrefabs.Length)];
	}

	private GameObject GetRandomExplosion() {
		return ExplosionPrefabs[Random.Range(0, ExplosionPrefabs.Length)];
	}

	public void DisplayLoseScenario() {

		levelComplete = true;

		for(int row = 0; row < GameVariables.Rows; row++) {
			for(int column = 0; column < GameVariables.Columns; column++) {
				marbles [row, column].AddComponent<Rigidbody2D> ();
			}
		}
	}

	public void DisplayWinScenario() {

		levelComplete = true;

		for(int row = 0; row < GameVariables.Rows; row++) {
			for(int column = 0; column < GameVariables.Columns; column++) {
				//marbles.Remove (marbles [row, column]);
				RemoveFromScene(marbles[row,column]);
			}
		}
	}

	public void InitializeMarbleAndSpawnPositions() {
		InitializeVariables ();

		if (marbles != null)
			DestroyAllMarbles ();

		marbles = new MarbleArray ();

		SpawnPositions = new Vector2[GameVariables.Columns];

		for(int row = 0; row < GameVariables.Rows; row++) {
			for(int column = 0; column < GameVariables.Columns; column++) {
				GameObject newMarble = GetRandomMarble();
				
				// checking if the previous two horizontal marbles are the same
				while(column >= 2 && marbles[row, column - 1].GetComponent<Marble>()
					.IsSameType(newMarble.GetComponent<Marble>())
					&& marbles[row, column - 2].GetComponent<Marble>().IsSameType(newMarble.GetComponent<Marble>())) {
					newMarble = GetRandomMarble();
				}

				// checking if the previous two vertical marbles are the same
				while(row >= 2 && marbles[row - 1, column].GetComponent<Marble>().
					IsSameType(newMarble.GetComponent<Marble>())
					&& marbles[row - 2, column].GetComponent<Marble>().IsSameType(newMarble.GetComponent<Marble>())) {
					newMarble = GetRandomMarble();
				}
					
				InstantiateAndPlaceNewMarble(row, column, newMarble);



			}
		}

		SetupSpawnPositions ();

	}

	private void StartCheckForPotentialMatches() {
		StopCheckForPotentialMatches ();

		CheckPotentialMatchesCoroutine = CheckPotentialMatches ();
		StartCoroutine (CheckPotentialMatchesCoroutine);

	}

	private void StopCheckForPotentialMatches() {

		if (AnimatePotentialMatchesCoroutine != null)
			StopCoroutine (AnimatePotentialMatchesCoroutine);

		if (CheckPotentialMatchesCoroutine != null)
			StopCoroutine (CheckPotentialMatchesCoroutine);

		ResetOpacityOnPotentialMatches ();
	}

	private void ResetOpacityOnPotentialMatches() {
		if (potentialMatches != null) {
			foreach(var item in potentialMatches) {
				if(item == null)
					break;

				Color c = item.GetComponent<SpriteRenderer>().color;
				c.a = 1f;
				item.GetComponent<SpriteRenderer>().color = c;
			}
		}
	}

	private IEnumerator CheckPotentialMatches() {
		yield return new WaitForSeconds (GameVariables.WaitBeforePotentialMatchesCheck);

		potentialMatches = MatchChecker.GetPotentialMatches (marbles);

		if (potentialMatches != null) {
			while(true) {
				AnimatePotentialMatchesCoroutine = MatchChecker.AnimatePotentialMatches(potentialMatches);
				StartCoroutine(AnimatePotentialMatchesCoroutine);
				yield return new WaitForSeconds (GameVariables.WaitBeforePotentialMatchesCheck);
			}
		}
	}

	private void FixSortingLayer(GameObject hitGo, GameObject hitGo2) {

		SpriteRenderer sp1 = hitGo.GetComponent<SpriteRenderer> ();
		SpriteRenderer sp2 = hitGo2.GetComponent<SpriteRenderer> ();

		if (sp1.sortingOrder <= sp2.sortingOrder) {
			sp1.sortingOrder = 67;
			sp2.sortingOrder = 66;
		}
	}
		
	private void RemoveFromScene(GameObject item) {
		StartCoroutine (DestroyExplosions(item));
		Destroy (item);
	}

	private void RemoveFromSceneLevelWin(GameObject item) {
		//StartCoroutine (DestroyExplosions (item)", 1.0f);
		Destroy (item);
	}
		
	private IEnumerator DestroyExplosions(GameObject item) {
		var explosion = Instantiate (GetRandomExplosion(), item.transform.position, Quaternion.identity) as GameObject;
		yield return new WaitForSeconds (2.0f);
		Destroy (explosion, GameVariables.ExplosionAnimationDuration);
	}

	private GameObject GetBonusFromType(string type) {
		//string color = type.Split ('_')[1].Trim();
		//Debug.Log ("COLOR: " + color);
		foreach (var item in BonusPrefabs) {
			//if(item.GetComponent<Marble>().Type.Contains(color)) {
			//	Debug.Log ("ITEM THAT MAKES GAME CRASH: " + item);
				return item;
			//}
		}
		throw new System.Exception ("You Passed The Wrong Type");
	}

	private void CreateBonus(Marble hitGoCache) {
		GameObject Bonus = Instantiate (GetBonusFromType(hitGoCache.Type), BottomRight +
		                                new Vector2(hitGoCache.Column * MarbleSize.x, hitGoCache.Row * MarbleSize.y),
		                                Quaternion.identity) as GameObject;

		marbles [hitGoCache.Row, hitGoCache.Column] = Bonus;

		var bonusMarble = Bonus.GetComponent<Marble> ();

		bonusMarble.Initialize (hitGoCache.Type, hitGoCache.Row, hitGoCache.Column);

		bonusMarble.Bonus = BonusType.DestroyWholeRowColumn;
	}

	private AlteredMarbleInfo CreateNewMarbleInSpecificColumns(IEnumerable<int> columnsWithMissingMarbles) {
		AlteredMarbleInfo newMarbleInfo = new AlteredMarbleInfo ();

		foreach (int column in columnsWithMissingMarbles) {
			var emptyItems = marbles.GetEmptyItemsOnColumn(column);

			foreach(var item in emptyItems) {
				var go = GetRandomMarble();

				GameObject newMarble = Instantiate(go, SpawnPositions[column], Quaternion.identity) as GameObject;

				newMarble.GetComponent<Marble>().Initialize(go.GetComponent<Marble>().Type, item.Row, item.column);

				if(GameVariables.Rows - item.Row > newMarbleInfo.maxDistance)
					newMarbleInfo.maxDistance = GameVariables.Rows - item.Row;

				marbles[item.Row, item.column] = newMarble;

				newMarbleInfo.AddMarble(newMarble);

			}

		}

		return newMarbleInfo;
	}

	private void MoveAndAnimate(IEnumerable<GameObject> movedGameObjects, int distance) {
		foreach (var item in movedGameObjects) {
			item.transform.positionTo(GameVariables.MoveAnimationDuration * distance, BottomRight
			                        + new Vector2(item.GetComponent<Marble>().Column * MarbleSize.x,
			          							item.GetComponent<Marble>().Row * MarbleSize.y));
		}

	}

	private IEnumerator FindMatchesAndCollapse(Collider2D hit2) {

		var hitGo2 = hit2.GetComponent<Collider2D>().gameObject;

		marbles.Swap (hitGo, hitGo2);

		hitGo.transform.positionTo (GameVariables.AnimationDuration, hit2.transform.position);
		hitGo2.transform.positionTo (GameVariables.AnimationDuration, hitGo.transform.position);
		yield return new WaitForSeconds (GameVariables.AnimationDuration);

		var hitGoMatchesInfo = marbles.GetMatches (hitGo);
		var hitGo2MatchesInfo = marbles.GetMatches (hitGo2);

		var totalMatches = hitGoMatchesInfo.MatchedMarbles.Union (hitGo2MatchesInfo.MatchedMarbles).Distinct ();


		if(totalMatches.Count() < GameVariables.MinimumMatches) {
			//failSwapSFX.Play ();
			hitGo.transform.positionTo (GameVariables.AnimationDuration, hitGo2.transform.position);
			hitGo2.transform.localPositionTo (GameVariables.AnimationDuration, hitGo.transform.position);
			yield return new WaitForSeconds (GameVariables.AnimationDuration);

	
			marbles.UndoSwap();

			gm.IncrementScore (Serialization.boardConfig.GENERAL_MatchValue);
			gm.DecrementGoalPanelPoints (Serialization.boardConfig.GENERAL_MatchValue);
			gm.MoveMana ();
			gm.MoveProgressIndicator ();
			gm.CheckForWin ();
		}

		bool addBonus = totalMatches.Count () >= GameVariables.MinimumMatchesForBonus &&
			!BonusTypeChecker.ContainsDestroyWholeColumn (hitGoMatchesInfo.BonusesContained) &&
			!BonusTypeChecker.ContainsDestroyWholeColumn (hitGo2MatchesInfo.BonusesContained);

		Marble hitGoCache = null;
		if (addBonus) {
			hitGoCache = new Marble ();

			var sameTypeGo = hitGoMatchesInfo.MatchedMarbles.Count () > 0 ? hitGo : hitGo2;
			var marble = sameTypeGo.GetComponent<Marble> ();

			hitGoCache.Initialize (marble.Type, marble.Row, marble.Column);
		} 

		int timesRun = 1;
		while(totalMatches.Count() >= GameVariables.MinimumMatches) {

			IncreaseScore(totalMatches.Count() - 2 * GameVariables.MatchScore);

			if(timesRun >= 2)
				IncreaseScore(GameVariables.SubsequelMatchScore);

			//successSwapSFX.Play ();
		
	
			gm.IncrementScore (Serialization.boardConfig.GENERAL_MatchValue);
			gm.DecrementGoalPanelPoints (Serialization.boardConfig.GENERAL_MatchValue);
			gm.MoveMana ();
			gm.MoveProgressIndicator ();
			gm.CheckForWin ();

			foreach(var item in totalMatches) {
				marbles.Remove(item);
				RemoveFromScene(item);
			}

			if(addBonus) {
				CreateBonus(hitGoCache);
			}

			addBonus = false;

			var columns = totalMatches.Select(go => go.GetComponent<Marble>().Column).Distinct();

			var collapsedMarbleInfo = marbles.Collapse(columns);

			var newMarbleInfo = CreateNewMarbleInSpecificColumns(columns);

			int maxDistance = Mathf.Max(collapsedMarbleInfo.maxDistance, newMarbleInfo.maxDistance);

			MoveAndAnimate(newMarbleInfo.AlteredMarble, maxDistance);
			MoveAndAnimate(collapsedMarbleInfo.AlteredMarble, maxDistance);

			yield return new WaitForSeconds(GameVariables.MoveAnimationDuration * maxDistance);

			totalMatches = marbles.GetMatches(collapsedMarbleInfo.AlteredMarble)
				.Union(marbles.GetMatches(newMarbleInfo.AlteredMarble)).Distinct();

			timesRun++;
		}

		state = GameState.None;
		StartCheckForPotentialMatches ();

	}

} // MarbleManager





































































