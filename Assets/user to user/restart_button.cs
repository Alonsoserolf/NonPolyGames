using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class restart_button : MonoBehaviour {
   
    
    public void restart()
    {
        
        SceneManager.LoadScene(1);
        tictac.mode_choice_func();
       
        
    }


    
    


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



    }
    void Awake()
    {
        
    }

}
