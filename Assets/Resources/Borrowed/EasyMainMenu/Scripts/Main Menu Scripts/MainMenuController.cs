/*This script was modified from EASY MAIN MENU 
 * a group of assets free from Asset store
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class MainMenuController : MonoBehaviour {

    Animator anim;

    private GameObject canvas;
    private GameObject stak;
    private GameObject camera;
    public Toggle[] cLvl;
    public Transform cubePrefab;
    private Text stackSize;
    private int selectedLevel;
    private bool IsOn = false;

    [Header("Options Panel")]
    public GameObject _info;
    public GameObject _help;
    public GameObject _controls;
    public GameObject _ShowCube;
    public GameObject MainOptionsPanel;
    public GameObject StartGameOptionsPanel;
    public GameObject GamePanel;
    public GameObject ControlsPanel;
    public GameObject GfxPanel;
    public GameObject LoadGamePanel;
    private int lastClicked, howTo=0, inGameSettingsToggle=0;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        //new key
        //PlayerPrefs.SetInt("quickSaveSlot", quickSaveSlotID);
        canvas = GameObject.FindWithTag("Canvas");
        stak = GameObject.FindWithTag("Stak");
        camera = GameObject.FindWithTag("MainCamera");
    }
    public void ExpandHowTo()
    {
        howTo = (howTo == 0) ? 1 : 0;

        if (howTo == 0) anim.Play("expndHowTo_off");
        else anim.Play("expndHowTo_on");
    }

    //#region Open Different panels
    public void OpenInfo()
    {
        _help.SetActive(false);
        _controls.SetActive(false);
        _ShowCube.SetActive(true);
        _info.SetActive(true);
        anim.SetBool("SHWANS", true);


    }
    public void OpenHelp()
    {
        _controls.SetActive(false);
        _info.SetActive(false);
        _ShowCube.SetActive(false);
        _help.SetActive(true);

    }
    public void OpenControls()
    {
        _help.SetActive(false);
        _info.SetActive(false);
        _ShowCube.SetActive(false);
        _controls.SetActive(true);
        anim.SetBool("SHWANS", true);


    }

    public void Comence()
    {

        //What is this using?
        stackSize = GameObject.FindWithTag("II_MENU_STACK_SEL").GetComponent<Text>();
        int cubeNum = 2;
        cubeNum = int.Parse(stackSize.text) + 1;

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


        //canvas.SetActive(false);
        anim.SetFloat("Start",1);
       // anim.Play("II_Start_Anim");
        //set camerascript on
        camera.GetComponent<RotateStak>().enabled = true;
        //set cube rotation on
        stak.GetComponent<TheStak>().enabled = true;

    }

    public void OpenInGameSettings()
    {
        inGameSettingsToggle = ( inGameSettingsToggle == 0) ? 1 : 0;

        if (inGameSettingsToggle == 1)
        {
            stak.SetActive(false);
            anim.Play("openSettings");
            camera.GetComponent<RotateStak>().enabled = false;
        }
        else
        {
            anim.Play("closeSettings");
            stak.SetActive(true);
            camera.GetComponent<RotateStak>().enabled = true;
        }
    }
  
    public void BackToStart()
    {
        SceneManager.LoadScene("InstantInsanity");
        //print("Restart SCENE");
    }
    public void BackToScrollingMenu()
    {
        SceneManager.LoadScene("ScrollingMainMenu");
        //print("Restart SCENE");
    }
}
