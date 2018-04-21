using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour {


	public Texture2D mouseTexture;
	public CursorMode curMode = CursorMode.Auto;
	public Vector2 hotspot = Vector2.zero;
	public Vector2 hotspotsize;
	// Use this for initialization
	void Start () {
		hotspotsize = new Vector2 (mouseTexture.width*0.1f,mouseTexture.height*0.1f);
		Cursor.SetCursor (mouseTexture,hotspotsize,curMode);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
