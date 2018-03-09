using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public static bool enable_game;
    public int direction;
    public bool hasMoved;
    public Transform snakeHead;
    public float speed;
    public static void modify_enable_game()
    {
        
        enable_game = true;

    }
    void Start()
    {
        enable_game = true;
        speed = 0.05f;
        direction = 1;
        hasMoved = true;
        StartCoroutine("moveTimer");
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
