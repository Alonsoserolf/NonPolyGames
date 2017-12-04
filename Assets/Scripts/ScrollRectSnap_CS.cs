using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectSnap_CS : MonoBehaviour {

	public RectTransform panel; // To Hold The ScrollPanel
	public Button[] bttn; //
	public RectTransform center; // CenterToCompare the distance for each button

	public int startButton = 1;

	public float[] distance; // All buttons' distances to the center;
	public float[]distReposition;
	private bool dragging = false; // Will be true while we drag the panel
	private int bttnDistance; // will hold the distance between the buttons
	private int minButtonNum; //To hold the number of the button, with the smallest distance to center
	private int bttnLength;

	private bool messageSend = false;
	private float lerpSpeed = 5f;
	private bool targetNearestButton = true; // when true it will Lerp to the nearest button 

	// Use this for initialization
	void Start () {
		bttnLength = bttn.Length;
		distance = new float[bttnLength];
		distReposition = new float[bttnLength];

		//Get Distance between buttons
		bttnDistance = (int)Mathf.Abs(bttn[1].GetComponent<RectTransform>().anchoredPosition.x - bttn[0].GetComponent<RectTransform>().anchoredPosition.x);

		panel.anchoredPosition = new Vector2 ((startButton - 1) * -300, 0f);
		//print (bttnDistance);
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0;i<bttn.Length;i++){
			distReposition[i] = center.GetComponent<RectTransform>().position.x - bttn[i].GetComponent<RectTransform>().position.x;
			//distance [i] = Mathf.Abs (center.transform.position.x - bttn [i].transform.position.x);
			distance[i] = Mathf.Abs(distReposition[i]);

			if(distReposition[i]>2700){
				float curX = bttn [i].GetComponent<RectTransform> ().anchoredPosition.x;
				float curY = bttn [i].GetComponent<RectTransform> ().anchoredPosition.y;

				Vector2 newAnchoredPos = new Vector2 (curX + (bttnLength * bttnDistance),curY);
				bttn [i].GetComponent<RectTransform> ().anchoredPosition = newAnchoredPos;
			}
			if(distReposition[i] < -2700){
				float curX = bttn [i].GetComponent<RectTransform> ().anchoredPosition.x;
				float curY = bttn [i].GetComponent<RectTransform> ().anchoredPosition.y;

				Vector2 newAnchoredPos = new Vector2 (curX - (bttnLength * bttnDistance),curY);
				bttn [i].GetComponent<RectTransform> ().anchoredPosition = newAnchoredPos;
			}
		}

		if (targetNearestButton) {
			
			float minDistance = Mathf.Min (distance); //Get the Min Distance
			for (int a = 0; a < bttn.Length; a++) {
				if (minDistance == distance [a]) {
					minButtonNum = a;

					//Debug.Log (bttn[minButtonNum].name);
				}
			}
		}
		if(!dragging){
			//LerpToBttn (minButtonNum * -bttnDistance);
			LerpToBttn(-bttn[minButtonNum].GetComponent<RectTransform>().anchoredPosition.x);
		}
	}
	void LerpToBttn(float position){
		float newX = Mathf.Lerp (panel.anchoredPosition.x,position,Time.deltaTime*lerpSpeed);	//maybe 10

		if(Mathf.Abs(position - newX) < 3f){
			//lerpSpeed = 25f;
			newX = position;

		}

		if(Mathf.Abs(newX)>= Mathf.Abs(position)-1f && Mathf.Abs(newX) <= Mathf.Abs(position)+1 && !messageSend){
			messageSend = true;
			//Debug.Log ("Message Send : " + bttn[minButtonNum].name);
			SendMessageFromButton(minButtonNum);
		}

		Vector2 newPosition = new Vector2 (newX,panel.anchoredPosition.y);

		panel.anchoredPosition = newPosition;
	}
	public void SendMessageFromButton(int bttnIndex){
		if(bttnIndex -1 == 3){ // when on button 4 send message
			Debug.Log ("Message Send");
		}
	}

	public void StartDrag(){
		
		messageSend = false;
		lerpSpeed = 5f;
		dragging = true;

		targetNearestButton = true;
	}
	public void EndDrag(){
		dragging = false;
	}
	public void GoToButton(int buttonIndex){
		targetNearestButton = false; // stop lerping to the nearest button
		minButtonNum = buttonIndex -1;
	}
}
