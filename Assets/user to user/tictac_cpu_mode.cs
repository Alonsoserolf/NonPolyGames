using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class tictac_cpu_mode : MonoBehaviour
{


    private static int[] level1c;
    private static int[] level2c;
    private static int[] level3c;
    public static int mode_choice = 0;
    public Text player_turn_text;
    public Text player_won_text;
    private int player_turn_text_overrule = 0;
    public Button restart_button;




    private void checkWin()
    {


        ///player1 checkwin///


        //check for level3c only win
        if (level3c[0] == 1 && level3c[1] == 1 && level3c[2] == 1 || level3c[3] == 1 && level3c[4] == 1 && level3c[5] == 1 || level3c[6] == 1 && level3c[7] == 1 && level3c[8] == 1 || level3c[1] == 1 && level3c[4] == 1 && level3c[7] == 1 || level3c[0] == 1 && level3c[3] == 1 && level3c[6] == 1 || level3c[2] == 1 && level3c[5] == 1 && level3c[8] == 1 || level3c[0] == 1 && level3c[4] == 1 && level3c[8] == 1 || level3c[2] == 1 && level3c[4] == 1 && level3c[6] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "You won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            restart_button.gameObject.SetActive(true);


        }
        //check for level2c only win
        if (level2c[0] == 1 && level2c[1] == 1 && level2c[2] == 1 || level2c[3] == 1 && level2c[4] == 1 && level2c[5] == 1 || level2c[6] == 1 && level2c[7] == 1 && level2c[8] == 1 || level2c[1] == 1 && level2c[4] == 1 && level2c[7] == 1 || level2c[0] == 1 && level2c[3] == 1 && level2c[6] == 1 || level2c[2] == 1 && level2c[5] == 1 && level2c[8] == 1 || level2c[0] == 1 && level2c[4] == 1 && level2c[8] == 1 || level2c[2] == 1 && level2c[4] == 1 && level2c[6] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "You won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;

            restart_button.gameObject.SetActive(true);
        }

        //check for level1c only win
        if (level1c[0] == 1 && level1c[1] == 1 && level1c[2] == 1 || level1c[3] == 1 && level1c[4] == 1 && level1c[5] == 1 || level1c[6] == 1 && level1c[7] == 1 && level1c[8] == 1 || level1c[1] == 1 && level1c[4] == 1 && level1c[7] == 1 || level1c[0] == 1 && level1c[3] == 1 && level1c[6] == 1 || level1c[2] == 1 && level1c[5] == 1 && level1c[8] == 1 || level1c[0] == 1 && level1c[4] == 1 && level1c[8] == 1 || level1c[2] == 1 && level1c[4] == 1 && level1c[6] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "You won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;

            restart_button.gameObject.SetActive(true);

        }

        //check for up and down level win
        if (level3c[0] == 1 && level2c[0] == 1 && level1c[0] == 1 || level3c[1] == 1 && level2c[1] == 1 && level1c[1] == 1 || level3c[2] == 1 && level2c[2] == 1 && level1c[2] == 1 || level3c[3] == 1 && level2c[3] == 1 && level1c[3] == 1 || level3c[4] == 1 && level2c[4] == 1 && level1c[4] == 1 || level3c[5] == 1 && level2c[5] == 1 && level1c[5] == 1 || level3c[6] == 1 && level2c[6] == 1 && level1c[6] == 1 || level3c[7] == 1 && level2c[7] == 1 && level1c[7] == 1 || level3c[8] == 1 && level2c[8] == 1 && level1c[8] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "You won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;

            restart_button.gameObject.SetActive(true);

        }
        //check for diagonal between level win
        if (level3c[1] == 1 && level2c[4] == 1 && level1c[7] == 1 || level3c[3] == 1 && level2c[4] == 1 && level1c[5] == 1 || level3c[5] == 1 && level2c[4] == 1 && level1c[3] == 1 || level3c[7] == 1 && level2c[4] == 1 && level1c[1] == 1 || level3c[8] == 1 && level2c[4] == 1 && level1c[0] == 1 || level3c[8] == 1 && level2c[5] == 1 && level1c[2] == 1 || level3c[8] == 1 && level2c[4] == 1 && level1c[0] == 1 || level3c[6] == 1 && level2c[4] == 1 && level1c[2] == 1 || level3c[6] == 1 && level2c[7] == 1 && level1c[8] == 1 || level3c[6] == 1 && level2c[3] == 1 && level1c[0] == 1 || level3c[0] == 1 && level2c[1] == 1 && level1c[2] == 1 || level3c[0] == 1 && level2c[3] == 1 && level1c[6] == 1 || level3c[0] == 1 && level2c[4] == 1 && level1c[5] == 1 || level3c[2] == 1 && level2c[5] == 1 && level1c[8] == 1 || level3c[2] == 1 && level2c[4] == 1 && level1c[6] == 1 || level3c[2] == 1 && level2c[1] == 1 && level1c[0] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "You won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;

            restart_button.gameObject.SetActive(true);

        }


        ///cpu check win///

        if (level3c[0] == 2 && level3c[1] == 2 && level3c[2] == 2 || level3c[3] == 2 && level3c[4] == 2 && level3c[5] == 2 || level3c[6] == 2 && level3c[7] == 2 && level3c[8] == 2 || level3c[1] == 2 && level3c[4] == 2 && level3c[7] == 2 || level3c[0] == 2 && level3c[3] == 2 && level3c[6] == 2 || level3c[2] == 2 && level3c[5] == 2 && level3c[8] == 2 || level3c[0] == 2 && level3c[4] == 2 && level3c[8] == 2 || level3c[2] == 2 && level3c[4] == 2 && level3c[6] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;

            restart_button.gameObject.SetActive(true);

        }

        if (level2c[0] == 2 && level2c[1] == 2 && level2c[2] == 2 || level2c[3] == 2 && level2c[4] == 2 && level2c[5] == 2 || level2c[6] == 2 && level2c[7] == 2 && level2c[8] == 2 || level2c[1] == 2 && level2c[4] == 2 && level2c[7] == 2 || level2c[0] == 2 && level2c[3] == 2 && level2c[6] == 2 || level2c[2] == 2 && level2c[5] == 2 && level2c[8] == 2 || level2c[0] == 2 && level2c[4] == 2 && level2c[8] == 2 || level2c[2] == 2 && level2c[4] == 2 && level2c[6] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;

            restart_button.gameObject.SetActive(true);


        }
        if (level1c[0] == 2 && level1c[1] == 2 && level1c[2] == 2 || level1c[3] == 2 && level1c[4] == 2 && level1c[5] == 2 || level1c[6] == 2 && level1c[7] == 2 && level1c[8] == 2 || level1c[1] == 2 && level1c[4] == 2 && level1c[7] == 2 || level1c[0] == 2 && level1c[3] == 2 && level1c[6] == 2 || level1c[2] == 2 && level1c[5] == 2 && level1c[8] == 2 || level1c[0] == 2 && level1c[4] == 2 && level1c[8] == 2 || level1c[2] == 2 && level1c[4] == 2 && level1c[6] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;

            restart_button.gameObject.SetActive(true);

        }
        if (level3c[0] == 2 && level2c[0] == 2 && level1c[0] == 2 || level3c[1] == 2 && level2c[1] == 2 && level1c[1] == 2 || level3c[2] == 2 && level2c[2] == 2 && level1c[2] == 2 || level3c[3] == 2 && level2c[3] == 2 && level1c[3] == 2 || level3c[4] == 2 && level2c[4] == 2 && level1c[4] == 2 || level3c[5] == 2 && level2c[5] == 2 && level1c[5] == 2 || level3c[6] == 2 && level2c[6] == 2 && level1c[6] == 2 || level3c[7] == 2 && level2c[7] == 2 && level1c[7] == 2 || level3c[8] == 2 && level2c[8] == 2 && level1c[8] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;

            restart_button.gameObject.SetActive(true);
        }
        if (level3c[1] == 2 && level2c[4] == 2 && level1c[7] == 2 || level3c[3] == 2 && level2c[4] == 2 && level1c[5] == 2 || level3c[5] == 2 && level2c[4] == 2 && level1c[3] == 2 || level3c[7] == 2 && level2c[4] == 2 && level1c[1] == 2 || level3c[8] == 2 && level2c[4] == 2 && level1c[0] == 2 || level3c[8] == 2 && level2c[7] == 2 && level1c[6] == 2 || level3c[8] == 2 && level2c[5] == 2 && level1c[2] == 2 || level3c[8] == 2 && level2c[4] == 2 && level1c[0] == 2 || level3c[6] == 2 && level2c[4] == 2 && level1c[2] == 2 || level3c[6] == 2 && level2c[7] == 2 && level1c[8] == 2 || level3c[6] == 2 && level2c[3] == 2 && level1c[0] == 2 || level3c[0] == 2 && level2c[1] == 2 && level1c[2] == 2 || level3c[0] == 2 && level2c[3] == 2 && level1c[6] == 2 || level3c[0] == 2 && level2c[4] == 2 && level1c[5] == 2 || level3c[2] == 2 && level2c[5] == 2 && level1c[8] == 2 || level3c[2] == 2 && level2c[4] == 2 && level1c[6] == 2 || level3c[2] == 2 && level2c[1] == 2 && level1c[0] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
        }





    }


    // Use this for initialization

    void Start()
    {


        level3c = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        level2c = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        level1c = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        


    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnMouseDown()
    {

        Debug.Log(level3c[0]);
        Debug.Log(level3c[1]);
        Debug.Log(level3c[2]);
        Debug.Log("before mouse down");

        if (Input.GetMouseButton(0))
        {
            Debug.Log("after mouse down");
            if (gameObject.tag == "Cube0")
            {



                Debug.Log("cube0");

                level3c[0] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;



            }
            if (gameObject.tag == "Cube1")
            {




                Debug.Log("cube1");
                level3c[1] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube2")
            {



                Debug.Log("cube2");
                level3c[2] = 1;

                gameObject.GetComponent<Renderer>().material.color = Color.blue;




            }
            if (gameObject.tag == "Cube3")
            {



                Debug.Log("cube3");
                level3c[3] = 1;

                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube4")
            {



                Debug.Log("cube4");
                level3c[4] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube5")
            {


                Debug.Log("cube5");
                level3c[5] = 1;

                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube6")
            {



                Debug.Log("cube6");
                level3c[6] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube7")
            {



                Debug.Log("cube7");
                level3c[7] = 1;

                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            if (gameObject.tag == "Cube8")
            {
                Debug.Log("cube8");
                level3c[8] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube9" && level2c[0] == 0)
            {

                level2c[0] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube10" && level2c[1] == 0)
            {

                level2c[1] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;


            }
            if (gameObject.tag == "Cube11" && level2c[2] == 0)
            {

                level2c[2] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;


            }
            if (gameObject.tag == "Cube12" && level2c[3] == 0)
            {

                level2c[3] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;


            }
            if (gameObject.tag == "Cube13" && level2c[4] == 0)
            {
                level2c[4] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;


            }
            if (gameObject.tag == "Cube14" && level2c[5] == 0)
            {

                level2c[5] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;


            }
            if (gameObject.tag == "Cube15" && level2c[6] == 0)
            {

                level2c[6] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;


            }
            if (gameObject.tag == "Cube16" && level2c[7] == 0)
            {

                level2c[7] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;


            }
            if (gameObject.tag == "Cube17" && level2c[8] == 0)
            {

                level2c[8] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;


            }
            if (gameObject.tag == "Cube18" && level1c[0] == 0)
            {

                level1c[0] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;


            }
            if (gameObject.tag == "Cube19" && level1c[1] == 0)
            {

                level1c[1] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube20" && level1c[2] == 0)
            {

                level1c[2] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube21" && level1c[3] == 0)
            {

                level1c[3] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube22" && level1c[4] == 0)
            {

                level1c[4] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube23" && level1c[5] == 0)
            {

                level1c[5] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube24" && level1c[6] == 0)
            {

                level1c[6] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            if (gameObject.tag == "Cube25" && level1c[7] == 0)
            {

                level1c[7] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }
            if (gameObject.tag == "Cube26" && level1c[8] == 0)
            {

                level1c[8] = 1;



                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }

            computer_algorithm();
            checkWin();
        }


    }





    //computer algorithm
    void computer_algorithm()
    {

        int break_it = 0;
        int counter1 = 0;
        int count_1_level_1 = 0;
        int count_1_level_2 = 0;
        int count_1_level_3 = 0;
        int counter = 0;
        int num;
        int computer_offence_initiator = 0;
        int computer_defence_initiator = 0;
        int final_stage_array = 0;
        num = Random.Range(0, 9);
        while (counter < 9)
        {
            if (level3c[counter] == 1)
            {
                count_1_level_3++;
            }
            if (level3c[counter] == 1)
            {
                count_1_level_2++;
            }
            if (level3c[counter] == 1)
            {
                count_1_level_1++;
            }
            counter++;
        }
        

        
        while ( num == 1 || num==3||num==4||num==5||num==7)
        {
            num = Random.Range(0, 9);
        }
        Debug.Log(num);
        
        
    if (count_1_level_3 == 1 && count_1_level_2 == 0 && count_1_level_1 < 2)
    {
        if (level3c[4] == 0)
        {
            level3c[4] = 2;
            fill_cpu_color_slot();
        }
        if (level3c[4] == 1)
        {
            level3c[num] = 2;
            fill_cpu_color_slot();

        }
        computer_offence_initiator = 1;
        computer_defence_initiator = 1;
        final_stage_array = 1;
    }
    else if (count_1_level_2 == 1 && count_1_level_3 < 2 && count_1_level_1 < 2)
    {
        if (level2c[4] == 0)
        {
            level2c[4] = 2;
            fill_cpu_color_slot();
        }
        if (level2c[4] == 1)
        {
            level2c[num] = 2;
            fill_cpu_color_slot();
        }
        computer_offence_initiator = 1;
        computer_defence_initiator = 1;
        final_stage_array = 1;
    }
    else if (count_1_level_1 == 1 && count_1_level_2 == 0 && count_1_level_3 == 0)
    {
        if (level1c[4] == 0)
        {
            level1c[4] = 2;
            fill_cpu_color_slot();
        }
        if (level1c[4] == 1)
        {
            level1c[num] = 2;
            fill_cpu_color_slot();
        }
        computer_offence_initiator = 1;
        computer_defence_initiator = 1;
        final_stage_array = 1;
    }

    // function to check if cpu can finish the game before checking defence
    computer_offence2(ref computer_defence_initiator, ref computer_offence_initiator, ref final_stage_array);
    if (computer_defence_initiator == 0)
    {
        computer_defence(ref computer_offence_initiator, ref final_stage_array);
    }
    if (computer_offence_initiator == 0)
    {
        computer_offence1(ref final_stage_array);
    }

    //if possibilities for offenece and defence are consumed and no needed
    if (final_stage_array == 0)
    {
        while (counter1 < 9&&break_it==0)
        {
            if (level3c[counter1] != 1 && level3c[counter1] != 2)
            {
                level3c[counter1] = 2;
                fill_cpu_color_slot();
                counter1 = 8;
                break_it = 1;
            }

            if (level2c[counter1] != 1 && level2c[counter1] != 2)
            {
                level2c[counter1] = 2;
                fill_cpu_color_slot();
                counter1 = 8;
                break_it = 1;
            }

            if (level1c[counter1] != 1 && level1c[counter1] != 2)
            {
                level1c[counter1] = 2;
                fill_cpu_color_slot();
                counter1 = 8;
                break_it = 1;
            }
            counter1++;
        }
    }




}




void computer_defence(ref int computer_offence_initiator1, ref int final_stage_array2)
{
    int counter1 = 0;
    int counter2 = 0;
    int counter3 = 0;
    int counter4 = 0;
    int counter5 = 0;
    int counter6 = 0;
    int counter7 = 0;
    int counter8 = 0;
    int counter9 = 0;
    int counter10 = 0;
    int counter11 = 0;
    int sort_level = 2;
    int counter_level3c = 0;
    int counter_level2c = 0;
    int counter_level1c = 0;
    int[] index_array_level3c;
    int[] index_array_level2c;
    int[] index_array_level1c;
    index_array_level3c = new int[5] { 9, 9, 9, 9, 9 };
    index_array_level2c = new int[5] { 9, 9, 9, 9, 9 };
    index_array_level1c = new int[5] { 9, 9, 9, 9, 9 };
    int[,] win_combo;
    int[,] win_combo_up_down;
    int[,] win_combo_diagonal;
    win_combo = new int[8, 3] { { 0,1,2 },
{ 3,4,5 },
{ 6,7,8 },
{ 1,4,7 },
{ 0,3,6 },
{ 2,5,8 },
{ 0,4,8 },
{ 2,4,6 } };
    win_combo_up_down = new int[9, 3] { { 0,0,0 },
{ 1,1,1 },
{ 2,2,2 },
{ 3,3,3 },
{ 4,4,4 },
{ 5,5,5 },
{ 6,6,6 },
{ 7,7,7 },
{ 8,8,8 } };
    win_combo_diagonal = new int[16, 3] { { 1,4,7 },
{ 3,4,5 },
{ 5,4,3 },
{ 7,4,1 },
{ 8,4,0 },
{ 8,7,6 },
{ 8,5,2 },
{ 6,4,2 },
{ 6,3,0 },
{ 0,1,2 },
{ 0,3,6 },
{ 0,4,5 },
{ 2,5,8 },
{ 2,4,6 },
{ 2,1,0 },
{ 6,7,8 } };

    while (counter6 < 9)
    {
        //check where are the player occupied slots
        if (level3c[counter6] == 1)
        {
            index_array_level3c[counter_level3c] = counter6;
            counter_level3c++;
        }
        if (level2c[counter6] == 1)
        {
            index_array_level2c[counter_level2c] = counter6;
            counter_level2c++;
        }
        if (level1c[counter6] == 1)
        {
            index_array_level1c[counter_level1c] = counter6;
            counter_level1c++;
        }

        counter6++;

    }
    counter6 = 0;


    for (counter1 = 0; counter1 < 8; counter1++)
    {
        for (counter2 = 0; counter2 < 3; counter2++)
        {

            for (counter3 = 0; counter3 < 5; counter3++)
            {

                if (index_array_level3c[counter3] == win_combo[counter1, counter2])
                {

                    counter5++;

                }

                if (index_array_level2c[counter3] == win_combo[counter1, counter2])
                {

                    counter4++;

                }

                if (index_array_level1c[counter3] == win_combo[counter1, counter2])
                {

                    counter7++;

                }


            }
            //fill in for level 3
            if (counter5 == 2 && level3c[win_combo[counter1, 0]] != 2 && level3c[win_combo[counter1, 1]] != 2 && level3c[win_combo[counter1, 2]] != 2)
            {


                while (counter6 < 3)
                {

                    if (level3c[win_combo[counter1, counter6]] != 2 && level3c[win_combo[counter1, counter6]] != 1)
                    {


                        level3c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot();
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;
                        final_stage_array2 = 1;
                        computer_offence_initiator1 = 1;

                    }
                    counter6++;
                }
                return;
            }
            //fill in for level 2
            if (counter4 == 2 && level2c[win_combo[counter1, 0]] != 2 && level2c[win_combo[counter1, 1]] != 2 && level2c[win_combo[counter1, 2]] != 2)
            {


                while (counter6 < 3)
                {

                    if (level2c[win_combo[counter1, counter6]] != 2 && level2c[win_combo[counter1, counter6]] != 1)
                    {


                        level2c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot();
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;
                        final_stage_array2 = 1;
                        computer_offence_initiator1 = 1;

                    }
                    counter6++;
                }
                return;
            }
            //fill in for level 1
            if (counter7 == 2 && level1c[win_combo[counter1, 0]] != 2 && level1c[win_combo[counter1, 1]] != 2 && level1c[win_combo[counter1, 2]] != 2)
            {


                while (counter6 < 3)
                {

                    if (level1c[win_combo[counter1, counter6]] != 2 && level1c[win_combo[counter1, counter6]] != 1)
                    {


                        level1c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot();
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;
                        final_stage_array2 = 1;
                        computer_offence_initiator1 = 1;

                    }
                    counter6++;
                }
                return;
            }

        }

        counter5 = 0;
        counter4 = 0;
        counter7 = 0;


    }



    //defence for up and down


    for (counter8 = 0; counter8 < 9; counter8++)
    {
        for (counter9 = 0; counter9 < 3; counter9++)
        {
            sort_level++;
            for (counter10 = 0; counter10 < 5; counter10++)
            {
                if (sort_level % 3 == 0)
                {
                    if (index_array_level3c[counter10] == win_combo_up_down[counter8, counter9])
                    {

                        counter11++;

                    }
                }
                if (sort_level % 3 == 1)
                {
                    if (index_array_level2c[counter10] == win_combo_up_down[counter8, counter9])
                    {

                        counter11++;

                    }
                }
                if (sort_level % 3 == 2)
                {
                    if (index_array_level1c[counter10] == win_combo_up_down[counter8, counter9])
                    {

                        counter11++;

                    }
                }

            }



            if (counter11 == 2 && level3c[win_combo_up_down[counter8, 0]] != 2 && level2c[win_combo_up_down[counter8, 1]] != 2 && level1c[win_combo_up_down[counter8, 2]] != 2)
            {
                counter6 = 0;
                while (counter6 < 3)
                {

                    if ((level3c[win_combo_up_down[counter8, counter6]] != 2 && level3c[win_combo_up_down[counter8, counter6]] != 1) || (level2c[win_combo_up_down[counter8, counter6]] != 2 && level2c[win_combo_up_down[counter8, counter6]] != 1) || (level1c[win_combo_up_down[counter8, counter6]] != 2 && level1c[win_combo_up_down[counter8, counter6]] != 1))
                    {
                        if (counter6 == 0)
                        {
                            level3c[win_combo[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        if (counter6 == 1)
                        {
                            level2c[win_combo[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        if (counter6 == 2)
                        {
                            level1c[win_combo[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }

                        computer_offence_initiator1 = 1;
                        final_stage_array2 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;

                    }
                    counter6++;
                }
                return;
            }





        }



        counter11 = 0;



    }
    counter10 = 0;
    counter11 = 0;
    counter8 = 0;
    counter9 = 0;
    sort_level = 2;

    // defence for diagonal

    for (counter8 = 0; counter8 < 16; counter8++)
    {
        for (counter9 = 0; counter9 < 3; counter9++)
        {
            sort_level++;
            for (counter10 = 0; counter10 < 5; counter10++)
            {
                if (sort_level % 3 == 0)
                {
                    if (index_array_level3c[counter10] == win_combo_diagonal[counter8, counter9])
                    {

                        counter11++;

                    }
                }
                if (sort_level % 3 == 1)
                {
                    if (index_array_level2c[counter10] == win_combo_diagonal[counter8, counter9])
                    {

                        counter11++;

                    }
                }
                if (sort_level % 3 == 2)
                {
                    if (index_array_level1c[counter10] == win_combo_diagonal[counter8, counter9])
                    {

                        counter11++;

                    }
                }

            }


            if (counter11 == 2 && level3c[win_combo_diagonal[counter8, 0]] != 1 && level2c[win_combo_diagonal[counter8, 1]] != 1 && level1c[win_combo_diagonal[counter8, 2]] != 1)
            {
                counter6 = 0;
                while (counter6 < 3)
                {

                    if ((level3c[win_combo_diagonal[counter8, counter6]] != 2 && level3c[win_combo_diagonal[counter8, counter6]] != 1) || (level2c[win_combo_diagonal[counter8, counter6]] != 2 && level2c[win_combo_diagonal[counter8, counter6]] != 1) || (level1c[win_combo_diagonal[counter8, counter6]] != 2 && level1c[win_combo_diagonal[counter8, counter6]] != 1))
                    {
                        if (counter6 == 0)
                        {
                            level3c[win_combo_diagonal[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        if (counter6 == 1)
                        {
                            level2c[win_combo_diagonal[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        if (counter6 == 2)
                        {
                            level1c[win_combo_diagonal[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }

                        computer_offence_initiator1 = 1;
                        final_stage_array2 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;

                    }
                    counter6++;
                }
                return;
            }





        }

        counter11 = 0;

    }

}






void computer_offence2(ref int computer_defence_initiator1, ref int computer_offence_initiator2, ref int final_stage_array1)
{
    int counter1 = 0;
    int counter2 = 0;
    int counter3 = 0;
    int counter4 = 0;
    int counter5 = 0;
    int counter6 = 0;
    int counter7 = 0;
    int counter8 = 0;
    int counter9 = 0;
    int counter10 = 0;
    int counter11 = 0;
    int sort_level = 2;
    int cpu_counter_level3c = 0;
    int cpu_counter_level2c = 0;
    int cpu_counter_level1c = 0;
    int[] index_array_level3c;
    index_array_level3c = new int[5] { 9, 9, 9, 9, 9 };
    int[] index_array_level2c;
    index_array_level2c = new int[5] { 9, 9, 9, 9, 9 };
    int[] index_array_level1c;
    index_array_level1c = new int[5] { 9, 9, 9, 9, 9 };
    int[,] win_combo;
    int[,] win_combo_up_down;
    int[,] win_combo_diagonal;
    win_combo = new int[8, 3] { { 0,1,2 },
{ 3,4,5 },
{ 6,7,8 },
{ 1,4,7 },
{ 0,3,6 },
{ 2,5,8 },
{ 0,4,8 },
{ 2,4,6 } };
    win_combo_up_down = new int[9, 3] { { 0,0,0 },
{ 1,1,1 },
{ 2,2,2 },
{ 3,3,3 },
{ 4,4,4 },
{ 5,5,5 },
{ 6,6,6 },
{ 7,7,7 },
{ 8,8,8 } };
    win_combo_diagonal = new int[16, 3] { { 1,4,7 },
{ 3,4,5 },
{ 5,4,3 },
{ 7,4,1 },
{ 8,4,0 },
{ 8,7,6 },
{ 8,5,2 },
{ 6,4,2 },
{ 6,3,0 },
{ 0,1,2 },
{ 0,3,6 },
{ 0,4,5 },
{ 2,5,8 },
{ 2,4,6 },
{ 2,1,0 },
{ 6,7,8 } };

    //check for level 3,2,1 array cpu slots
    while (counter6 < 9)
    {

        if (level3c[counter6] == 2)
        {
            index_array_level3c[cpu_counter_level3c] = counter6;

            cpu_counter_level3c++;


        }
        if (level2c[counter6] == 2)
        {
            index_array_level2c[cpu_counter_level2c] = counter6;

            cpu_counter_level2c++;


        }
        if (level1c[counter6] == 2)
        {
            index_array_level1c[cpu_counter_level1c] = counter6;

            cpu_counter_level1c++;


        }


        counter6++;

    }


    counter6 = 0;

    //algorithm for filling the cpu win based on 2 cpu slots occupied
    for (counter1 = 0; counter1 < 8; counter1++)
    {
        for (counter2 = 0; counter2 < 3; counter2++)
        {

            for (counter3 = 0; counter3 < 5; counter3++)
            {

                if (index_array_level3c[counter3] == win_combo[counter1, counter2])
                {
                    //counter for level 3 cpu winning two locations
                    counter5++;

                }

                if (index_array_level2c[counter3] == win_combo[counter1, counter2])
                {
                    //counter for level 2 cpu winning two locations
                    counter4++;

                }

                if (index_array_level1c[counter3] == win_combo[counter1, counter2])
                {
                    //counter for level 1 cpu winning two locations
                    counter7++;

                }

            }

            //check level3c to see if whether there is open slot in winning combo
            if (counter5 == 2 && level3c[win_combo[counter1, 0]] != 1 && level3c[win_combo[counter1, 1]] != 1 && level3c[win_combo[counter1, 2]] != 1)
            {
                while (counter6 < 3)
                {
                    if (level3c[win_combo[counter1, counter6]] != 2 && level3c[win_combo[counter1, counter6]] != 1)
                    {
                        level3c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot();
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;

                    }
                    counter6++;
                }
                return;
            }
            //check level2c to see if whether there is open slot in winning combo
            if (counter4 == 2 && level2c[win_combo[counter1, 0]] != 1 && level2c[win_combo[counter1, 1]] != 1 && level2c[win_combo[counter1, 2]] != 1)
            {
                while (counter6 < 3)
                {
                    if (level2c[win_combo[counter1, counter6]] != 2 && level2c[win_combo[counter1, counter6]] != 1)
                    {
                        level2c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot();
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;

                    }
                    counter6++;
                }
                return;
            }


            //check level1c to see if whether there is open slot in winning combo
            if (counter7 == 2 && level1c[win_combo[counter1, 0]] != 1 && level1c[win_combo[counter1, 1]] != 1 && level1c[win_combo[counter1, 2]] != 1)
            {
                while (counter6 < 3)
                {
                    if (level1c[win_combo[counter1, counter6]] != 2 && level1c[win_combo[counter1, counter6]] != 1)
                    {
                        level1c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot();
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;

                    }
                    counter6++;
                }
                return;
            }

        }


        counter5 = 0;
        counter4 = 0;
        counter7 = 0;

    }

    //algorithm for filling the cpu on up and down win based on 2 cpu slots occupied
    for (counter8 = 0; counter8 < 9; counter8++)
    {
        for (counter9 = 0; counter9 < 3; counter9++)
        {
            sort_level++;
            for (counter10 = 0; counter10 < 5; counter10++)
            {
                if (sort_level % 3 == 0)
                {
                    if (index_array_level3c[counter10] == win_combo_up_down[counter8, counter9])
                    {

                        counter11++;

                    }
                }
                if (sort_level % 3 == 1)
                {
                    if (index_array_level2c[counter10] == win_combo_up_down[counter8, counter9])
                    {

                        counter11++;

                    }
                }
                if (sort_level % 3 == 2)
                {
                    if (index_array_level1c[counter10] == win_combo_up_down[counter8, counter9])
                    {

                        counter11++;

                    }
                }

            }


            if (counter11 == 2 && level3c[win_combo_up_down[counter8, 0]] != 1 && level2c[win_combo_up_down[counter8, 1]] != 1 && level1c[win_combo_up_down[counter8, 2]] != 1)
            {
                counter6 = 0;
                while (counter6 < 3)
                {

                    if ((level3c[win_combo_up_down[counter8, counter6]] != 2 && level3c[win_combo_up_down[counter8, counter6]] != 1) || (level2c[win_combo_up_down[counter8, counter6]] != 2 && level2c[win_combo_up_down[counter8, counter6]] != 1) || (level1c[win_combo_up_down[counter8, counter6]] != 2 && level1c[win_combo_up_down[counter8, counter6]] != 1))
                    {
                        if (counter6 == 0)
                        {
                            level3c[win_combo[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        if (counter6 == 1)
                        {
                            level2c[win_combo[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        if (counter6 == 2)
                        {
                            level1c[win_combo[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;

                    }
                    counter6++;
                }
                return;
            }





        }

        counter11 = 0;

    }


    counter8 = 0;
    counter9 = 0;
    counter10 = 0;
    counter11 = 0;
    sort_level = 2;

    //algorithm for filling the cpu on diagonal win based on 2 cpu slots occupied
    for (counter8 = 0; counter8 < 16; counter8++)
    {
        for (counter9 = 0; counter9 < 3; counter9++)
        {
            sort_level++;
            for (counter10 = 0; counter10 < 5; counter10++)
            {
                if (sort_level % 3 == 0)
                {
                    if (index_array_level3c[counter10] == win_combo_diagonal[counter8, counter9])
                    {

                        counter11++;

                    }
                }
                if (sort_level % 3 == 1)
                {
                    if (index_array_level2c[counter10] == win_combo_diagonal[counter8, counter9])
                    {

                        counter11++;

                    }
                }
                if (sort_level % 3 == 2)
                {
                    if (index_array_level1c[counter10] == win_combo_diagonal[counter8, counter9])
                    {

                        counter11++;

                    }
                }

            }


            if (counter11 == 2 && level3c[win_combo_diagonal[counter8, 0]] != 1 && level2c[win_combo_diagonal[counter8, 1]] != 1 && level1c[win_combo_diagonal[counter8, 2]] != 1)
            {
                counter6 = 0;
                while (counter6 < 3)
                {

                    if ((level3c[win_combo_diagonal[counter8, counter6]] != 2 && level3c[win_combo_diagonal[counter8, counter6]] != 1) || (level2c[win_combo_diagonal[counter8, counter6]] != 2 && level2c[win_combo_diagonal[counter8, counter6]] != 1) || (level1c[win_combo_diagonal[counter8, counter6]] != 2 && level1c[win_combo_diagonal[counter8, counter6]] != 1))
                    {
                        if (counter6 == 0)
                        {
                            level3c[win_combo_diagonal[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        if (counter6 == 1)
                        {
                            level2c[win_combo_diagonal[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        if (counter6 == 2)
                        {
                            level1c[win_combo_diagonal[counter8, counter6]] = 2;
                            fill_cpu_color_slot();
                        }
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;

                    }
                    counter6++;
                }
                return;
            }





        }

        counter11 = 0;

    }





}






void computer_offence1( ref int final_stage_array3)
{
    int counter1 = 0;
    int counter2 = 0;
    int counter3 = 0;
    int counter5 = 0;
    int counter6 = 0;
    int counter7 = 0;
    int counter8 = 0;
    int cpu_counter_level3c = 0;
    int cpu_counter_level2c = 0;
    int cpu_counter_level1c = 0;
    int[] index_array_level3c;
    index_array_level3c = new int[5] { 9, 9, 9, 9, 9 };
    int[] index_array_level2c;
    index_array_level2c = new int[5] { 9, 9, 9, 9, 9 };
    int[] index_array_level1c;
    index_array_level1c = new int[5] { 9, 9, 9, 9, 9 };
    int[,] win_combo;
    win_combo = new int[8, 3] { { 0,1,2 },
{ 3,4,5 },
{ 6,7,8 },
{ 1,4,7 },
{ 0,3,6 },
{ 2,5,8 },
{ 0,4,8 },
{ 2,4,6 } };

    //check where the cpu slots are

    while (counter6 < 9)
    {

        if (level3c[counter6] == 2)
        {
            index_array_level3c[cpu_counter_level3c] = counter6;

            cpu_counter_level3c++;


        }
        if (level2c[counter6] == 2)
        {
            index_array_level2c[cpu_counter_level2c] = counter6;

            cpu_counter_level2c++;


        }
        if (level1c[counter6] == 2)
        {
            index_array_level1c[cpu_counter_level1c] = counter6;

            cpu_counter_level1c++;


        }


        counter6++;

    }


    counter6 = 0;


    for ( counter1 = 0; counter1 < 8; counter1++)
    {
        for ( counter2 = 0; counter2 < 3; counter2++)
        {

            for ( counter3 = 0; counter3 < 5; counter3++)
            {

                if (index_array_level3c[counter3] == win_combo[counter1,counter2] && level3c[win_combo[counter1,0]] != 1 && level3c[win_combo[counter1,1]] != 1 && level3c[win_combo[counter1,2]] != 1)
                {
                    counter5++;

                }

                if (index_array_level2c[counter3] == win_combo[counter1, counter2] && level2c[win_combo[counter1, 0]] != 1 && level2c[win_combo[counter1, 1]] != 1 && level2c[win_combo[counter1, 2]] != 1)
                {
                    counter7++;

                }

                if (index_array_level1c[counter3] == win_combo[counter1, counter2] && level1c[win_combo[counter1, 0]] != 1 && level1c[win_combo[counter1, 1]] != 1 && level1c[win_combo[counter1, 2]] != 1)
                {
                    counter8++;

                }


            }
            //fill level3c
            if (counter5 == 1)
            {
                while (counter6 < 3)
                {

                    if (level3c[win_combo[counter1,counter6]] != 2 && level3c[win_combo[counter1,counter6]] != 1)
                    {
                        level3c[win_combo[counter1,counter6]] = 2;
                        fill_cpu_color_slot();
                        final_stage_array3 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;


                    }

                    counter6++;

                }
                return;

            }
            //fill level2c
            if (counter7 == 1)
            {
                while (counter6 < 3)
                {

                    if (level2c[win_combo[counter1, counter6]] != 2 && level2c[win_combo[counter1, counter6]] != 1)
                    {
                        level2c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot();
                        final_stage_array3 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;


                    }

                    counter6++;

                }
                return;
            }

            //fill level1c
            if (counter8 == 1)
            {
                while (counter6 < 3)
                {

                    if (level1c[win_combo[counter1, counter6]] != 2 && level1c[win_combo[counter1, counter6]] != 1)
                    {
                        level1c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot();
                        final_stage_array3 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;


                    }

                    counter6++;

                }
                return;
            }


            counter5 = 0;
            counter7 = 0;
            counter8 = 0;

        }
    }







}





    

     //function for filling the cpu slot red
     void fill_cpu_color_slot()
     {

         if (gameObject.tag == "Cube0" && level3c[0] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube1" && level3c[1] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube2" && level3c[2] == 2)
         {






             gameObject.GetComponent<Renderer>().material.color = Color.red;




         }
         if (gameObject.tag == "Cube3" && level3c[3] == 2)
         {





             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube4" && level3c[4] == 2)
         {





             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube5" && level3c[5] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube6" && level3c[6] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube7" && level3c[7] == 2)
         {



             gameObject.GetComponent<Renderer>().material.color = Color.red;
         }
         if (gameObject.tag == "Cube8" && level3c[8] == 2)
         {



             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube9" && level2c[0] == 2)
         {

             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube10" && level2c[1] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;


         }
         if (gameObject.tag == "Cube11" && level2c[2] == 2)
         {




             gameObject.GetComponent<Renderer>().material.color = Color.red;


         }
         if (gameObject.tag == "Cube12" && level2c[3] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;


         }
         if (gameObject.tag == "Cube13" && level2c[4] == 2)
         {

             gameObject.GetComponent<Renderer>().material.color = Color.red;


         }
         if (gameObject.tag == "Cube14" && level2c[5] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;


         }
         if (gameObject.tag == "Cube15" && level2c[6] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;


         }
         if (gameObject.tag == "Cube16" && level2c[7] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;


         }
         if (gameObject.tag == "Cube17" && level2c[8] == 2)
         {



             gameObject.GetComponent<Renderer>().material.color = Color.red;


         }
         if (gameObject.tag == "Cube18" && level1c[0] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;


         }
         if (gameObject.tag == "Cube19" && level1c[1] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube20" && level1c[2] == 2)
         {



             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube21" && level1c[3] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube22" && level1c[4] == 2)
         {


             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube23" && level1c[5] == 2)
         {

             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube24" && level1c[6] == 2)
         {



             gameObject.GetComponent<Renderer>().material.color = Color.red;
         }
         if (gameObject.tag == "Cube25" && level1c[7] == 2)
         {

             gameObject.GetComponent<Renderer>().material.color = Color.red;

         }
         if (gameObject.tag == "Cube26" && level1c[8] == 2)
         {



             gameObject.GetComponent<Renderer>().material.color = Color.red;
         }
     }





 }

   
    
