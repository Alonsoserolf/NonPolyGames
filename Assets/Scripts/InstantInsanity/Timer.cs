using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text timeText;
    private float start;
	// Use this for initialization
	void Start () {
        start = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        float now = Time.time - start;

        string min = ((int) now / 60).ToString();
        string sec = (now % 60).ToString("f2");

        timeText.text = min + ":" + sec;

	}
}
