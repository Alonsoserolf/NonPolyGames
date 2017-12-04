using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheStak : MonoBehaviour {
    private Dictionary<string, int[]> cubeRotations;
    private GameObject[][] theStak;
    private int [][] cFaces;
    private int [][] frontBack;
    private int [][] topBottom;
    public Material[] skins;

    GameObject prevCube;
    private int yPos;
    public Transform cubePrefab;


    public Material red;//1
    public Material yellow;//2
    public Material green;//3
    public Material blue;//4
    public Material pink;//5

    // Use this for initialization
    private void Start ()
    {
        //count # of cubes made in menu script
        int cubeNum = (transform.childCount);
        print(cubeNum+",");
        cubeRotations = FillInCubeRotations();

        cFaces = new int[cubeNum][];
        theStak = new GameObject[cubeNum][];
        frontBack = new int[cubeNum][];
        topBottom = new int[cubeNum][];

        for (int i = 0; i < cubeNum; i++)
        {
            cFaces[i] = new int[6];
            theStak[i] = new GameObject[6];
            frontBack[i] = new int[2] { 2, 0 };
            topBottom[i] = new int[2] { 3, 4 };

            for (int j = 0; j < 6; j++)
            {
                //assign faces from each cube to array
                theStak[i][j] = this.gameObject.transform.GetChild(i).gameObject.transform.GetChild(j).gameObject;
                //'randomly' assign numbers to the array  
                cFaces[i][j] = (int)(1 + (Mathf.Floor((((i * 6) + j)) * Mathf.PI) % cubeNum));
                //print(cFaces[i][j] + ",");
                switch (cFaces[i][j])
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
                    case 5:
                        theStak[i][j].GetComponent<Renderer>().material = pink;
                        break;
                    default: break;
                }
            }

            //UpdateStackSides(0, 0, 0);
        }
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
        if (prevCube != null && prevCube!=currCube)
        {
            if (prevCube.GetComponent<CubeBehavior>().isActiveAndEnabled)
            {
                prevCube.GetComponent<CubeBehavior>().enabled = false;
                prevCube.transform.position= new Vector3(0, yPos, 0);
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
        SetSideArrays(obj,o);
       // print(frontBack[0][0]+","+topBottom[0][0]);
    }

    private int FixAngles(int angl)
    {
        angl = (angl > 325 || angl < 45 ) ? 0   :
               (angl > 45  && angl < 135) ? 90  :
               (angl > 135 && angl < 225) ? 180 :
               (angl > 225 && angl < 325) ? 270 : 360;
        return angl;
    }
    private int[] UpdateStackSides(int x, int y, int z)
    {
        string xStr = x.ToString();
        string yStr = y.ToString();
        string zStr = z.ToString();
        string anglesKEY = string.Concat(xStr,yStr,zStr);

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

        print(cFaces[yPos][topBottom[yPos][1]]);
        //IsGameSolved();
    }

    public void IsGameSolved()
    {
        int cubeCount = 6;
        int[] repeatFacesCounter = new int[cubeCount];
        //print(cubeCount);
        for(int i = 0; i < 4; i++)
        {
            int frontFace= ++repeatFacesCounter[cFaces[i][frontBack[i][0]]];
            //print(frontBack[i][0] + "," + frontBack[i][1] + "," + topBottom[i][0] + "," + topBottom[i][1]);
            //print(cFaces[i][frontBack[i][0]]);
            int backFace = ++repeatFacesCounter[cFaces[i][frontBack[i][1]]];
            int topFace = ++repeatFacesCounter[cFaces[i][topBottom[i][0]]];
            int bottomFace = ++repeatFacesCounter[cFaces[i][topBottom[i][1]]];
            print(repeatFacesCounter[0] + "," + repeatFacesCounter[1] + "," + repeatFacesCounter[2] + "," + repeatFacesCounter[3] + "," + repeatFacesCounter[4] + "," + repeatFacesCounter[5]);

            if (repeatFacesCounter[cFaces[i][frontBack[i][0]]] > 4 || repeatFacesCounter[cFaces[i][frontBack[i][1]]] > 4 || repeatFacesCounter[cFaces[i][topBottom[i][0]]] > 4 || repeatFacesCounter[cFaces[i][topBottom[i][1]]] > 4)
            {
                print("wrong");
                return;
            }
        }
        print("correct");
    }

    private void SolveItForMe()
    {

    }
}
