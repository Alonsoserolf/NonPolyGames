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

        // if snake head collide with the snake's food
        if (col.gameObject.name == "mouse")
        {
            creat_object.mouse_collision_with_tail = true;
          

        }
        else if (col.gameObject.name == "Snake Head")
        {
            Grid.enable_game = false;
        }





    }
}
