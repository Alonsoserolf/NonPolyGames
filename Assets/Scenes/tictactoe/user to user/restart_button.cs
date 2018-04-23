using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class restart_button : MonoBehaviour {
   
    
    public void restart()
    {
       
		StartCoroutine (LoadingLevelrestart ());

        /*Scene scene = SceneManager.GetActiveScene();
       
        if (scene.name== "cpu vs user")
        {
            tictac_cpu_mode.mode_choice = 0;
            SceneManager.LoadScene("cpu vs user");
        }
        else
        {
            tictac.mode_choice_func();
            SceneManager.LoadScene("secondlevel");
        }
        
       */
        
    }

	IEnumerator LoadingLevelrestart(){
		yield return new WaitForSeconds(1f);
		Scene scene = SceneManager.GetActiveScene();

		if (scene.name== "cpu vs user")
		{
			tictac_cpu_mode.mode_choice = 0;
			SceneManager.LoadScene("cpu vs user");
		}
		else
		{
			tictac.mode_choice_func();
			SceneManager.LoadScene("secondlevel");
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
