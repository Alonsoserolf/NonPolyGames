using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour {

	void Awake() {
		GameObject[] backgroundMusic = GameObject.FindGameObjectsWithTag("BackgroundMusic");
		GameObject[] MMmusic = GameObject.FindGameObjectsWithTag("MMBackgroundMusic");
		if (backgroundMusic.Length > 1) {
			Destroy(this.gameObject);
		} else if (MMmusic.Length >= 1) {
			Destroy(backgroundMusic[0]);
		} else {
			DontDestroyOnLoad(this.gameObject);
		}
	}
}
