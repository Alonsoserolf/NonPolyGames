using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class restart_button : MonoBehaviour {
   
    
    public void restart()
    {
        tictac_cpu_mode.mode_choice = 0;
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
        if (scene.name== "cpu vs user")
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
        
     
       
        
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
