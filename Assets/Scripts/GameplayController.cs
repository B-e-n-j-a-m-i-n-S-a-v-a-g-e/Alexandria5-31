using UnityEngine;
using System.Collections;

public class GameplayController : MonoBehaviour {

	public void Back() {
		Application.LoadLevel ("MainMenu");
	}
}
