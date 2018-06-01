using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("PlayParticles");
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator PlayParticles() {
		ParticleSystem ps = GetComponent<ParticleSystem>();
		yield return new WaitForSeconds (5.0f);
		ps.Play ();
	}
}
