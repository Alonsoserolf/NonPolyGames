using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour {
    private GameObject canvas;
    private GameObject stak;
    public Slider mainSlider;
    private GameObject slide;
    public Transform cubePrefab;
    

    public Text countCubes;



    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("Canvas");
        stak = GameObject.FindWithTag("Stak");
        slide = GameObject.FindWithTag("CubNum");
    }

    // Update is called once per frame
    void Update () {

        if (canvas.activeInHierarchy != false)
        {
            countCubes = GameObject.FindWithTag("countcubes").GetComponent<Text>();
            countCubes.text = Mathf.Floor((slide.GetComponent<Slider>().value * 10) + 4).ToString();
        }
    }

    public void Comence()
    {
        float cubeNum = Mathf.Floor((slide.GetComponent<Slider>().value * 10) + 4);
        GameObject makeChild;
        GameObject[] sidesCube;
        int randColor;
        if (canvas.activeInHierarchy == false)
        {
            canvas.SetActive(true);
        }
        else
        {

            for(int i = 0; i < cubeNum; i++)
            {
                sidesCube= new GameObject[transform.childCount];
                //instantiate cubes
                makeChild = Instantiate(cubePrefab.gameObject, new Vector3(0, i, 0), Quaternion.identity) as GameObject;
                //add a script(CubeBehavior) to each cube and disable it
                makeChild.AddComponent<CubeBehavior>();
                makeChild.GetComponent<CubeBehavior>().enabled = false;

                sidesCube = new GameObject[makeChild.transform.childCount];
               
                makeChild.transform.parent = GameObject.Find("Stack").transform;
            }


            canvas.SetActive(false);
            stak.GetComponent<TheStak>().enabled = true;

        }
    }
    
}
