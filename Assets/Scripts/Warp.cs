using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

	public Transform warpTarget;
	public float cooldownTime;

	void OnTriggerEnter2D(Collider2D other) {
		//ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();

		//yield return StartCoroutine(sf.FadeToBlack());

		Debug.Log(other.name);
		if(other.CompareTag("Player") && other.GetComponent<PlayerMovement>().warpCooldown <= 0) {
			other.GetComponent<PlayerMovement>().warpCooldown = cooldownTime;
			other.transform.position = warpTarget.position;
			Camera.main.transform.position = warpTarget.position;
		}


		//yield return StartCoroutine(sf.FadeToClear());
	}

}
