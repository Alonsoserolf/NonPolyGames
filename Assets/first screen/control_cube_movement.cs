using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_cube_movement : MonoBehaviour
{
   
    // Use this for initialization
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime);

        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
    }

}