using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tictac_hover : MonoBehaviour {
    public  GameObject hover;
    public bool alreadyEnabled;
    private void Start()
    {
        hover = hover.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        hover.GetComponent<Renderer>().material.color = Color.blue;
    }
    private void OnMouseOver()
    {
        if (!alreadyEnabled)
            hover.GetComponent<Renderer>().enabled = true;


    }
    private void OnMouseExit()
    {
        if (!alreadyEnabled)
            hover.GetComponent<Renderer>().enabled = false;
    }
}
