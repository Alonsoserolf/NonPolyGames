using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour {

    //private GameObject[] iiStack;
    GameObject actionWomanager;
    public GameObject cubeSelected;
    bool cubSelected = false;

    /*private void Start () {
        //actionWomanager = GameObject.FindWithTag("CubeOne");

        //canvas.gameObject.SetActive(false);
    }*/


    private void Update()
    {

        //OnMouseDown();
        ChangeCube();
    }



    public void ChangeCube()
    {
        //Destroy(gameObject);

       /* if (gameObject.GetComponent<CubeBehavior>().isActiveAndEnabled)
        {
            gameObject.GetComponent<CubeBehavior>().enabled = false;

        }
        else
            gameObject.GetComponent<CubeBehavior>().enabled=true;

    */
        print("jk");

    }
}
