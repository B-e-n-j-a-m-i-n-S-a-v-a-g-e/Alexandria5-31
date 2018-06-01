using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Utils : MonoBehaviour {

	private int orderNumber = 0;
	public int screenWidth;
	public int screenHeight;

	void Awake() {
		screenWidth = Screen.width;
		screenHeight = Screen.height;

		//Debug.Log ("Start in Utils: " + screenWidth);
	}

	public GameObject InstantiateObject(string id, Vector2 position) {
		//Debug.Log ("ID: " + id);
		GameObject go = Instantiate (Resources.Load (id)) as GameObject;
		go.transform.position = position;
		SetObjectOrderInLayer (go);
		return go;
	}

	public GameObject InstantiateObject(string id, Vector2 position, Vector2 scale) {
		//Debug.Log ("ID: " + id);
		GameObject go = Instantiate (Resources.Load (id)) as GameObject;
		go.transform.position = position;
		go.transform.localScale = scale;
		SetObjectOrderInLayer (go);
		return go;
	}
		
	public void SetObjectOrderInLayer(GameObject go) {
		if (go.GetComponent<SpriteRenderer> ()) {
			SpriteRenderer sr = go.GetComponent<SpriteRenderer> ();
			sr.sortingOrder = orderNumber;
			orderNumber++;
		} 
	}

	public IEnumerator MoveObject (Transform thisTransform, Vector2 startPos, Vector2 endPos, float time) {
		var i = 0.0f;
		float rate = 1.0f/time;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield return false;
		}
	}
}
