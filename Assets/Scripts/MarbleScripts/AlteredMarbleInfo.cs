using UnityEngine;
using System.Collections.Generic;	
using System.Linq;

public class AlteredMarbleInfo {

	private List<GameObject> newMarble;
	public int maxDistance { get; set; }

	public AlteredMarbleInfo() {
		newMarble = new List<GameObject> ();
	}

	public IEnumerable<GameObject> AlteredMarble {
		get {
			return newMarble.Distinct();
		}
	}
	public void AddMarble(GameObject go) {
		if (!newMarble.Contains (go)) {
			newMarble.Add (go);
		}
	}
}
