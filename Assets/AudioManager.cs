using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

//[RequireComponent(typeof(Button))]
public class AudioManager : MonoBehaviour
{

    public AudioSource clickSound;
    public AudioClip click;
}
	/*public float volume;


	private Button button{get{return GetComponent<Button> (); }}
	private AudioSource source{get{return GetComponent<AudioSource> (); }}
	// Use this for initialization
	void Start () {
		clickSound = GetComponent<AudioSource> ();
		clickSound.clip = click;

		clickSound.Play ();
		gameObject.AddComponent<AudioSource> ();
		source.clip = click;
		source.playOnAwake = false;
		//button.onClick.AddListener (() => PlaySound ());
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetMouseButtonDown(0)) {

			clickSound.clip = click;

			clickSound.Play ();

			clickSound.PlayOneShot(click, 1.0f);


			Debug.Log ("soundPlayed");
	}
	public void PlayOnSound(){
		clickSound.PlayOneShot (click);
	}

}
}*/
