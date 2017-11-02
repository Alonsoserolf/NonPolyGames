using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_camera : MonoBehaviour {

    public GameObject target;//the target object
    private float speedMod = 4.0f;//a speed modifier
    private Vector3 point;//the coord to the point where the camera looks at



    // Use this for initialization
    void Start()
    {
        point = target.transform.position;//get target's coords
        transform.LookAt(point);//makes the camera look to it
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(point, new Vector3(0.0f, 100.0f, 0.0f), 17 * Time.deltaTime * speedMod);

        }
    }

   
}


