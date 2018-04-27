using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManagerScript : MonoBehaviour {
    public Slider Volume;
    public AudioSource MyMusic;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MyMusic.volume = Volume.value;

	}

    private void controlMusic()
    {
    }
}
