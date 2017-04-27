using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour {

	AudioSource audioSource;
	public AudioClip[] audioClips;
	public string[] scenesToChange;
	public int audioPlaying = 0;

	static bool AudioBegin = false; 
 	void Start()
	{
		audioSource = GetComponent<AudioSource>();
		if (!AudioBegin) {
			audioSource.Play();
			DontDestroyOnLoad (transform.gameObject);
			AudioBegin = true;
		} 
	}
	void Update () {
    	for(int i = 1; i<scenesToChange.Length+1; i++) {
			if(audioPlaying != i && SceneManager.GetActiveScene().name == scenesToChange[i-1] && audioClips[i-1]) {
				audioSource.Stop();
    			audioSource.clip = audioClips[i-1];
    			audioPlaying = i;
    			audioSource.Play();
    		}
 		}
	}
}