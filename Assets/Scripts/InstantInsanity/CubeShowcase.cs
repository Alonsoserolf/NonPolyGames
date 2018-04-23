using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShowcase : MonoBehaviour
{
    Animator anim;
    private GameObject canvas;

    private void Start()
    {
        canvas = GameObject.FindWithTag("Canvas");
        anim = canvas.GetComponent<Animator>();

        anim.Play("cu_be");

    }


    private void Update()
    {
        

    }
}