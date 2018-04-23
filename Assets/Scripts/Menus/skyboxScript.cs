using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxScript : MonoBehaviour {

	public float speedMulitplier;
	// Use this for initialization
	void Start () {
		//transform.Rotate (0, 0, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		RenderSettings.skybox.SetFloat ("_Rotation",Time.time * speedMulitplier);
		//if(OnApplicationQuit()==false ){
		//}
	}
	//void resetRotation(){
		//transform.Rotate (0, 0, 0);

	//}
}
