using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TheStak : MonoBehaviour
{
    private Dictionary<string, int[]> cubeRotations;
    private GameObject[][] theStak;
    public Material[] skins = new Material[12];
    public Material[] skins2 = new Material[12];
    public Sprite[] spriteList= new Sprite[13];
    public GameObject[] ansF = new GameObject[13];
    public GameObject[] ansB = new GameObject[13];
    public GameObject[] ansL = new GameObject[13];
    public GameObject[] ansR = new GameObject[13];
    public GameObject time;
        public GameObject timeWin;
    public GameObject timeLose;
    private Text l;
    Animator anim;
    public int[][] numeratedFaces;
    private int[][] fbCheck;
    private int[][] tbCheck;
    public LinkedList<int> frontBak = new LinkedList<int>();
    public LinkedList<int> leftRight = new LinkedList<int>();

    GameObject prevCube;
    
    private GameObject ansS;
    private GameObject stak;
    private int yPos;
    public Transform cubePrefab;
    public int cubeNum;
    int[] colrs;
    

    //Use this for initialization
    private void Start()
    {
         Random rnd_skin_picker = new Random();
         int rn= RandomNumber(0, 2);
        print(rn);
         stak = GameObject.FindWithTag("Stak");
         ansS = GameObject.Find("Mmenu");
         anim = GameObject.FindWithTag("Canvas").GetComponent<Animator>();
        
        // stak.GetComponent<TheStak>().enabled = true;
        //size of stack
        cubeNum = (transform.childCount);

        cubeRotations = FillInCubeRotations();
        //is this necessary?
        colrs = new int[cubeNum + 1];


        //theStak is filled with II cube objects
        theStak = new GameObject[cubeNum][];
        //full random numbers assigned 
        numeratedFaces = new int[cubeNum][];
        //using this for checking solved puzzle
        fbCheck = new int[cubeNum][];
        tbCheck = new int[cubeNum][];
        
        // skins = new Material[cubeNum+1];

        for (int i = 0; i < cubeNum; i++)
        {
            numeratedFaces[i] = new int[6];
            theStak[i] = new GameObject[6];
            fbCheck[i] = new int[2] { 1, 0 };
            tbCheck[i] = new int[2] { 5, 4 };

            for (int j = 0; j < 6; j++)
            {
                //assign faces from each cube to array
                theStak[i][j] = this.gameObject.transform.GetChild(i).gameObject.transform.GetChild(j).gameObject;
                //'randomly' assign numbers to the array  
                numeratedFaces[i][j] = (int)(1 + (Mathf.Floor((((i * 6) + j)) */* 1.3657f*/Mathf.PI) % cubeNum));
                //apply skins to cube size

                theStak[i][j].GetComponent<Renderer>().material = (rn==0)?skins[numeratedFaces[i][j]]: skins2[numeratedFaces[i][j]];
            }

        }

        printCubes(numeratedFaces);
        SolveItForMe();
        ansS.GetComponent<AnswersShow>().SetAnsShowParam();
    }

    private int RandomNumber(int min, int max)
{
Random random = new Random();
return Random.Range(min, max);
}

    private static Dictionary<string, int[]> FillInCubeRotations()
    {
        return new Dictionary<string, int[]>()
        {
            { "000", new int[] { 1, 0, 5, 4 } }, //1054
            { "0090", new int[] { 1, 0, 3, 2 } },//1032 2=1,0=0,3=5,4=4
            { "00180", new int[] { 1, 0, 4, 5 } },//1045
            { "00270", new int[] { 1, 0, 2, 3 } },//1023
            { "0900", new int[] { 4, 5, 1, 0 } },//4510
            { "09090", new int[] { 2, 3, 1, 0 } },//2,3,1,0
            { "090180", new int[] { 5, 4, 1, 0 } },//5410
            { "090270", new int[] { 3, 2, 1, 0 } },//3210
            { "01800", new int[] { 0, 1, 4, 5 } },
            { "018090", new int[] { 0, 1, 2, 3 } },
            { "0180180", new int[] { 0, 1, 5, 4 } },
            { "0180270", new int[] { 0, 1, 3, 2 } },
            { "02700", new int[] { 5, 4, 0, 1 } },
            { "027090", new int[] { 3, 2, 0, 1 } },
            { "0270180", new int[] { 4, 5, 0, 1 } },
            { "0270270", new int[] { 2, 3, 0, 1 } },
            { "9000", new int[] { 2, 3, 5, 4 } },
            { "90090", new int[] { 5, 4, 3, 2 } },
            { "900180", new int[] { 3, 2, 4, 5 } },
            { "900270", new int[] { 4, 5, 2, 3 } },
            { "90900", new int[] { 4, 5, 2, 3 } },
            { "909090", new int[] { 2, 3, 5, 4 } },
            { "9090180", new int[] { 5, 4, 3, 2 } },
            { "9090270", new int[] { 3, 2, 4, 5 } },
            { "901800", new int[] { 3, 2, 4, 5 } },
            { "9018090", new int[] { 4, 5, 2, 3 } },
            { "90180180", new int[] { 2, 3, 5, 4 } },
            { "90180270", new int[] { 5, 4, 3, 2 } },
            { "902700", new int[] { 5, 4, 3, 2 } },
            { "9027090", new int[] { 3, 2, 4, 5 } },
            { "90270180", new int[] { 4, 5, 2, 3 } },
            { "90270270", new int[] { 2, 3, 5, 4 } },
            { "18000", new int[] { 0, 1, 5, 4 } },
            { "180090", new int[] { 0, 1, 3, 2 } },
            { "1800180", new int[] { 0, 1, 4, 5 } },
            { "1800270", new int[] { 0, 1, 2, 3 } },
            { "180900", new int[] { 4, 5, 0, 1 } },
            { "1809090", new int[] { 2, 3, 0, 1 } },
            { "18090180", new int[] { 5, 4, 0, 1 } },
            { "18090270", new int[] { 3, 2, 0, 1 } },
            { "1801800", new int[] { 1, 0, 4, 5 } },
            { "18018090", new int[] { 1, 0, 2, 3 } },
            { "180180180", new int[] { 1, 0, 5, 4 } },
            { "180180270", new int[] { 1, 0, 3, 2 } },
            { "1802700", new int[] { 5, 4, 1, 0 } },
            { "18027090", new int[] { 3, 2, 1, 0 } },
            { "180270180", new int[] { 4, 5, 1, 0 } },
            { "180270270", new int[] { 2, 3, 1, 0 } },
            { "27000", new int[] { 3, 2, 5, 4 } },
            { "270090", new int[] { 4, 5, 3, 2 } },
            { "2700180", new int[] { 2, 3, 4, 5 } },
            { "2700270", new int[] { 5, 4, 2, 3 } },
            { "270900", new int[] { 4, 5, 3, 2 } },
            { "2709090", new int[] { 2, 3, 4, 5 } },
            { "27090180", new int[] { 5, 4, 2, 3 } },
            { "27090270", new int[] { 3, 2, 5, 4 } },
            { "2701800", new int[] { 2, 3, 4, 5 } },
            { "27018090", new int[] { 5, 4, 2, 3 } },
            { "270180180", new int[] { 3, 2, 5, 4 } },
            { "270180270", new int[] { 4, 5, 3, 2 } },
            { "2702700", new int[] { 5, 4, 2, 3 } },
            { "27027090", new int[] { 3, 2, 5, 4 } },
            { "270270180", new int[] { 4, 5, 3, 2 } },
            { "270270270", new int[] { 2, 3, 4, 5 } }
        };
    }
    // Update is called once per frame
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log("MOUSE IS OVER: " + hit.collider.name);
            if (Input.GetMouseButtonDown(0))
            {

                GameObject hitCube = hit.transform.gameObject;
                CubeSelect(hitCube);
            }
        }
    }


    //used by update to update cube position(rotation)
    public void CubeSelect(GameObject currCube)
    {
        if (prevCube != null && prevCube != currCube)
        {
            if (prevCube.GetComponent<CubeBehavior>().isActiveAndEnabled)
            {
                prevCube.GetComponent<CubeBehavior>().enabled = false;
                prevCube.transform.position = new Vector3(0, yPos, 0);
                FixRotation(prevCube);
            }
        }

        if (currCube.GetComponent<CubeBehavior>().isActiveAndEnabled)
        {
            currCube.GetComponent<CubeBehavior>().enabled = false;
            currCube.transform.position = new Vector3(0, yPos, 0);
            FixRotation(currCube);
        }
        else
        {
            currCube.GetComponent<CubeBehavior>().enabled = true;
            yPos = (int)currCube.transform.position.y;
            //offset cube for rotation visibility
            GameObject campos = GameObject.FindWithTag("Camera");
            Vector3 cameraLeftVector = campos.transform.right;
            currCube.transform.Translate(cameraLeftVector * 2, Space.World);

            prevCube = currCube;
        }
    }

    private void FixRotation(GameObject obj)
    {
        int xPosition = (int)obj.transform.eulerAngles.x;
        int yPosition = (int)obj.transform.eulerAngles.y;
        int zPosition = (int)obj.transform.eulerAngles.z;

        // print("(" + xPosition + "," + yPosition + "," + zPosition + ").");

        xPosition = FixAngles(xPosition);
        yPosition = FixAngles(yPosition);
        zPosition = FixAngles(zPosition);

        // print("(" + xPosition + "," + yPosition + "," + zPosition + ")");

        obj.transform.eulerAngles = new Vector3(xPosition, yPosition, zPosition);

        int[] o = UpdateStackSides(xPosition, yPosition, zPosition);
        SetSideArrays(obj, o);
        // print(frontBack[0][0]+","+topBottom[0][0]);
    }

    private int FixAngles(int angl)
    {
        angl = (angl > 325 || angl < 45) ? 0 :
               (angl > 45 && angl < 135) ? 90 :
               (angl > 135 && angl < 225) ? 180 :
               (angl > 225 && angl < 325) ? 270 : 0;
        return angl;
    }
    private int[] UpdateStackSides(int x, int y, int z)
    {
        string xStr = x.ToString();
        string yStr = y.ToString();
        string zStr = z.ToString();
        string anglesKEY = string.Concat(xStr, yStr, zStr);

        int[] sidesArray = cubeRotations[anglesKEY];
        return sidesArray;
        //SetSideArrays(sidesArray);
    }
    //instantiate paired sides of stack to check 
    private void SetSideArrays(GameObject obj, int[] arr)
    {
        int yPos = (int)obj.transform.position.y;
        fbCheck[yPos][0] = arr[0];
        fbCheck[yPos][1] = arr[1];
        tbCheck[yPos][0] = arr[2];
        tbCheck[yPos][1] = arr[3];
    }


    private void SolveItForMe()
    {
        leftRight.Clear();
        for (int x = 0; x < colrs.Length; x++) colrs[x] = 0;

        frontBak = SolveItForMe(numeratedFaces, leftRight, colrs, false);                   //something with the colrs
        //UT
        foreach(int s in frontBak) print(":"+s);
        leftRight = SolveItForMe(numeratedFaces, frontBak, colrs, true);

    }
    private LinkedList<int> SolveItForMe(int[][] cube_Stack,LinkedList<int> oth_Half_Sol, int[] oHS_Face_ID, bool half_Solution)
    {
        return IISolution_Pairs(cube_Stack, oth_Half_Sol, oHS_Face_ID, half_Solution);
    }

    protected LinkedList<int> IISolution_Pairs(int[][] cube_Stak_Arr, LinkedList<int> comp_pairs, int[] face_ID_Visited, bool first_Half_Complete)
    {
        int iFace = 0;
        //oVA will hold positions of selected pairs for part of the solution; faceID tracks IDs for the cube sides we are considering (2 of each)!!
        int[] old_Visited_Arr, face_ID = new int[cube_Stak_Arr.Length + 1];

        // using Lists to efficiently do a DFS, 
        LinkedList<int> new_Visited_List = new LinkedList<int>();

        //if we already have solution for one set of pairs we keep track else we create new
        if (first_Half_Complete)
        {
            //sides-colors... ?................................................................
            // face_ID = face_ID_Visited;
            //keep track of pairs we can't pick from
            old_Visited_Arr = comp_pairs.ToArray();
        }
        else
        {
            //new face_ID which tracks the chosen pairs
            //face_ID = new int[cube_Stak_Arr.Length];
            //oVA should be empty
            old_Visited_Arr = new int[cube_Stak_Arr.Length];

            //partially_Complete
            if (comp_pairs.Count < cube_Stak_Arr.Length && comp_pairs.Count > 0)
            {
                /*This module will check to see if the previous solution was incomplete
                 *  comp_pairs is the previous new_Visited
                 *  I saved the Array version as it has a faster look-up op.
                 */
                new_Visited_List = comp_pairs;
                //?..................................................................................
                old_Visited_Arr = new_Visited_List.ToArray();
                //colors
                face_ID = face_ID_Visited;

                /*face_ID range(1,len(cube_Stack_Arr)) 
                 *  c_S_A needs height of cube.pair/depth of our DFS
                 *  nV.C serves as the height and s_iF 0,2,4<--these are the position of one side of the 3 possible pairs per cube
                 *  update our visited ID tracker for both sides of the pair (don't know if needed)
                 *  then remove the last node from the n_V_L
                 */
                iFace = new_Visited_List.Last.Value;

                while (iFace > 3)
                {
                    //whiled for too long, used twice make a function
                    //return empty, indicating no solution was found

                    if (new_Visited_List.Count == 0)
                        return new_Visited_List;

                    //remove last cube
                    iFace = new_Visited_List.Last.Value;
                    //
                    face_ID[cube_Stak_Arr[new_Visited_List.Count][iFace]]--;
                    face_ID[cube_Stak_Arr[new_Visited_List.Count][iFace + 1]]--;
                    //
                    new_Visited_List.RemoveLast();

                    iFace += 2;
                }

                old_Visited_Arr = new_Visited_List.ToArray();
            }
        }

        

        //if leftnum=ritenum nd counted 0 OR leftnum count 2 OR ritenum count 2 
        while (new_Visited_List.Count < cube_Stak_Arr.Length)
        {
            if ((first_Half_Complete && old_Visited_Arr[new_Visited_List.Count] == iFace)
               || (face_ID[cube_Stak_Arr[new_Visited_List.Count][iFace]] == 2 || face_ID[cube_Stak_Arr[new_Visited_List.Count][iFace + 1]] == 2)
               || ((cube_Stak_Arr[new_Visited_List.Count][iFace] == cube_Stak_Arr[new_Visited_List.Count][iFace + 1]) && face_ID[cube_Stak_Arr[new_Visited_List.Count][iFace]] != 0))
            {
                while (iFace > 3)
                {
                    if (new_Visited_List.Count == 0)
                    {
                        if (first_Half_Complete)
                        {
                            int last=(comp_pairs.Last.Value==4) ? 0 : comp_pairs.Last.Value + 2;
                            iFace = comp_pairs.Last.Value;
                            comp_pairs.RemoveLast();
                            //

                            face_ID_Visited[cube_Stak_Arr[cube_Stak_Arr.Length-1][iFace]]--;
                            face_ID_Visited[cube_Stak_Arr[cube_Stak_Arr.Length-1][iFace + 1]]--;
                            //
                            comp_pairs.AddLast(last);

                            //we are going to try the first half again, to have a complete solution you need the two halfs,
                            // some stacks will only have part of a solution
                            frontBak = SolveItForMe(cube_Stak_Arr, comp_pairs, face_ID_Visited, false);
                            print("fb"+frontBak);
                            return (frontBak.Count == cube_Stak_Arr.Length) ? SolveItForMe(cube_Stak_Arr, comp_pairs, face_ID_Visited,false) : new_Visited_List;
                        }


                        //return empty, indicating no solution was found
                        return new_Visited_List;
                    }

                    iFace = new_Visited_List.Last.Value;
                    new_Visited_List.RemoveLast();

                    face_ID[cube_Stak_Arr[new_Visited_List.Count][iFace]]--;
                    face_ID[cube_Stak_Arr[new_Visited_List.Count][iFace + 1]]--;
                }
                iFace += 2;
            }
            else
            {
                face_ID[cube_Stak_Arr[new_Visited_List.Count][iFace]]++;
                face_ID[cube_Stak_Arr[new_Visited_List.Count][iFace + 1]]++;
                new_Visited_List.AddLast(iFace);
                iFace = 0;
            }
        }
        face_ID_Visited = face_ID;
        return new_Visited_List;
    }

    public void IsGameSolved()
    {

        int[] frontFacesCounter = new int[cubeNum + 1];
        int[] backFacesCounter = new int[cubeNum + 1];
        int[] topFacesCounter = new int[cubeNum + 1];
        int[] bottomFacesCounter = new int[cubeNum + 1];
        Text lose;

        for (int i = 0; i < cubeNum; i++)
        {
            ++frontFacesCounter[numeratedFaces[i][fbCheck[i][0]]];
            ++backFacesCounter[numeratedFaces[i][fbCheck[i][1]]];
            ++topFacesCounter[numeratedFaces[i][tbCheck[i][0]]];
            ++bottomFacesCounter[numeratedFaces[i][tbCheck[i][1]]];
            print(numeratedFaces[i][fbCheck[i][0]]);
        }

        for (int i = 1; i <= cubeNum; i++)
        {

            if (frontFacesCounter[i] == 1 && backFacesCounter[i] == 1 && topFacesCounter[i] == 1 && bottomFacesCounter[i] == 1)
            {
                l = GameObject.FindWithTag("time").GetComponent<Text>();
                timeWin.GetComponent<Text>().text = l.text;
                print(l.text);
                anim.Play("winn");
                Destroy(stak);
            }
            else
            {
                l = GameObject.FindWithTag("time").GetComponent<Text>();
                timeLose.GetComponent<Text>().text = l.text;
                anim.Play("losse");
                print(l.text);
                Destroy(stak);

            }
        }
    }

    //BBT
    private void printCubes(int[][] adjLists)
    {
        for (int i = 0, j = 0; i <= adjLists.Count() - 1; j++)
        {
            if (j % 2 == 0) print(i + "l" + j + "(" + adjLists[i][j] + "," + adjLists[i][j + 1] + ") ");
            if (j % 6 == 5)
            {
                i++;
                j = -1;
                print(",");
            }
        }
    }
    private void printAnswer(LinkedList<int> fb, LinkedList<int> lr)
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
                ansB[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_FrontBack[i]+1]];

            }
            else
            {
                ++frontFacesCounter[numeratedFaces[i][print_FrontBack[i]+1]];
               // print(numeratedFaces[i][print_FrontBack[i]+1]);
                ansF[i + 1].GetComponent<Image>().sprite = spriteList[numeratedFaces[i][print_FrontBack[i]+1]];
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
        for(int i=cubeNum; i<max;i++)
        {
            Destroy(ansF[i + 1]);
            Destroy(ansB[i + 1]);
            Destroy(ansL[i + 1]);
            Destroy(ansR[i + 1]);
        }
    }
}