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
    // Use this for initialization
    void Start()
    {



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
        cube_copy = GameObject.Find("Snake Head");
        if (snake_ate_mouse)
        {
            
            snake_ate_mouse = false;
            GameObject cube = (GameObject)Instantiate(cube_copy,
                                                         player.transform.position,
                                                         Quaternion.identity);


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
       


        
    }
    static void generate_food()
    {
        float dist = 0.0f;
        
        int i = 0;
        if (did_collide)
        {


            did_collide = false;
            snake_ate_mouse = true;

            mouse_pos_x = Random.Range(-4.428f, 4.428f);
            mouse_pos_y = Random.Range(1.611f, 1.611f);
            mouse_pos_z = Random.Range(-3.392f, 5.608f);
            Vector3 cube_object = new Vector3(mouse_pos_x, mouse_pos_y, mouse_pos_z);
            
            /*while (i < body.Count)
            {
                dist = Vector3.Distance(cube_object, (body[i].position));
                if (dist>1.0f)
                {
                    Debug.Log("dist<1");
                    mouse_pos_x = Random.Range(-4.428f, 4.428f);
                    mouse_pos_y = Random.Range(1.611f, 1.611f);
                    mouse_pos_z = Random.Range(-3.392f, 5.608f);
                    cube_object = new Vector3(mouse_pos_x, mouse_pos_y, mouse_pos_z);
                    i = -1;
                }

                i++;
            }
            */
            

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