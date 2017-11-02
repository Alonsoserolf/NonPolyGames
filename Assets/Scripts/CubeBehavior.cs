using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {

    float yPosition;
    //public GameObject morCube;
    public float smooth = 2.0F;
    public float tiltAngle = 90.0F;
    private void Start()
    {
        //transform.Translate(3, 0, 3);
        yPosition = transform.position.y;
    }
    private void Update()
    {
       OnMouseDown();
    }
   
    void OnMouseDown()
    {
       
       // print((Mathf.FloorToInt(transform.eulerAngles.x%360)/90)+"("+ transform.eulerAngles.x+", "+ transform.eulerAngles.y+", "+ transform.eulerAngles.z+")");
        transform.Rotate(new Vector3(Input.GetAxis("Horizontal") * 2f, 0f, Input.GetAxis("Vertical") * 2f));
        
    }
}
