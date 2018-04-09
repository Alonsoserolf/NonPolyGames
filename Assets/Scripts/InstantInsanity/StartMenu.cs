using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour {
    private GameObject canvas;
    private GameObject stak;
    public Slider mainSlider;
    private GameObject camera;
    public Transform cubePrefab;
    GameObject cmr;
    GameObject mainCmr;
    private Vector3 _LocalRotation;
    public GameObject[] cLvl;
    public Text countCubes;
    int yPos,zPos, xPos;


    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("Canvas");
        stak = GameObject.FindWithTag("Stak");

        camera = GameObject.FindWithTag("MainCamera");

        cLvl = new GameObject[15];
    }
    public void ChooseLvl()
    {

        print(this.gameObject.transform.childCount);
       // print(cLvl[2].transform.childCount);
        
    }
    public void Comence()
    {
        
        //What is this using?
        countCubes = GameObject.FindWithTag("countcubes").GetComponent<Text>();
        int cubeNum = 3;
            cubeNum= int.Parse(countCubes.text);

        int randColor;
        GameObject makeChild;
        GameObject[] sidesCube;

        if (canvas.activeInHierarchy != false)
        {
            for (int i = 0; i < cubeNum; i++)
            {
                sidesCube = new GameObject[transform.childCount];
                //instantiate cubes
                makeChild = Instantiate(cubePrefab.gameObject, new Vector3(0, i, 0), Quaternion.identity) as GameObject;
                //add a script(CubeBehavior) to each cube and disable it
                makeChild.AddComponent<CubeBehavior>();
                makeChild.GetComponent<CubeBehavior>().enabled = false;

                sidesCube = new GameObject[makeChild.transform.childCount];

                makeChild.transform.parent = GameObject.Find("Stack").transform;
            }


            canvas.SetActive(false);
            //set camerascript on
            camera.GetComponent<RotateStak>().enabled = true;
            //set cube rotation on
            stak.GetComponent<TheStak>().enabled = true;

        }
        else
        {
            //set camerascript off
            camera.GetComponent<RotateStak>().enabled = false;
            //set cube rotation off
            canvas.SetActive(true);
        }

    }
}
