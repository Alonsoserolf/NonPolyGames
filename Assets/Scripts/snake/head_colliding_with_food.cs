using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class head_colliding_with_food : MonoBehaviour {

     public Text game_over;
    static public int is_game_over;
    public Text mouse_ate_record;
    static public int snake_ate_points;
    public Text mouse_ate;
    static public int mouse_ate_recode_int;

    static GameObject mouse_image;
    






    // Use this for initialization
    void Start () {
        is_game_over = 0;
        mouse_image = GameObject.Find("mouse_image");
        mouse_ate_record.text = mouse_ate_recode_int.ToString();
         
        mouse_ate.text = "0";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Awake()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "mouse")
        {
            creat_object.did_collide = true;
            Destroy(other.gameObject);
        }
        else if (other.name == "mouse_image(Clone)")
        {
            snake_ate_points++;

            mouse_ate.text = snake_ate_points.ToString();
            creat_object.did_collide = true;
            Destroy(other.gameObject);
        }
        
       else if (other.gameObject.name == "Snake Head(Clone)")
        {

            if (snake_ate_points > mouse_ate_recode_int)
            {
                mouse_ate_recode_int = snake_ate_points;
                mouse_ate_record.text = mouse_ate_recode_int.ToString();
            }
           
            game_over.text = "Game Over,please press the Return button";
           
            
            Grid.enable_game = false;
            is_game_over = 1;
            

        }
       
    }

    
}
