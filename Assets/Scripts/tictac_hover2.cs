using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tictac_hover2 : MonoBehaviour {

    public GameObject hover;
    public GameObject hoverCopy;
    public bool alreadyEnabled;

    private void Start()
    {
        hoverCopy = hover;
    }
    private void OnMouseOver()
    {
        if (tictac.mode_choice == 0)
        {
            if (!alreadyEnabled)
            {


                if (tictac.player_turn == 0)
                {
                    hover = hoverCopy.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
                    hover.GetComponent<Renderer>().material.color = Color.blue;
                }

                else
                {
                    hover = hoverCopy.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                    hover.GetComponent<Renderer>().material.color = Color.red;
                }
                hover.GetComponent<Renderer>().enabled = true;
            }

        }
    }
    private void OnMouseExit()
    {
        if (!alreadyEnabled)
            hover.GetComponent<Renderer>().enabled = false;
    }
}
