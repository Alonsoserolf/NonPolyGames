using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour {

	void Awake() {
		GameObject[] backgroundMusic = GameObject.FindGameObjectsWithTag("BackgroundMusic");
		GameObject[] MMmusic = GameObject.FindGameObjectsWithTag("MMBackgroundMusic");
		if (backgroundMusic.Length > 1 || MMmusic.Length >= 1) {
			Destroy(this.gameObject);
		}

		DontDestroyOnLoad(this.gameObject);
	}
}
