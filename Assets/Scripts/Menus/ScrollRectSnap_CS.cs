using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(AudioSource))]
public class ScrollRectSnap_CS : MonoBehaviour {

	//------image-----
	public Image exampleimage;
	public string imagetoLoad;
	//
	public RectTransform panel; // To Hold The ScrollPanel
	public Button[] bttn; //
	public RectTransform center; // CenterToCompare the distance for each button

	public int startButton = 1;

	public float[] distance; // All buttons' distances to the center;
	public float[]distReposition;
	private bool dragging = false; // Will be true while we drag the panel
	private int bttnDistance; // will hold the distance between the buttons
	public int minButtonNum = 0; //To hold the number of the button, with the smallest distance to center
	private int bttnLength;

	private bool messageSend = false;
	private float lerpSpeed = 5f;
	private bool targetNearestButton = true; // when true it will Lerp to the nearest button 

	//public Button bttncenter = false;

	//private AudioSource clickSound;
	//public AudioClip click;

	public Menu MenuLoad;

	//public float vol;

	// Use this for initialization

	void Awake(){
		//
		//clickSound.volume = vol;
	}
	void Start () {
		//clickSound = GetComponent<AudioSource> ();
		bttnLength = bttn.Length;
		distance = new float[bttnLength];
		distReposition = new float[bttnLength];

		//Get Distance between buttons

		//vertical scroll
		bttnDistance = (int)Mathf.Abs(bttn[1].GetComponent<RectTransform>().anchoredPosition.y - bttn[0].GetComponent<RectTransform>().anchoredPosition.y);
		//horizontal scroll
		//bttnDistance = (int)Mathf.Abs(bttn[1].GetComponent<RectTransform>().anchoredPosition.x - bttn[0].GetComponent<RectTransform>().anchoredPosition.x);

		//horizontalscroll
		//panel.anchoredPosition = new Vector2 ((startButton - 1) * -300, 0f);


		//vertical scroll
		panel.anchoredPosition = new Vector2 (410f,(startButton - 1) * -100);
		//print (bttnDistance);

		//Button btncenter = GameObject.FindGameObjectWithTag ("upButton").GetComponent<Button>();
		//btncenter.onClick.AddListener (() => OnUpButton (minButtonNum));
		//buttonIntereact();
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0;i<bttn.Length;i++){
			//vertical scroll
			distReposition[i] = center.GetComponent<RectTransform>().position.y - bttn[i].GetComponent<RectTransform>().position.y;

			//horizontal scroll
			//distReposition[i] = center.GetComponent<RectTransform>().position.x - bttn[i].GetComponent<RectTransform>().position.x;

			//distance [i] = Mathf.Abs (center.transform.position.x - bttn [i].transform.position.x);
			distance[i] = Mathf.Abs(distReposition[i]);

			if(distReposition[i]> 550){
				float curX = bttn [i].GetComponent<RectTransform> ().anchoredPosition.x;
				float curY = bttn [i].GetComponent<RectTransform> ().anchoredPosition.y;

				//vertical scroll
				Vector2 newAnchoredPos = new Vector2(curX,curY+(bttnLength * bttnDistance));

				//horizontal scroll
				//Vector2 newAnchoredPos = new Vector2 (curX + (bttnLength * bttnDistance),curY);

				bttn [i].GetComponent<RectTransform> ().anchoredPosition = newAnchoredPos;
			}
			if(distReposition[i] < -550){
				float curX = bttn [i].GetComponent<RectTransform> ().anchoredPosition.x;
				float curY = bttn [i].GetComponent<RectTransform> ().anchoredPosition.y;
				//vertical scroll
				Vector2 newAnchoredPos = new Vector2 (curX,curY - (bttnLength * bttnDistance));
				//horizontal scroll
				//Vector2 newAnchoredPos = new Vector2 (curX - (bttnLength * bttnDistance),curY);

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
			//vertical scroll
			LerpToBttn(-bttn[minButtonNum].GetComponent<RectTransform>().anchoredPosition.y);

			//horizontal scroll
			//LerpToBttn(-bttn[minButtonNum].GetComponent<RectTransform>().anchoredPosition.x);
		}

		//----------image----------
		buttonIntereact();

		exampleimage.sprite = (Sprite)Resources.Load<Sprite>(imagetoLoad) as Sprite;
		if (minButtonNum == 0) {
			SwitchToImage ("InstntInsimg");
		}
		if (minButtonNum == 1) {
			SwitchToImage ("ticimg");
		}
		if (minButtonNum == 2) {
			SwitchToImage ("sokabanimg");
		}
		if (minButtonNum == 3) {
			SwitchToImage ("BrickImg");
		}
		//if (minButtonNum == 4) {
		//	SwitchToImage ("snake");
		//}
		//if (minButtonNum == 5) {
		//	SwitchToImage ("puzzlebackground");
		//}
		//Button btn = bttn[0];

		//Button btncenter = GameObject.FindGameObjectWithTag ("upButton").GetComponent<Button>();
		//minButtonNum = btncenter.onClick.AddListener (() => OnUpButton (minButtonNum));

		//if(btncenter.IsActive == true){
		//	OnUpButton(minButtonNum);

		//}

		//-----------------------
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			targetNearestButton = false;
			minButtonNum = minButtonNum + 1;
			if(minButtonNum == 4){
				minButtonNum = 0;
			}
			Debug.Log("Hello Up:" + minButtonNum);
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			targetNearestButton = false;
			minButtonNum = minButtonNum - 1;
			if(minButtonNum == -1){
				minButtonNum = 3;
			}
			Debug.Log("Hello Up:" + minButtonNum);
		}
		if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) {
		//if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetMouseButtonDown(0)) {

			//clickSound.clip = click;
		
			//clickSound.Play ();

			//clickSound.PlayOneShot(click, 1.0f);


			//Debug.Log ("soundPlayed");
			if (minButtonNum == 0) {
				MenuLoad.OnInstantInsanity ();
				//SceneManager.LoadScene ("InstantScrollingbackground");
			}
			if (minButtonNum == 1) {
				MenuLoad.OnToTicTacToe ();
				//SceneManager.LoadScene ("TicTacToeScrollingbackground");
			}
			if (minButtonNum == 2) {
				MenuLoad.OnToSokaban ();
			}
			if (minButtonNum == 3) {
				MenuLoad.OnBlock ();
			}
			//if (minButtonNum == 4) {
			//	MenuLoad.OnSnake ();
			//}

		}

	}// end of update method

	//----------imageloading method

	//----------- up and down arrow method
	//public void OnUpButton(int minButNum){
	//	minButtonNum = minButNum + 1;
	//	Debug.Log("Hello Up:" + minButtonNum);

		//return minButNum;
	//}

	public void OnDownButton(){
		targetNearestButton = false;
		minButtonNum = minButtonNum + 1;
		if(minButtonNum == 4){
			minButtonNum = 0;
		}
		Debug.Log("Hello Up:" + minButtonNum);
	}
	//------------end of up and down arrow method
	void SwitchToImage(string imageLoading){
		exampleimage.sprite = (Sprite)Resources.Load<Sprite>(imageLoading) as Sprite;
	}
	//---------
	//-------
	//-------
	void LerpToBttn(float position){
		//vertical scroll
		//float newX = Mathf.Lerp (panel.anchoredPosition.y,position,Time.deltaTime*lerpSpeed);
		float newY = Mathf.Lerp(panel.anchoredPosition.y,position,Time.deltaTime*lerpSpeed);

		//horizontal scroll
		//float newX = Mathf.Lerp (panel.anchoredPosition.x,position,Time.deltaTime*lerpSpeed);	//maybe 10

		//vertical scroll
		if(Mathf.Abs(position - newY) < 3f){
		//horizontal scroll
		//if(Mathf.Abs(position - newX) < 3f){

			//lerpSpeed = 25f;

			//horizontal scroll
			//newX = position;

			//Vertical scroll
			newY = position;

		}
		//vertical scroll
		if(Mathf.Abs(newY)>= Mathf.Abs(position)-1f && Mathf.Abs(newY) <= Mathf.Abs(position)+1 && !messageSend){
		//horizontal scroll
		//if(Mathf.Abs(newX)>= Mathf.Abs(position)-1f && Mathf.Abs(newX) <= Mathf.Abs(position)+1 && !messageSend){
			messageSend = true;
			//Debug.Log ("Message Send : " + bttn[minButtonNum].name);
			SendMessageFromButton(minButtonNum);
		}
		//vertical scroll
		Vector2 newPosition = new Vector2 (panel.anchoredPosition.x,newY);

		//horizontal scroll
		//Vector2 newPosition = new Vector2 (newX,panel.anchoredPosition.y);

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
	public void OnUpButton1(){
		targetNearestButton = false;
		minButtonNum = minButtonNum - 1;
		if(minButtonNum == -1){
			minButtonNum = 3;
		}
		Debug.Log("Hello Up:" + minButtonNum);

		//return minButNum;
	}
	public void buttonIntereact(){
		for(int i = 0;i<=3; i++){
			
			bttn [i].interactable = false;
			var colorblock= bttn [i].colors;
			colorblock.disabledColor = new Color32(200,200,200,128);
			bttn [i].colors = colorblock;

			bttn [minButtonNum].interactable = true;
			var newColorbloc = bttn [minButtonNum].colors;
			newColorbloc.disabledColor = new Color32(255,255,255,255);
			bttn [minButtonNum].colors = newColorbloc;
			//bttn[minButtonNum].colors = 
		}
		//bttn [minButtonNum].interactable = true;
	}
}
