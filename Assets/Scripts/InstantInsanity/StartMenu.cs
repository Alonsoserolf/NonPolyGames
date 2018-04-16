using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class StartMenu : MonoBehaviour {
    private GameObject canvas;
    private GameObject stak;
    private GameObject camera;
    public Transform cubePrefab;
    GameObject cmr;
    GameObject mainCmr;
    private Text stackSize;
    private int sSize;
    private Vector3 _LocalRotation;
    public Toggle[] cLvl;
    public Text countCubes;
    int yPos,zPos, xPos;
    private int selectedLevel;

    private bool IsOn=false;

    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("Canvas");
        stak = GameObject.FindWithTag("Stak");
        camera = GameObject.FindWithTag("MainCamera");

    }
    public void ChooseLvl()
    {
       // int tar = Int32.Parse(this.gameObject.transform.name);
       // selectedLevel = int.Parse(GameObject.FindWithTag("II_MENU_STACK_SEL").GetComponent<Text>().text);
      //  if (tar<selectedLevel)
       //     this.gameObject.transform.GetComponent<Toggle>().isOn = true;

    }
    public void CheLvl()
    {
       // int tar = Int32.Parse(this.gameObject.transform.name);
       // selectedLevel = int.Parse(GameObject.FindWithTag("II_MENU_STACK_SEL").GetComponent<Text>().text);
      //  if (tar>selectedLevel)
      //  this.gameObject.transform.GetComponent<Toggle>().isOn = false;

    }
    public void go_play()
    {
        //height
        int tar = Int32.Parse(this.gameObject.transform.name);
        selectedLevel = tar;
        stackSize = GameObject.FindWithTag("II_MENU_STACK_SEL").GetComponent<Text>();
        stackSize.text = selectedLevel.ToString();
        for (int i = tar + 1; i < 12; i++)
        {
            cLvl[i].isOn = false;
        }
        for (int i = tar-1; i>=0; i--)
        {
            cLvl[i].isOn = true;
        }

    }
    public void Comence()
    {

        //What is this using?
        stackSize = GameObject.FindWithTag("II_MENU_STACK_SEL").GetComponent<Text>();
        int cubeNum = 3;
        cubeNum= int.Parse(stackSize.text);

        GameObject makeChild;
        GameObject[] sidesCube;

       
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
}
