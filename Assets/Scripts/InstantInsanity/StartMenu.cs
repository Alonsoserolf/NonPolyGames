using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour {
    private GameObject canvas;
    private GameObject stak;
    public Slider mainSlider;
    private GameObject more;
    private GameObject less;
    public Transform cubePrefab;
    GameObject cmr;
    GameObject mainCmr;
    private Vector3 _LocalRotation;

    public Text countCubes;
    int yPos,zPos, xPos;


    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("Canvas");
        stak = GameObject.FindWithTag("Stak");
        more = GameObject.FindWithTag("morecube");
        less = GameObject.FindWithTag("lesscube");
    }

    // Update is called once per frame
    void Update () {

  
    }
    public void addCubes()
    {
        countCubes = GameObject.FindWithTag("countcubes").GetComponent<Text>();
        countCubes.text=(int.Parse(countCubes.text)+1).ToString();
         cmr = GameObject.FindWithTag("Camera");
        mainCmr = GameObject.FindWithTag("MainCamera");

        yPos = (int)cmr.transform.position.y;
        zPos = (int)cmr.transform.position.z;
        xPos = (int)cmr.transform.position.x;
        int cubeNum = int.Parse(countCubes.text);
        _LocalRotation.y = (cubeNum - 4)/2 + 2;
        _LocalRotation.z = -(3 * (cubeNum - 4));
       // cmr.transform.position = new Vector3(xPos,yPos,_LocalRotation.z);

    }
    public void subtCubes()
    {
        countCubes = GameObject.FindWithTag("countcubes").GetComponent<Text>();
        countCubes.text = (int.Parse(countCubes.text) - 1).ToString();
    
    }
    public void Comence()
    {
        countCubes=GameObject.FindWithTag("countcubes").GetComponent<Text>();
        int cubeNum = int.Parse(countCubes.text);
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
