﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class restart_scene : MonoBehaviour {
   
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
       


    }
    public void  restart()
    {
        SceneManager.LoadScene("cubes");
    }

} 