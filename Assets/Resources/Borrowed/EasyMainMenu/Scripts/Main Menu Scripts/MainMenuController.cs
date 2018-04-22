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

    public string newGameSceneName;
    public int quickSaveSlotID;

    private GameObject canvas;
    private GameObject stak;
    private GameObject camera;
    public Toggle[] cLvl;
    public Transform cubePrefab;
    private Text stackSize;
    private int selectedLevel;
    private bool IsOn = false;

    [Header("Options Panel")]
    public GameObject MainOptionsPanel;
    public GameObject StartGameOptionsPanel;
    public GameObject GamePanel;
    public GameObject ControlsPanel;
    public GameObject GfxPanel;
    public GameObject LoadGamePanel;
    private int lastClicked, howTo=0;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

        //new key
        PlayerPrefs.SetInt("quickSaveSlot", quickSaveSlotID);

        canvas = GameObject.FindWithTag("Canvas");
        stak = GameObject.FindWithTag("Stak");
        camera = GameObject.FindWithTag("MainCamera");
    }
    public void ExpandHowTo()
    {

        howTo = (howTo == 0) ? 1 : 0;

        if (howTo == 0) anim.Play("expndHowTo");
        else anim.Play("expndHowTo_on");

    }
    public void ExpandHowTo_on()
    {
        print("lek");
        anim.Play("expndHowTo_on");
    }
    #region Open Different panels

    public void openOptions()
    {
        //enable respective panel
        MainOptionsPanel.SetActive(true);
       // StartGameOptionsPanel.SetActive(false);

        //play anim for opening main options panel
        anim.Play("buttonTweenAnims_on");

        //play click sfx
        playClickSound();
               
    }

    public void openStartGameOptions()
    {
        //enable respective panel
        MainOptionsPanel.SetActive(false);
        StartGameOptionsPanel.SetActive(true);

        //play anim for opening main options panel
        anim.Play("buttonTweenAnims_on");

        //play click sfx
        playClickSound();

        //enable BLUR
        //Camera.main.GetComponent<Animator>().Play("BlurOn");
        
    }

    public void openOptions_Game()
    {
        //enable respective panel
        GamePanel.SetActive(true);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        LoadGamePanel.SetActive(false);

        //play anim for opening game options panel
       //anim.Play("buttonTweenAnims_on");

        anim.Play("OptTweenAnim_off");
       // anim.Play("OptTweenAnim_on");

        // anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }
    public void openOptions_Controls()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(true);
        GfxPanel.SetActive(false);
        LoadGamePanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("mainMControls");

        lastClicked = 2;

        //play click sfx
        playClickSound();

    }
    public void openOptions_Gfx()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(true);
        LoadGamePanel.SetActive(false);

        //play anim for opening game options panel
        //anim.Play("OptTweenAnim_off");

       // anim.Play("OptTweenAnim_on");


        //play click sfx
        playClickSound();

    }

    public void openContinue_Load()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        LoadGamePanel.SetActive(true);

        //play anim for opening game options panel
       // anim.Play("OptTweenAnim_off");
       // anim.Play("OptTweenAnim_on");


        //play click sfx
        playClickSound();

    }

    public void newGame()
    {
        if (!string.IsNullOrEmpty(newGameSceneName))
            SceneManager.LoadScene(newGameSceneName);
        else
            Debug.Log("Please write a scene name in the 'newGameSceneName' field of the Main Menu Script and don't forget to " +
                "add that scene in the Build Settings!");
    }
    #endregion

    #region Back Buttons

    public void back_options()
    {
        //simply play anim for CLOSING main options panel
        anim.Play("buttonTweenAnims_off");

        //disable BLUR
       // Camera.main.GetComponent<Animator>().Play("BlurOff");

        //play click sfx
        playClickSound();
    }

    public void back_options_panels()
    {
        //simply play anim for CLOSING main options panel
        anim.Play("OptTweenAnim_on");
        
        //play click sfx
        playClickSound();

    }

    public void Quit()
    {
        Application.Quit();
    }
    #endregion

    #region Sounds
    public void playHoverClip()
    {
       
    }

    void playClickSound() {

    }


    #endregion
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
        for (int i = tar - 1; i >= 0; i--)
        {
            cLvl[i].isOn = true;
        }

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
        anim.Play("II_Start_Anim");
        //set camerascript on
        camera.GetComponent<RotateStak>().enabled = true;
        //set cube rotation on
        stak.GetComponent<TheStak>().enabled = true;

    }
    public void OpenInGameSettings()
    {

        anim.Play("openSettings");
    }
    public void CloseInGameSettings()
    {
        anim.SetFloat("openSettings", -1);
        anim.Play("openSettings");

    }
}
