using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class AnswersShow : MonoBehaviour {

    public GameObject[] ansF = new GameObject[13];
    public GameObject[] ansB = new GameObject[13];
    public GameObject[] ansL = new GameObject[13];
    public GameObject[] ansR = new GameObject[13];
    public Sprite[] spriteList = new Sprite[13];
    Animator anim;
    int inAnsToggle;


    private LinkedList<int> fb;
    private LinkedList<int> lr;
    private int[][] numeratedFaces;
    private int cubeNum;

    // Use this for initialization
    void Start () {
		        anim = GameObject.FindWithTag("Canvas").GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        
        
    }
    public void SetAnsShowParam()
    {
        GameObject stak = GameObject.FindWithTag("Stak");
        fb = stak.GetComponent<TheStak>().frontBak;
        lr = stak.GetComponent<TheStak>().leftRight;
        cubeNum = stak.GetComponent<TheStak>().cubeNum;
        numeratedFaces = stak.GetComponent<TheStak>().numeratedFaces;
    }
    public void ShowAnswers()
    {
       
        // anim.SetBool("SHWANS", true);
        inAnsToggle = (inAnsToggle == 0) ? 1 : 0;

        if (inAnsToggle == 1)
        {
            //max cubes playable
            int max = 12;
            int[] print_FrontBack = fb.ToArray();
            int[] print_LeftRight = lr.ToArray();

            int[] frontFacesCounter = new int[cubeNum + 1];
            int[] topFacesCounter = new int[cubeNum + 1];

            for (int i = 0; i < cubeNum; i++)
            {
                if (frontFacesCounter[numeratedFaces[i][print_FrontBack[i]]] == 0)
                {
                    ++frontFacesCounter[numeratedFaces[i][print_FrontBack[i]]];
                    // print(numeratedFaces[i][print_FrontBack[i]]+",,,"+ print_FrontBack[i]);
                    ansF[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_FrontBack[i]]];
                    ansB[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_FrontBack[i] + 1]];

                }
                else
                {
                    ++frontFacesCounter[numeratedFaces[i][print_FrontBack[i] + 1]];
                    // print(numeratedFaces[i][print_FrontBack[i]+1]);
                    ansF[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_FrontBack[i] + 1]];
                    ansB[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_FrontBack[i]]];
                }
                if (topFacesCounter[numeratedFaces[i][print_LeftRight[i]]] == 0)
                {
                    ++topFacesCounter[numeratedFaces[i][print_LeftRight[i]]];
                    print(numeratedFaces[i][print_LeftRight[i]]);
                    ansL[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_LeftRight[i]]];
                    ansR[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_LeftRight[i] + 1]];

                }
                else
                {
                    ++topFacesCounter[numeratedFaces[i][print_LeftRight[i] + 1]];
                    print(numeratedFaces[i][print_LeftRight[i] + 1]);
                    ansL[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_LeftRight[i] + 1]];
                    ansR[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_LeftRight[i]]];
                }
                print(numeratedFaces[i][print_FrontBack[i]] + " , " + numeratedFaces[i][print_FrontBack[i] + 1] + ")(" + numeratedFaces[i][print_LeftRight[i]] + " . " + numeratedFaces[i][print_LeftRight[i] + 1]);
                print(print_FrontBack[i] + "_" + print_LeftRight[i]);
            }
            for (int i = cubeNum; i < max; i++)
            {
                Destroy(ansF[i + 1]);
                Destroy(ansB[i + 1]);
                Destroy(ansL[i + 1]);
                Destroy(ansR[i + 1]);
            }




           // anim.SetBool("Show",true);
            anim.Play("ShowAnswer");
        }
        else
        {
        //    anim.SetBool("Show", false);
            anim.Play("CloseAnswer");

        }
    }

}
