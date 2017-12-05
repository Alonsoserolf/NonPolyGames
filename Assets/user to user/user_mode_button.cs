using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class user_mode_button : MonoBehaviour {
    
    public void second_screen()
    {

        SceneManager.LoadScene("secondlevel");
        tictac.mode_choice_func();

    }


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
