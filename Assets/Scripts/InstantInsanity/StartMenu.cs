using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/*
 *This script controls level select
 */

public class StartMenu : MonoBehaviour {
    private GameObject canvas;
    private GameObject stak;
    private GameObject camera;
    public Toggle[] cLvl;
    public Transform cubePrefab;
    private Text stackSize;
    private Text menuCubeNum;
    private Text menuRotations;
    private Text menuRotationsHalf;

    private int selectedLevel;
    private bool IsOn=false;
    private String[] rot = new String[] { "0", "24", "576", "1.38 x10^4", "3.32 x10^5", "7.96 x10^6",  "1.91 x10^8", "4.59 x10^9", "1.10 x10^11", "2.64 x10^12", "6.34 x10^13", "1.52 x10^15", "3.65 x10^16" };
    private String[] rotHalf = new String[] { "0", "12", "288", "6,912", "1.66 x10^5", "3.98 x10^6",  "9.56 x10^7", "2.29 x10^9", "5.50 x10^11", "1.32 x10^12", "3.17 x10^13", "7.61 x10^14", "7.61 x10^15"};

    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("Canvas");
        stak = GameObject.FindWithTag("Stak");
        camera = GameObject.FindWithTag("MainCamera");

    }
   
    public void go_play()
    {
        //height
        int tar = Int32.Parse(this.gameObject.transform.name);
        selectedLevel = tar;
        stackSize = GameObject.FindWithTag("II_MENU_STACK_SEL").GetComponent<Text>();
        menuCubeNum = GameObject.FindWithTag("menuCubeNum").GetComponent<Text>();
        menuRotations= GameObject.FindWithTag("menuRotations").GetComponent<Text>();
        menuRotationsHalf = GameObject.FindWithTag("menuRotationsHalf").GetComponent<Text>();

        stackSize.text = selectedLevel.ToString();
        selectedLevel += 1;
        menuCubeNum.text = selectedLevel.ToString();
        menuRotations.text = rot[selectedLevel];
        menuRotationsHalf.text  = rotHalf[selectedLevel];

       // if (tar != cLvl.Length - 1 && cLvl[tar + 1].isOn) cLvl[tar].isOn = false;
        //else cLvl[tar].isOn = false;
        cLvl[tar].isOn = false;
        for (int i = tar; i <= 10; i++)
        {
            cLvl[i+1].isOn = false;
        }
        for (int i = tar; i>0; i--)
        {

            cLvl[i-1].isOn = true;
        }

    }
}
