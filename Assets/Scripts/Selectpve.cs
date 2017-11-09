using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectpve : MonoBehaviour {

    private GameObject[] ModeButtons;

    public void select()
    {
        createStack.mode = 1;
        ModeButtons = GameObject.FindGameObjectsWithTag("ModeSelect");
        for (int i = 0; i < ModeButtons.Length; i++)
        {
            ModeButtons[i].gameObject.SetActive(false);
        }
    }
}
