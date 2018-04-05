using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    public static bool enable_game;
    static public int direction;
    static public bool hasMoved;
     public Transform snakeHead;
    static public float speed;
    


    void Start()
    {
        enable_game = false;
        speed = 0.08f;
        direction = 1;
        hasMoved = false;
       
    }

    void Update()
    {
        
        if (hasMoved)
        {
            if (Input.GetKeyDown("up"))
            {
                if (direction != 3 && direction != 1)
                {
                    direction = 1;
                    hasMoved = false;
                }
            }
            else if (Input.GetKeyDown("right"))
            {
                if (direction != 4 && direction != 2)
                {
                    direction = 2;
                    hasMoved = false;
                }
            }
            else if (Input.GetKeyDown("down"))
            {
                if (direction != 1 && direction != 3)
                {
                    direction = 3;
                    hasMoved = false;
                }
            }
            else if (Input.GetKeyDown("left"))
            {
                if (direction != 2 && direction != 4)
                {
                    direction = 4;
                    hasMoved = false;
                }
            }
            else if (Input.GetKeyDown("z"))
            {
                if (direction != 6 && direction != 5)
                {
                    direction = 5;
                    hasMoved = false;
                }
            }
            else if (Input.GetKeyDown("x"))
            {
                if (direction != 5 && direction != 6)
                {
                    direction = 6;
                    hasMoved = false;
                }
            }


        }

    }

     IEnumerator moveTimer()
    {
        while (enable_game)
        {
            
            yield return new WaitForSeconds(speed);
            moveStep();
        }
    }
    public  void Modify_enable_game()
    {
        GameObject find_snake_head = GameObject.Find("Snake Head");
        GameObject mouse_image = Resources.Load("mouse_image") as GameObject;
        if (head_colliding_with_food.is_game_over == 0)
        {

            find_snake_head.GetComponent<creat_object>().enabled = true;
            mouse_image.GetComponent<creat_object>().enabled = true;
            creat_object.body.Clear();
            head_colliding_with_food.is_game_over = 2;            
            enable_game = true;
            StartCoroutine("moveTimer");
        }
    }



    public void return_to_previous_screen()
    {
        head_colliding_with_food.snake_ate_points = 0;
        if (head_colliding_with_food.is_game_over==1)
        {
            
            SceneManager.LoadScene("snake");

        }
        else
        {
            
            SceneManager.LoadScene("snake menu");
        }
    }

    

    public void moveStep()
    {


        switch (direction)
        {

            case 1:
                creat_object.move_tail(1);
                snakeHead.position += new Vector3(0, 0, 0.5f);


                break;
            case 2:
                creat_object.move_tail(2);
                snakeHead.position += new Vector3(0.5f, 0, 0);


                break;
            case 3:
                creat_object.move_tail(3);
                snakeHead.position += new Vector3(0, 0, -0.5f);


                break;
            case 4:
                creat_object.move_tail(4);
                snakeHead.position += new Vector3(-0.5f, 0, 0);


                break;
            case 5:
                creat_object.move_tail(5);
                snakeHead.position += new Vector3(0, 0.5f, 0);


                break;
            case 6:
                creat_object.move_tail(6);
                snakeHead.position += new Vector3(0, -0.5f, 0);


                break;
        }
        hasMoved = true;
    }
}
