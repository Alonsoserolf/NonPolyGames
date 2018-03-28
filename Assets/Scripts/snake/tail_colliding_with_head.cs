using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tail_colliding_with_head : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("if snake tail collide with the snake's food");
        // if snake tail collide with the snake's food
        if (col.gameObject.name == "mouse")
        {
            
            Debug.Log("if snake tail collide with the snake's food");

        }
       





    }
    
}
