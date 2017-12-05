using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class return_to_main_menu : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void main_menu()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "cubes")
        {
            tictac_cpu_mode.mode_choice = 0;
            SceneManager.LoadScene("TicTacToeMenu");
        }
        else 
           SceneManager.LoadScene("cubes");
       
    }

}
