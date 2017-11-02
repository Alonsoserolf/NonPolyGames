using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheStak : MonoBehaviour {
    private int [][] cFaces;
    GameObject selectedCube;
    private int yPos;
    public Transform cubePrefab;
    private GameObject[][] theStak;

    public Material red;//1
    public Material yellow;//2
    public Material green;//3
    public Material blue;//4
    public Material pink;//5

    // Use this for initialization
    private void Start () {
        int cubeNum = (transform.childCount);
        print(this.gameObject.transform.childCount);
        cFaces = new int[cubeNum][];
        theStak = new GameObject[cubeNum][];
        for (int i=0; i < cubeNum; i++)
        {
            cFaces[i] = new int[6];
            theStak[i] = new GameObject[6];
            for(int j=0;j<6;j++)
            {
                theStak[i][j] = this.gameObject.transform.GetChild(i).gameObject.transform.GetChild(j).gameObject;
                cFaces[i][j] = (int) (1 + (Mathf.Floor((((i*6)+j)) * Mathf.PI) % cubeNum));
                print( i+","+j+": "+ (1 + (Mathf.Floor((((i * 6) + j)) * Mathf.PI) % cubeNum)));

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
           // this.gameObject.transform.GetChild(i).gameObject.transform.parent = this.gameObject.transform;
        }
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
                print(hitCube.name);
                CubeSelect(hitCube);
            }
        }
    }      
    public void CubeSelect(GameObject obj)
    {
        if (selectedCube != null && selectedCube!=obj)
        {
            if (selectedCube.GetComponent<CubeBehavior>().isActiveAndEnabled)
            {
                selectedCube.GetComponent<CubeBehavior>().enabled = false;
                selectedCube.transform.position= new Vector3(0, yPos, 0);

                int xPosition = (selectedCube.transform.eulerAngles.x < 90) ? 0 :
                             (selectedCube.transform.eulerAngles.x < 180) ? 90 :
                             (selectedCube.transform.eulerAngles.x < 270) ? 180 :
                             (selectedCube.transform.eulerAngles.x < 360) ? 270 : 360;

                selectedCube.transform.eulerAngles  =new Vector3(xPosition , 0, 0);

            }
        }
        if (obj.GetComponent<CubeBehavior>().isActiveAndEnabled)
        {
            obj.GetComponent<CubeBehavior>().enabled = false;
            obj.transform.position = new Vector3(0, yPos, 0);

            int xPosition = (int)selectedCube.transform.eulerAngles.x;
            xPosition = (xPosition > 325 || xPosition < 45) ? 0 :
                              (xPosition>45 && xPosition < 135) ? 90 :
                              (xPosition > 135 && xPosition < 225) ? 180 :
                              (xPosition > 225 && xPosition < 325) ? 270 : 360;
            int yPosition = (int)selectedCube.transform.eulerAngles.y;
            yPosition = (yPosition > 325 || yPosition < 45) ? 0 :
                              (yPosition > 45 && yPosition < 135) ? 90 :
                              (yPosition > 135 && yPosition < 225) ? 180 :
                              (yPosition > 225 && yPosition < 325) ? 270 : 360;
            int zPosition = (int)selectedCube.transform.eulerAngles.z;
            print(zPosition);
            zPosition = (zPosition > 325 || zPosition < 45) ? 0 :
                              (zPosition > 45 && zPosition < 135) ? 90 :
                              (zPosition > 135 && zPosition < 225) ? 180 :
                              (zPosition > 225 && zPosition < 325) ? 270 : 360;
            print(zPosition);

            //print(xPosition);
            selectedCube.transform.eulerAngles = new Vector3(xPosition, yPosition, zPosition);

        }
        else
        {
             obj.GetComponent<CubeBehavior>().enabled = true;
             yPos = (int)obj.transform.position.y;
             print(yPos);
             obj.transform.position= new Vector3(2, yPos, 1);

        }

        selectedCube = obj;

    }
    void CubeDeselect()
    {

    }
    
}
