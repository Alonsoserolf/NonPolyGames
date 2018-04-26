using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settingss : MonoBehaviour {
    public Toggle isAct;
    public bool isA=true;
	// Use this for initialization
	void Start () {
        isA = !isA;
    }
	
	// Update is called once per frame
	void Update () {
	}
    public void SetCntrl()
    {
        isA = isAct.isOn;
    }
}
