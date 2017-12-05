using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStak : MonoBehaviour {

    private Transform _XForm_Camera;
    private Transform _XForm_Parent;

    private Vector3 _LocalRotation;
    private float _CameraDistance = 10f;

    public float MouseSensitivity = 4f;
    public float ScrollSensitivity = 2f;
    public float OrbitDampening = 10f;
    public float ScrollDampening = 6f;

    public bool CameraDisabled = false;
    // Use this for initialization
    void Start()
    {
        this._XForm_Camera = this.transform;
        this._XForm_Parent = this.transform.parent;
        _LocalRotation.x = -19;
        _LocalRotation.y = 19;


    }

    // LateUpdate is called once per frame after Update() on every game object in the scene
    void LateUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            CameraDisabled = false;
        }
        else
        {
            CameraDisabled = true;
        }

        if ((!CameraDisabled))
        {
 /*Rotation of the camera is based on mouse coordinates
            //Rotation of the camera is based on mouse coordinates
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                _LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensitivity;
                _LocalRotation.y -= Input.GetAxis("Mouse Y") * MouseSensitivity;

                //Clamp the y rotation to horizon and not flipping over at the top
                _LocalRotation.y = Mathf.Clamp(_LocalRotation.y, 0f, 15f);
            }
           */
            if (Input.GetAxis("Mouse X") > 0)
            {

                transform.RotateAround(Vector3.zero, -Vector3.up, 150 * Time.deltaTime);
            }
            else if(Input.GetAxis("Mouse X") < 0)
            {
                transform.RotateAround(Vector3.zero, Vector3.up, 150 * Time.deltaTime);
            }
        }
        /*Actual camera  rig transformations
        Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0);
        this._XForm_Parent.rotation = Quaternion.Lerp(this._XForm_Parent.rotation, QT, Time.deltaTime * OrbitDampening);
        need to change rotation for image*/

    }
}

