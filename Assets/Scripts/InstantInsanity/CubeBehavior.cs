using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeBehavior : MonoBehaviour {

    public float speed = 5;
    GameObject endRotation;
    public string[] gameCNTRLS;
    private bool isa=true;

    private void Start()
    {
        endRotation = new GameObject();
        gameCNTRLS = new string[4] { "a", "d", "w", "s" };
        changeSettings();
    }

    public void changeSettings()
    {
        isa = GameObject.Find("Mmenu").GetComponent<Settingss>().isA;
        if (isa)
            gameCNTRLS = new string[4] { "a", "d", "w", "s" };
        else gameCNTRLS = new string[4] { "left", "right", "up", "down" };
    }
    private void Update()
    {
        changeSettings();
        if (Input.GetKeyDown(gameCNTRLS[0]))
        {
            endRotation.transform.Rotate(Vector3.up, 90, Space.World);
        }
        if (Input.GetKeyDown(gameCNTRLS[1]))
        {
            endRotation.transform.Rotate(Vector3.up, -90, Space.World);
        }

        if (Input.GetKeyDown(gameCNTRLS[2]))
        {
            endRotation.transform.Rotate(Vector3.left, 90, Space.World);
        }
        if (Input.GetKeyDown(gameCNTRLS[3]))
        {
            endRotation.transform.Rotate(Vector3.left, -90, Space.World);
        }
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, endRotation.transform.rotation, Time.deltaTime * speed);
    }
}
