using UnityEngine;
using System.Collections;

public class Marble : MonoBehaviour {

	public BonusType Bonus { get; set;}
	public int Row { get; set;}
	public int Column { get; set;}

	public string Type {get; set;}

	public Marble() {
		Bonus = BonusType.None;
	}

	public bool IsSameType(Marble otherMarble) {
		return string.Compare (this.Type, otherMarble.Type) == 0;
	}

	public void Initialize(string type, int row, int column) {
		Column = column;
		Row = row;
		Type = type;
	}

	public static void SwapRowColumn(Marble m1, Marble m2) {

		int temp = m1.Row;
		m1.Row = m2.Row;
		m2.Row = temp;

		temp = m1.Column;
		m1.Column = m2.Column;
		m2.Column = temp;
	}
}
