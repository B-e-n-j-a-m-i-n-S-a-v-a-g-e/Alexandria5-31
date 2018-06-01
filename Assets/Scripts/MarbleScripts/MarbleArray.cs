using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class MarbleArray {

	GameObject[,] marbles = new GameObject[GameVariables.Rows, GameVariables.Columns];

	private GameObject backup1;
	private GameObject backup2;
	public MarbleManager marbleManager;

	public GameObject this[int row, int column] {
		get {
			try {
				return marbles[row, column];
			} catch(Exception e) {
				throw;
			}
		}

		set {
			marbles[row, column] = value;
		}
	}

	public void Swap(GameObject g1, GameObject g2) {

		backup1 = g1;
		backup2 = g2;

		var g1Marble = g1.GetComponent<Marble> ();
		var g2Marble = g2.GetComponent<Marble> ();

		int g1Row = g1Marble.Row;
		int g1Column = g1Marble.Column;
		int g2Row = g2Marble.Row;
		int g2Column = g2Marble.Column;

		var temp = marbles [g1Row, g1Column];
		marbles [g1Row, g1Column] = marbles [g2Row, g2Column];
		marbles [g2Row, g2Column] = temp;

		Marble.SwapRowColumn (g1Marble, g2Marble);

	}

	public void UndoSwap() {
		Swap (backup1, backup2);
	}

	private IEnumerable<GameObject> GetMatchesHorizontally(GameObject go) {
		List<GameObject> matches = new List<GameObject> ();
		matches.Add (go);

		var marble = go.GetComponent<Marble> ();

		if (marble.Column != 0) {
			for(int column = marble.Column - 1; column >= 0; column--) {
				if(marbles[marble.Row, column].GetComponent<Marble>().IsSameType(marble)) {
					matches.Add(marbles[marble.Row, column]);
				} else {
					break;
				}
			}
		} // search left

		if (marble.Column != GameVariables.Columns - 1) {
			for(int column = marble.Column + 1; column < GameVariables.Columns; column++) {
				if(marbles[marble.Row, column].GetComponent<Marble>().IsSameType(marble)) {
					matches.Add(marbles[marble.Row, column]);
				} else {
					break;
				}
			}
		} // search right

		if (matches.Count < GameVariables.MinimumMatches) {
			matches.Clear();
		}

		return matches.Distinct ();

	}

	private IEnumerable<GameObject> GetMatchesVertically(GameObject go) {
		List<GameObject> matches = new List<GameObject> ();
		matches.Add (go);
		
		var marble = go.GetComponent<Marble> ();

		if (marble.Row != 0) {
			for(int row = marble.Row - 1; row >= 0; row--) {
				if(marbles[row, marble.Column].GetComponent<Marble>().IsSameType(marble)) {
					matches.Add(marbles[row, marble.Column]);
				} else {
					break;
				}
			}
		} // search bottom

		if (marble.Row != GameVariables.Rows - 1) {
			for(int row = marble.Row + 1; row < GameVariables.Rows; row++) {
				if(marbles[row, marble.Column].GetComponent<Marble>().IsSameType(marble)) {
					matches.Add(marbles[row, marble.Column]);
				} else {
					break;
				}
			}
		} // search top

		if (matches.Count < GameVariables.MinimumMatches) {
			matches.Clear();
		}
		
		return matches.Distinct ();

	}

	private bool ContainsDestroyWholeRowColumnBonus(IEnumerable<GameObject> matches) {
		if(matches.Count() >= GameVariables.MinimumMatches) {
			foreach(var item in matches) {
				if(BonusTypeChecker.ContainsDestroyWholeColumn(item.GetComponent<Marble>().Bonus)) {
					return true;
				}
			}
		}
		return false;
	}

	private IEnumerable<GameObject> GetEntireRow(GameObject go) {
		List<GameObject> matches = new List<GameObject> ();
		int row = go.GetComponent<Marble> ().Row;
		for (int column = 0; column < GameVariables.Columns; column++) {
			matches.Add (marbles[row, column]);
		}
		return matches;
	}

	private IEnumerable<GameObject> GetEntireColumn(GameObject go) {
		List<GameObject> matches = new List<GameObject> ();
		int column = go.GetComponent<Marble> ().Column;
		for (int row = 0; row < GameVariables.Rows; row++) {
			matches.Add (marbles[row, column]);
		}
		return matches;
	}

	public void Remove(GameObject item) {
		marbles [item.GetComponent<Marble> ().Row, item.GetComponent<Marble> ().Column] = null;
	}

	public AlteredMarbleInfo Collapse(IEnumerable<int> columns) {
		AlteredMarbleInfo collapseInfo = new AlteredMarbleInfo ();

		foreach (var column in columns) {
			for(int row = 0; row < GameVariables.Rows - 1; row++) {
				if(marbles[row, column] == null) {

					for(int row2 = row + 1; row2 < GameVariables.Rows; row2++) {

						if(marbles[row2, column] != null) {

							marbles[row, column] = marbles[row2, column];
							marbles[row2, column] = null;

							if(row2 - row > collapseInfo.maxDistance)
								collapseInfo.maxDistance = row2 - row;

							marbles[row, column].GetComponent<Marble>().Row = row;
							marbles[row, column].GetComponent<Marble>().Column = column;

							collapseInfo.AddMarble(marbles[row, column]);
							break;
						}

					}

				}
			}	
		}

		return collapseInfo;
	}

	public IEnumerable<MarbleInfo> GetEmptyItemsOnColumn(int column) {
		List<MarbleInfo> emptyItems = new List<MarbleInfo> ();

		for(int row = 0; row < GameVariables.Rows; row++) {
			if(marbles[row, column] == null) {
				emptyItems.Add(new MarbleInfo() {Row = row, column = column});
			}
		}

		return emptyItems;
	}

	public MatchesInfo GetMatches(GameObject go) {
		MatchesInfo matchesInfo = new MatchesInfo ();

		var horizontalMatches = GetMatchesHorizontally (go);
		if (ContainsDestroyWholeRowColumnBonus (horizontalMatches)) {
			horizontalMatches = GetEntireRow(go);

			if(!BonusTypeChecker.ContainsDestroyWholeColumn(matchesInfo.BonusesContained)) {
				matchesInfo.BonusesContained = BonusType.DestroyWholeRowColumn;
			}
		}
		matchesInfo.AddObjectRange (horizontalMatches);

		var verticalMatches = GetMatchesVertically (go);
		if (ContainsDestroyWholeRowColumnBonus (verticalMatches)) {
			horizontalMatches = GetEntireColumn(go);
			
			if(!BonusTypeChecker.ContainsDestroyWholeColumn(matchesInfo.BonusesContained)) {
				matchesInfo.BonusesContained = BonusType.DestroyWholeRowColumn;
			}
		}
		matchesInfo.AddObjectRange (verticalMatches);

		return matchesInfo;
	}

	public IEnumerable<GameObject> GetMatches(IEnumerable<GameObject> gos) {
		List<GameObject> matches = new List<GameObject> ();
		foreach (var go in gos) {
			matches.AddRange(GetMatches(go).MatchedMarbles);
		}
		return matches.Distinct ();
	}


} // MarbleArray



























































