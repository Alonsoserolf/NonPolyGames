using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class creat_object : MonoBehaviour
{

    static Vector3 current_head_position;
    public int direction;
    public bool hasMoved;
    static public GameObject cube_copy;
    static public GameObject player;
    static GameObject player2;
    static public List<Transform> body=new List<Transform>();
    static float mouse_pos_x = 0.0f;
    static float mouse_pos_y = 0.0f;
    static float mouse_pos_z = 0.0f;
    static private GameObject snake_head;
    static public bool did_mouse_collide_with_tail_;
    static public bool did_collide;
    static public bool snake_ate_mouse;
    static GameObject cube;
    static Rigidbody gameObjectsRigidBody;
    static GameObject mouse_image;

    // Use this for initialization
    void Start()
    {

        did_collide = false;
        
        
       
        snake_ate_mouse = false;

        did_mouse_collide_with_tail_ = false;

        mouse_pos_x = Random.Range(-4.428f, 4.428f);
        mouse_pos_y = Random.Range(1.611f, 1.611f);
        mouse_pos_z = Random.Range(-3.392f, 5.608f);
        
          mouse_image = Resources.Load("mouse_image") as GameObject;
        mouse_image = (GameObject)Instantiate(mouse_image,
                                                       mouse_image.transform.position,
                                                     Quaternion.identity);
        mouse_image.transform.position = new Vector3(mouse_pos_x, mouse_pos_y, mouse_pos_z);
        mouse_image.GetComponent<creat_object>().enabled = false;









    }






    private void Awake()
    {
         
       

    }
    void Update()
    {
        if (did_collide)
        {
            
            did_collide = false;
            snake_ate_mouse = true;

            mouse_pos_x = Random.Range(-4.428f, 4.428f);
            mouse_pos_y = Random.Range(1.611f, 1.611f);
            mouse_pos_z = Random.Range(-3.392f, 5.608f);
            Vector3 cube_vector = new Vector3(mouse_pos_x, mouse_pos_y, mouse_pos_z);
            RaycastHit hit;




            if (mouse_image != null && head_colliding_with_food.is_game_over != 1)
            {


                mouse_image = (GameObject)Instantiate(mouse_image,
                                                         mouse_image.transform.position,
                                                         Quaternion.identity);
                mouse_image.transform.position = new Vector3(mouse_pos_x, mouse_pos_y, mouse_pos_z);
            }
          
        }


    }
    static public void move_tail(int dir_mode)
    {

        cube_copy = GameObject.Find("Snake Head");
        player = GameObject.Find("Snake Head");
        snake_head = GameObject.Find("Snake Head");

        if (snake_ate_mouse)
        {

            if (dir_mode == 1)
            {
                current_head_position = player.transform.position;
                player.transform.position += new Vector3(0, 0, 0.5f);
                cube = (GameObject)Instantiate(cube_copy,
                                                         current_head_position,
                                                         Quaternion.identity);



            }
            if (dir_mode == 2)
            {
                current_head_position = player.transform.position;
                player.transform.position += new Vector3(0.5f, 0, 0);
                cube = (GameObject)Instantiate(cube_copy,
                                                         current_head_position,
                                                         Quaternion.identity);




            }
            if (dir_mode == 3)
            {
                current_head_position = player.transform.position;
                player.transform.position += new Vector3(0, 0, -0.5f);
                cube = (GameObject)Instantiate(cube_copy,
                                                         current_head_position,
                                                         Quaternion.identity);



            }
            if (dir_mode == 4)
            {
                current_head_position = player.transform.position;
                player.transform.position += new Vector3(-0.5f, 0, 0);
                cube = (GameObject)Instantiate(cube_copy,
                                                         current_head_position,
                                                         Quaternion.identity);



            }
            if (dir_mode == 5)
            {
                current_head_position = player.transform.position;
                player.transform.position += new Vector3(0, 0.5f, 0);
                cube = (GameObject)Instantiate(cube_copy,
                                                         current_head_position,
                                                         Quaternion.identity);



            }
            if (dir_mode == 6)
            {
                current_head_position = player.transform.position;
                player.transform.position += new Vector3(0, -0.5f, 0);
                cube = (GameObject)Instantiate(cube_copy,
                                                         current_head_position,
                                                         Quaternion.identity);



            }
            snake_ate_mouse = false;
            cube.GetComponent<head_colliding_with_food>().enabled = false;


            Collider box_collider = cube.GetComponent<BoxCollider>();
            body.Insert(0, cube.transform);



        }

        else if (body.Count > 0)
        {
            
             body.Last().position = player.transform.position;


            body.Insert(0, body.Last());
            body.RemoveAt(body.Count - 1);

        }





        // Update is called once per frame







    }



   

}