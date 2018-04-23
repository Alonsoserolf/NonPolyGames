using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {

    public float speed = 5;
    GameObject endRotation;
    private void Start()
    {
        endRotation = new GameObject();
    }

    
  

    private void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            endRotation.transform.Rotate(Vector3.up, 90, Space.World);
        }
        if (Input.GetKeyDown("d"))
        {
            endRotation.transform.Rotate(Vector3.up, -90, Space.World);
        }

        if (Input.GetKeyDown("w"))
        {
            endRotation.transform.Rotate(Vector3.left, 90, Space.World);
        }
        if (Input.GetKeyDown("s"))
        {
            endRotation.transform.Rotate(Vector3.left, -90, Space.World);
        }

        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, endRotation.transform.rotation, Time.deltaTime * speed);
    }
}
