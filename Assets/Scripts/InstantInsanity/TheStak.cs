using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TheStak : MonoBehaviour
{
    private Dictionary<string, int[]> cubeRotations;
    private GameObject[][] theStak;
    public Material[] skins = new Material[20];
    private int[][] numeratedFaces;
    private int[][] frontBack;
    private int[][] topBottom;
    private LinkedList<int> frontBak = new LinkedList<int>();
    private LinkedList<int> leftRight = new LinkedList<int>();

    GameObject prevCube;
    private int yPos;
    public Transform cubePrefab;
    private int cubeNum;
    int[] colrs;

    //Use this for initialization
    private void Start()
    {
        GameObject stak = GameObject.FindWithTag("Stak");
        stak.GetComponent<TheStak>().enabled = true;
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
        frontBack = new int[cubeNum][];
        topBottom = new int[cubeNum][];
        
        // skins = new Material[cubeNum+1];

        for (int i = 0; i < cubeNum; i++)
        {
            numeratedFaces[i] = new int[6];
            theStak[i] = new GameObject[6];
            frontBack[i] = new int[2] { 2, 0 };
            topBottom[i] = new int[2] { 3, 4 };

            for (int j = 0; j < 6; j++)
            {
                //assign faces from each cube to array
                theStak[i][j] = this.gameObject.transform.GetChild(i).gameObject.transform.GetChild(j).gameObject;
                //'randomly' assign numbers to the array  
                numeratedFaces[i][j] = (int)(1 + (Mathf.Floor((((i * 6) + j)) */* 1.3657f*/Mathf.PI) % cubeNum));
                //apply skins to cube size
                theStak[i][j].GetComponent<Renderer>().material = skins[numeratedFaces[i][j]];
            }
        }

        printCubes(numeratedFaces);
        SolveItForMe();
        if (leftRight.Count > 2 && frontBak.Count > 2)
            printAnswer(frontBak, leftRight);

    }



    private static Dictionary<string, int[]> FillInCubeRotations()
    {
        return new Dictionary<string, int[]>()
        {
            { "000", new int[] { 2, 0, 3, 4 } }, //1054
            { "0090", new int[] { 2, 0, 5, 1 } },//1032 2=1,0=0,3=5,4=4
            { "00180", new int[] { 2, 0, 4, 3 } },//1045
            { "00270", new int[] { 2, 0, 1, 5 } },//1023
            { "0900", new int[] { 4, 3, 2, 0 } },//4510
            { "09090", new int[] { 1, 5, 2, 0 } },//2,3,1,0
            { "090180", new int[] { 3, 4, 2, 0 } },//5410
            { "090270", new int[] { 5, 1, 2, 0 } },//3210
            { "01800", new int[] { 0, 2, 4, 3 } },
            { "018090", new int[] { 0, 2, 1, 5 } },
            { "0180180", new int[] { 0, 2, 3, 4 } },
            { "0180270", new int[] { 0, 2, 5, 1 } },
            { "02700", new int[] { 3, 4, 0, 2 } },
            { "027090", new int[] { 5, 1, 0, 2 } },
            { "0270180", new int[] { 4, 3, 0, 2 } },
            { "0270270", new int[] { 1, 5, 0, 2 } },
            { "9000", new int[] { 1, 5, 3, 4 } },
            { "90090", new int[] { 3, 4, 5, 1 } },
            { "900180", new int[] { 5, 1, 4, 3 } },
            { "900270", new int[] { 4, 3, 1, 5 } },
            { "90900", new int[] { 4, 3, 1, 5 } },
            { "909090", new int[] { 1, 5, 3, 4 } },
            { "9090180", new int[] { 3, 4, 5, 1 } },
            { "9090270", new int[] { 5, 1, 4, 3 } },
            { "901800", new int[] { 5, 1, 4, 3 } },
            { "9018090", new int[] { 4, 3, 1, 5 } },
            { "90180180", new int[] { 1, 5, 3, 4 } },
            { "90180270", new int[] { 3, 4, 5, 1 } },
            { "902700", new int[] { 3, 4, 5, 1 } },
            { "9027090", new int[] { 5, 1, 4, 3 } },
            { "90270180", new int[] { 4, 3, 1, 5 } },
            { "90270270", new int[] { 1, 5, 3, 4 } },
            { "18000", new int[] { 0, 2, 3, 4 } },
            { "180090", new int[] { 0, 2, 5, 1 } },
            { "1800180", new int[] { 0, 2, 4, 3 } },
            { "1800270", new int[] { 0, 2, 1, 5 } },
            { "180900", new int[] { 4, 3, 0, 2 } },
            { "1809090", new int[] { 1, 5, 0, 2 } },
            { "18090180", new int[] { 3, 4, 0, 2 } },
            { "18090270", new int[] { 5, 1, 0, 2 } },
            { "1801800", new int[] { 2, 0, 4, 3 } },
            { "18018090", new int[] { 2, 0, 1, 5 } },
            { "180180180", new int[] { 2, 0, 3, 4 } },
            { "180180270", new int[] { 2, 0, 5, 1 } },
            { "1802700", new int[] { 3, 4, 2, 0 } },
            { "18027090", new int[] { 5, 1, 2, 0 } },
            { "180270180", new int[] { 4, 3, 2, 0 } },
            { "180270270", new int[] { 1, 5, 2, 0 } },
            { "27000", new int[] { 5, 1, 3, 4 } },
            { "270090", new int[] { 4, 3, 5, 1 } },
            { "2700180", new int[] { 1, 5, 4, 3 } },
            { "2700270", new int[] { 3, 4, 1, 5 } },
            { "270900", new int[] { 4, 3, 5, 1 } },
            { "2709090", new int[] { 1, 5, 4, 3 } },
            { "27090180", new int[] { 3, 4, 1, 5 } },
            { "27090270", new int[] { 5, 1, 3, 4 } },
            { "2701800", new int[] { 1, 5, 4, 3 } },
            { "27018090", new int[] { 3, 4, 1, 5 } },
            { "270180180", new int[] { 5, 1, 3, 4 } },
            { "270180270", new int[] { 4, 3, 5, 1 } },
            { "2702700", new int[] { 3, 4, 1, 5 } },
            { "27027090", new int[] { 5, 1, 3, 4 } },
            { "270270180", new int[] { 4, 3, 5, 1 } },
            { "270270270", new int[] { 1, 5, 4, 3 } }
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

        frontBack[yPos][0] = arr[0];
        frontBack[yPos][1] = arr[1];
        topBottom[yPos][0] = arr[2];
        topBottom[yPos][1] = arr[3];

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


            ++frontFacesCounter[numeratedFaces[i][frontBack[i][0]]];
            ++backFacesCounter[numeratedFaces[i][frontBack[i][1]]];
            ++topFacesCounter[numeratedFaces[i][topBottom[i][0]]];
            ++bottomFacesCounter[numeratedFaces[i][topBottom[i][1]]];

            print(frontFacesCounter[0] + "," + frontFacesCounter[1] + "," + frontFacesCounter[2] + "," + frontFacesCounter[3] + "," + frontFacesCounter[4]);
        }

        if (frontFacesCounter[0] > 1 || frontFacesCounter[1] > 1 || frontFacesCounter[2] > 1 || frontFacesCounter[3] > 1 || frontFacesCounter[4] > 1 || frontFacesCounter[5] > 1
            || backFacesCounter[0] > 1 || backFacesCounter[1] > 1 || backFacesCounter[2] > 1 || backFacesCounter[3] > 1 || backFacesCounter[4] > 1 || backFacesCounter[5] > 1
            || topFacesCounter[0] > 1 || topFacesCounter[1] > 1 || topFacesCounter[2] > 1 || topFacesCounter[3] > 1 || topFacesCounter[4] > 1 || topFacesCounter[5] > 1
            || bottomFacesCounter[0] > 1 || bottomFacesCounter[1] > 1 || bottomFacesCounter[2] > 1 || bottomFacesCounter[3] > 1 || bottomFacesCounter[4] > 1 || bottomFacesCounter[5] > 1)
        {
            print("wrong");
            lose = GameObject.FindWithTag("lose").GetComponent<Text>();
            lose.text = "NO U LOSE";
            return;
        }
        print("correct");
        lose = GameObject.FindWithTag("lose").GetComponent<Text>();
        lose.text = "";
        Text win = GameObject.FindWithTag("win").GetComponent<Text>();
        win.text = "Bigly WINNING";
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
        int[] print_FrontBack = fb.ToArray();
        int[] print_LeftRight = lr.ToArray();
        print(fb.Count);
        print(lr.Count);
        for (int i = 0; i < cubeNum; i++)
        {
            print(numeratedFaces[i][print_FrontBack[i]] + " , " + numeratedFaces[i][print_FrontBack[i] + 1] + ")(" + numeratedFaces[i][print_LeftRight[i]] + " . " + numeratedFaces[i][print_LeftRight[i] + 1]);
            print(print_FrontBack[i] + "_" + print_LeftRight[i]);
            /*print( numeratedFaces[print_FrontBack[i]][print_FrontBack[i + 1]]+".."
                +numeratedFaces[print_FrontBack[i]][print_FrontBack[i + 1] + 1]+ "   " 
                +numeratedFaces[print_LeftRight[i]][print_LeftRight[i + 1]]+",,"
                +numeratedFaces[print_LeftRight[i]][print_LeftRight[i + 1] + 1]);*/
        }
    }
}