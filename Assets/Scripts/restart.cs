using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour {


	void Start () {
        gameObject.SetActive(false);
	}

    public void restartScene()
    {
        SceneManager.LoadScene("brick");
    }
	
}
