using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectpvp : MonoBehaviour {

    private GameObject[] ModeButtons;

    public void select()
    {
        createStack.mode = 0;
        ModeButtons = GameObject.FindGameObjectsWithTag("ModeSelect");
        for (int i = 0; i < ModeButtons.Length; i++)
        {
            ModeButtons[i].gameObject.SetActive(false);
        }

    }
}
