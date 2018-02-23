using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class creat_object : MonoBehaviour
{
    public int direction;
    public bool hasMoved;
    static int snake_ate_points = 0;
    static public GameObject cube_copy;
    static private GameObject player;
    static List<Transform> body = new List<Transform>();
    static float mouse_pos_x = 0.0f;
    static float mouse_pos_y = 0.0f;
    static float mouse_pos_z = 0.0f;
    static private GameObject snake_head;
    static public bool did_collide;
    static public bool snake_ate_mouse;
    static GameObject cube;
   
    static public bool mouse_collision_with_tail;
    // Use this for initialization
    void Start()
    {


        mouse_collision_with_tail = false;
        player = GameObject.Find("Snake Head");
        snake_head = GameObject.Find("Snake Head");
        did_collide = false;
        mouse_pos_x = Random.Range(-4.428f, 4.428f);
        mouse_pos_y = Random.Range(1.611f, 1.611f);
        mouse_pos_z = Random.Range(-3.392f, 5.608f);
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Rigidbody gameObjectsRigidBody = cube.AddComponent<Rigidbody>();
        cube.transform.position = new Vector3(mouse_pos_x, mouse_pos_y, mouse_pos_z);
         snake_ate_mouse = false;
        cube.name = "mouse";
        

    }

    void Update()
    {
       
        

    }
    static public void move_tail()
    {
        
        generate_food();
        mouse_collision_with_tail = false;
        cube_copy = GameObject.Find("Snake Head");
        if (snake_ate_mouse)
        {
            
            snake_ate_mouse = false;
            
            
                GameObject cube = (GameObject)Instantiate(cube_copy,
                                                             player.transform.position,
                Quaternion.identity);
               
               
            

            cube.AddComponent<tail_colliding_with_head>();
            body.Insert(0, cube.transform);
            snake_ate_points++;
            Debug.Log(snake_ate_points);



        }

        else if (body.Count > 0)
        {

            body.Last().position = player.transform.position;


            body.Insert(0, body.Last());
            body.RemoveAt(body.Count - 1);

        }

       



        // Update is called once per frame







    }
    void OnCollisionEnter(Collision col)
    {
       
        // if snake head collide with the snake's food
        if (col.gameObject.name == "mouse")
            {
            did_collide = true;
            
           // Debug.Log(snake_ate_points);
                Destroy(col.gameObject);
              }
       else if (col.gameObject.name== "Snake Head(Clone)")
        {
            
            Grid.enable_game = false;
        }


        
    }
    static void generate_food()
    {
        float dist = 0.0f;
        
        
        if (did_collide)
        {


            did_collide = false;
            snake_ate_mouse = true;

            mouse_pos_x = Random.Range(-4.428f, 4.428f);
            mouse_pos_y = Random.Range(1.611f, 1.611f);
            mouse_pos_z = Random.Range(-3.392f, 5.608f);
            Vector3 cube_object = new Vector3(mouse_pos_x, mouse_pos_y, mouse_pos_z);
            if (mouse_collision_with_tail)
            {
                
                return;

            }

            if (cube != null)
            {
               
                cube = (GameObject)Instantiate(cube,
                                                             cube.transform.position,
                                                             Quaternion.identity);
               
                cube.name = "mouse";
                cube.transform.position = new Vector3(mouse_pos_x, mouse_pos_y, mouse_pos_z);
               
                Rigidbody gameObjectsRigidBody = cube.AddComponent<Rigidbody>();
            }

        }

    }



}