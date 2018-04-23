using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxScript : MonoBehaviour {

	public float speedMulitplier;
	// Use this for initialization
	void Start () {
		//speedMulitplier = 0.0F;
		//transform.Rotate (0, 0, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		//speedMulitplier = (speedMulitplier + 5.0F) % 360F;
		RenderSettings.skybox.SetFloat ("_Rotation",0F * speedMulitplier);
		//RenderSettings.skybox.SetFloat ("_Rotation",Time.time * speedMulitplier);
		//if(OnApplicationQuit()==false ){
		//}
	}
	//void resetRotation(){
		//transform.Rotate (0, 0, 0);

	//}
	//void OnApplicationQuit(){
	//	transform.Rotate (0,0,0);
	//}
}
