using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStak : MonoBehaviour {

    private Transform _XForm_Camera;
    private Transform _XForm_Parent;
    GameObject cmr;
    GameObject stcb;
    private Vector3 _LocalRotation;
    private Vector3 _LRotation;


    public float MouseSensitivity = 4f;
    public float OrbitDampening = 10f;

    public bool CameraDisabled = false;
    // Use this for initialization
    void Start()
    {
        this._XForm_Camera = this.transform;
        this._XForm_Parent = this.transform.parent;
        _LocalRotation.x = -19;
        cmr = GameObject.FindWithTag("MainCamera");
        stcb = GameObject.FindWithTag("Stak");
        _LocalRotation.y =2;
       // _LRotation.z -= stcb.transform.childCount;
        //this._XForm_Camera.position = new Vector3(0f, 0f, stcb.transform.childCount);

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
            // Rotation of the camera is based on mouse coordinates
            //Rotation of the camera is based on mouse coordinates
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                _LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensitivity;
                _LocalRotation.y -= Input.GetAxis("Mouse Y") * MouseSensitivity;

                //Clamp the y rotation to horizon and not flipping over at the top
                int max= (stcb.transform.childCount % 2 == 0) ? stcb.transform.childCount - 2 : stcb.transform.childCount - 3;
                _LocalRotation.y = Mathf.Clamp(_LocalRotation.y, 2f,max);
            }
       


         
        }
        //Actual camera  rig transformations
        Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0f);
        this._XForm_Parent.rotation = Quaternion.Lerp(this._XForm_Parent.rotation, QT, Time.deltaTime * OrbitDampening);
        this._XForm_Parent.position = new Vector3(0f,_LocalRotation.y, 0f);

       // this._XForm_Camera.position = new Vector3(0f, 0f, _LRotation.z);

    }
}

