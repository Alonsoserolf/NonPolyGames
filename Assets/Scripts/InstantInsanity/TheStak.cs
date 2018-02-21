
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TheStak : MonoBehaviour
{
    private Dictionary<string, int[]> cubeRotations;
    private GameObject[][] theStak;
    private int[][] numeratedFaces;

    private int[][] frontBack;
    private int[][] topBottom;
    public Material[] skins;
    private LinkedList<int> frontBak = new LinkedList<int>();
    private LinkedList<int> leftRight = new LinkedList<int>();

    GameObject prevCube;
    private int yPos;
    public Transform cubePrefab;

    private Vector3 _LocalRotation;

    public Material red;//1
    public Material yellow;//2
    public Material green;//3
    public Material blue;//4
    public Material pink;//5

    //Use this for initialization
    private void Start()
    {
        //count # of cubes made in menu script
        int cubeNum = (transform.childCount);
        //Mathf.Floor((slide.GetComponent<Slider>().value * 10) + 4);
  /*      GameObject cmr = GameObject.FindWithTag("MainCamera");
        int yPos = (int)cmr.transform.position.y;
        int zPos = (int)cmr.transform.position.z;
        int xPos = (int)cmr.transform.position.x;
        _LocalRotation.y = (cubeNum - 4)-2;
        _LocalRotation.z = (3 * (cubeNum-4));
     
        cmr.transform.position=new Vector3(0, (cubeNum - 4)-2, _LocalRotation.z);

        for (int i = 0; i < cubeNum; i++)
        {
            //instantiate cubes
            makeChild = Instantiate(cubePrefab.gameObject, new Vector3(0, i, 0), Quaternion.identity) as GameObject;
            //add a script(CubeBehavior) to each cube and disable it
            makeChild.AddComponent<CubeBehavior>();
            makeChild.GetComponent<CubeBehavior>().enabled = false;
            makeChild.transform.parent = GameObject.Find("Stack").transform;
        }
        */
        GameObject stak = GameObject.FindWithTag("Stak");
        stak.GetComponent<TheStak>().enabled = true;
        print("hell");

        cubeNum = (transform.childCount);
        cubeRotations = FillInCubeRotations();

       //numeratedFaces = new int[cubeNum][];

        theStak = new GameObject[cubeNum][];
        frontBack = new int[cubeNum][];
        topBottom = new int[cubeNum][];
        numeratedFaces = new int[cubeNum][];
        for (int i = 0; i < cubeNum; i++)
        {
            // int[] arr = new int[6];
            // numeratedFaces.Add(arr);

            //arr[0]=i;
            numeratedFaces[i] = new int[6];
            theStak[i] = new GameObject[6];
            frontBack[i] = new int[2] { 2, 0 };
            topBottom[i] = new int[2] { 3, 4 };

            for (int j = 0; j < 6; j++)
            {
                //assign faces from each cube to array
                theStak[i][j] = this.gameObject.transform.GetChild(i).gameObject.transform.GetChild(j).gameObject;
                //'randomly' assign numbers to the array  
                numeratedFaces[i][j]= (int)(1 + (Mathf.Floor((((i * 6) + j)) * Mathf.PI) % cubeNum));//Find(x => x == arr)[j]=
               // print(numeratedFaces.Count.ToString() + "," + numeratedFaces.Find(x => x == arr).Length);

                switch (numeratedFaces[i][j])
                {
                    case 1:
                        theStak[i][j].GetComponent<Renderer>().material = red;
                        break;
                    case 2:
                        theStak[i][j].GetComponent<Renderer>().material = yellow;
                        break;
                    case 3:
                        theStak[i][j].GetComponent<Renderer>().material = green;
                        break;
                    case 4:
                        theStak[i][j].GetComponent<Renderer>().material = blue;
                        break;

                    default: break;
                }
                // print(numeratedFaces.Count.ToString() + "," + numeratedFaces.Find(x => x == arr)[j]);
                 
            }
        }
       
        printCubes(numeratedFaces);
        SolveItForMe();
    }
    
    private static Dictionary<string, int[]> FillInCubeRotations()
    {
        return new Dictionary<string, int[]>()
        {
            { "000", new int[] { 2, 0, 3, 4 } },
            { "0090", new int[] { 2, 0, 5, 1 } },
            { "00180", new int[] { 2, 0, 4, 3 } },
            { "00270", new int[] { 2, 0, 1, 5 } },
            { "0900", new int[] { 4, 3, 2, 0 } },
            { "09090", new int[] { 1, 5, 2, 0 } },
            { "090180", new int[] { 3, 4, 2, 0 } },
            { "090270", new int[] { 5, 1, 2, 0 } },
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
            currCube.transform.position = new Vector3(2, yPos, 1);
            //keep track of last cube used 
            prevCube = currCube;
        }
        //IsGameSolved();
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
               (angl > 225 && angl < 325) ? 270 : 360;
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
        //print(yPos);
        frontBack[yPos][0] = arr[0];
        frontBack[yPos][1] = arr[1];
        topBottom[yPos][0] = arr[2];
        topBottom[yPos][1] = arr[3];

        print(numeratedFaces[yPos][topBottom[yPos][1]]);
        //IsGameSolved();
    }

    private void SolveItForMe()
    {
        leftRight.Clear();
        frontBak = IISolutionMachine(numeratedFaces,leftRight);
        leftRight = IISolutionMachine(numeratedFaces, frontBak);
        frontBak = IISolutionMachine(numeratedFaces, leftRight);
        if (frontBak.Count>2 && leftRight.Count<=2) { print("f"); }
        foreach(int s in frontBak)
        print("vis. size:"+frontBak.Count+"..."+frontBak.Find(s).Value);
        foreach (int s in leftRight)
            print("vis sillze:" + leftRight.Count + "..." + leftRight.Find(s).Value);
    }
    protected LinkedList<int> IISolutionMachine(int[][] cubeF,LinkedList<int> pairs)
    {

        LinkedList<int> visited = new LinkedList<int>();
        int numberOCubes = cubeF.Length;
        int numberOPairs = pairs.Count;

        int[] pairArr = pairs.ToArray();
        int[] colrCount = new int[numberOCubes + 1];
        int i = 0, j = 0;
        //i == cube obj, j == face obj evens? 2k
        if (numberOPairs > 0)
        {
            /* for(int x=0; x<numberOPairs-2; x++)
             {
                 visited.AddLast(pairArr[x]);
                 if (x % 2 == 1)
                 {
                     colrCount[cubeF[pairArr[x-1]][pairArr[x]]]++;
                     colrCount[cubeF[pairArr[x-1]][pairArr[x] + 1]]++;
                 }
             }

             i = pairArr[numberOPairs-2];
             j = pairArr[numberOPairs-1]+2;
             */
            i = pairArr[0];
            j = pairArr[1] + 2;
            if (j > 4) j = 0;
        }
        while (i < numberOCubes)
        {
            if ((numberOPairs > 1
                    && numberOPairs > ((i*2)+1) //not_empty
                    && pairArr[(i*2)] == i//
                    && pairArr[(i*2)+1] == j)//
                || ((cubeF[i][j] == cubeF[i][j+1]) && (colrCount[cubeF[i][j]] != 0))
                || (!((colrCount[cubeF[i][j]] < 2) && (colrCount[cubeF[i][j+1]] < 2))))
            {
                while (j%6==4)
                {
                    if(visited.Count==0) return visited;
                    
                    j = visited.Last.Value;
                        visited.RemoveLast();
                    i = visited.Last.Value;
                        visited.RemoveLast();

                    colrCount[cubeF[i][j]]--;
                    colrCount[cubeF[i][j+1]]--;
                }
                    j += 2;  
            }
            else
            {
                colrCount[cubeF[i][j]]++;
                colrCount[cubeF[i][j+1]]++;
                visited.AddLast(i);
                visited.AddLast(j);
                //print(i + ":" + j);
                i++;
                j = 0;
            }
        }
        return visited;
    }
    public void IsGameSolved()
    {
        int cubeCount = 5;
        int frontFace = 0;
        int[] frontFacesCounter = new int[cubeCount];
        int[] backFacesCounter = new int[cubeCount];
        int[] topFacesCounter = new int[cubeCount];
        int[] bottomFacesCounter = new int[cubeCount];
        Text lose;
        //print(cubeCount);
        for (int i = 0; i < 4; i++)
        {
            ++frontFacesCounter[numeratedFaces[i][frontBack[i][0]]];
            ++backFacesCounter[numeratedFaces[i][frontBack[i][1]]];
            ++topFacesCounter[numeratedFaces[i][topBottom[i][0]]];
            ++bottomFacesCounter[numeratedFaces[i][topBottom[i][1]]];

            // print(frontFacesCounter[0] + "," + frontFacesCounter[1] + "," + frontFacesCounter[2] + "," + frontFacesCounter[3] + "," + frontFacesCounter[4] + "," + frontFacesCounter[5]); 
        }
        if (frontFacesCounter[0] > 1 || frontFacesCounter[1] > 1 || frontFacesCounter[2] > 1 || frontFacesCounter[3] > 1 || frontFacesCounter[4] > 1
            || backFacesCounter[0] > 1 || backFacesCounter[1] > 1 || backFacesCounter[2] > 1 || backFacesCounter[3] > 1 || backFacesCounter[4] > 1
            || topFacesCounter[0] > 1 || topFacesCounter[1] > 1 || topFacesCounter[2] > 1 || topFacesCounter[3] > 1 || topFacesCounter[4] > 1
            || bottomFacesCounter[0] > 1 || bottomFacesCounter[1] > 1 || bottomFacesCounter[2] > 1 || bottomFacesCounter[3] > 1 || bottomFacesCounter[4] > 1)
        {
            print("wrong");
            lose= GameObject.FindWithTag("lose").GetComponent<Text>();
            lose.text = "NO U LOSE";
            return;
        }
        print("correct");
        lose = GameObject.FindWithTag("lose").GetComponent<Text>();
        lose.text = "";
        Text win = GameObject.FindWithTag("win").GetComponent<Text>();
        win.text = "Bigly WINNING";
    }

    private void printCubes(int[][] adjLists)
    {
        for (int i = 0, j = 0; i <= adjLists.Count() - 1; j++)
        {
            if (j % 2 == 0) print(i+"l"+j+"(" + adjLists[i][j] + "," + adjLists[i][j + 1] + ") ");
            if (j % 6 == 5)
            {
                i++;
                j = -1;
                print(",");
            }
        }
    }
}
