using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class head_colliding_with_food : MonoBehaviour {

     public Text game_over;
    public Text mouse_ate_record;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "mouse")
        {
            creat_object.did_collide = true;
            Destroy(other.gameObject);
        }
       else if (other.gameObject.name == "Snake Head(Clone)")
        {
            if (creat_object.snake_ate_points > creat_object.mouse_ate_recode_int)
            {
                creat_object.mouse_ate_recode_int = creat_object.mouse_ate_recode_int + creat_object.snake_ate_points;
                mouse_ate_record.text = creat_object.mouse_ate_recode_int.ToString();
            }
            game_over.text = "Game Over";
            Grid.enable_game = false;
            

        }
       
    }
    
}
