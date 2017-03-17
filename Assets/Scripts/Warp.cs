using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

	public Transform warpTarget;

	void OnTriggerEnter2D(Collider2D other) {
		//ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();

		//yield return StartCoroutine(sf.FadeToBlack());

		Debug.Log(other.name);
		if(other.CompareTag("Player")) {
			other.transform.position = warpTarget.position;
			Camera.main.transform.position = warpTarget.position;
		}


		//yield return StartCoroutine(sf.FadeToClear());
	}
}
