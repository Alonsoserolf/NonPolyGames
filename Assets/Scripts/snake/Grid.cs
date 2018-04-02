using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    
    public int direction;
    public bool hasMoved;
    public   Transform snakeHead;
    public float speed;
    void Start()
    {
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
        while (enabled)
        {
            yield return new WaitForSeconds(speed);
            moveStep();
        }
    }

    public void moveStep()
    {
        
       
        switch (direction)
        {
            
            case 1: snakeHead.position += new Vector3(0, 0, 0.5f);
                creat_object.move_tail();
               
                break;
            case 2: snakeHead.position += new Vector3(0.5f, 0, 0);
                creat_object.move_tail();
                
                break;
            case 3: snakeHead.position += new Vector3(0, 0, -0.5f);
                creat_object.move_tail();
                
                break;
            case 4: snakeHead.position += new Vector3(-0.5f, 0, 0);
                creat_object.move_tail();
               
                break;
            case 5: snakeHead.position += new Vector3(0, 0.5f, 0);
                creat_object.move_tail();
               
                break;
            case 6: snakeHead.position += new Vector3(0, -0.5f, 0);
                creat_object.move_tail();
                
                break;
        }
        hasMoved = true;
    }
}

