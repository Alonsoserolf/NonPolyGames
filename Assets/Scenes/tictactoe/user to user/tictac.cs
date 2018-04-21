
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class tictac : MonoBehaviour
{

    public static int[] level1;
    public static int[] level2;
    public static int[] level3;
    private static int player_turn;
    public static int mode_choice = 1;
    public Text player_turn_text;
    public Text player_won_text;
    private int player_turn_text_overrule = 0;
    public Button restart_button;
    public static GameObject current_cube0; public static GameObject current_cube1; public static GameObject current_cube2; public static GameObject current_cube3; public static GameObject current_cube4; public static GameObject current_cube5; public static GameObject current_cube6; public static GameObject current_cube7; public static GameObject current_cube8;
    public static GameObject current_cube9; public static GameObject current_cube10; public static GameObject current_cube11; public static GameObject current_cube12; public static GameObject current_cube13; public static GameObject current_cube14; public static GameObject current_cube15; public static GameObject current_cube16; public static GameObject current_cube17;
    public static GameObject current_cube18; public static GameObject current_cube19; public static GameObject current_cube20; public static GameObject current_cube21; public static GameObject current_cube22; public static GameObject current_cube23; public static GameObject current_cube24; public static GameObject current_cube25; public static GameObject current_cube26;
    public static void mode_choice_func()
    {
        mode_choice = 0;

    }


    private void checkWin()
    {


        ///player1 checkwin///

        if (level3[0] == 1 && level3[1] == 1 && level3[2] == 1 || level3[3] == 1 && level3[4] == 1 && level3[5] == 1 || level3[6] == 1 && level3[7] == 1 && level3[8] == 1 || level3[1] == 1 && level3[4] == 1 && level3[7] == 1 || level3[0] == 1 && level3[3] == 1 && level3[6] == 1 || level3[2] == 1 && level3[5] == 1 && level3[8] == 1 || level3[0] == 1 && level3[4] == 1 && level3[8] == 1 || level3[2] == 1 && level3[4] == 1 && level3[6] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 1 won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            mode_choice = 1;


            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(1);           
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;


        }
        if (level2[0] == 1 && level2[1] == 1 && level2[2] == 1 || level2[3] == 1 && level2[4] == 1 && level2[5] == 1 || level2[6] == 1 && level2[7] == 1 && level2[8] == 1 || level2[1] == 1 && level2[4] == 1 && level2[7] == 1 || level2[0] == 1 && level2[3] == 1 && level2[6] == 1 || level2[2] == 1 && level2[5] == 1 && level2[8] == 1 || level2[0] == 1 && level2[4] == 1 && level2[8] == 1 || level2[2] == 1 && level2[4] == 1 && level2[6] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 1 won,click Restart or Return ";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            mode_choice = 1;

            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(1);
            
            current_cube0 = GameObject.FindWithTag("Cube9"); current_cube1 = GameObject.FindWithTag("Cube10"); current_cube2 = GameObject.FindWithTag("Cube11"); current_cube3 = GameObject.FindWithTag("Cube12"); current_cube4 = GameObject.FindWithTag("Cube13"); current_cube5 = GameObject.FindWithTag("Cube14"); current_cube6 = GameObject.FindWithTag("Cube15"); current_cube7 = GameObject.FindWithTag("Cube16"); current_cube8 = GameObject.FindWithTag("Cube17");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;
            
        }


        if (level1[0] == 1 && level1[1] == 1 && level1[2] == 1 || level1[3] == 1 && level1[4] == 1 && level1[5] == 1 || level1[6] == 1 && level1[7] == 1 && level1[8] == 1 || level1[1] == 1 && level1[4] == 1 && level1[7] == 1 || level1[0] == 1 && level1[3] == 1 && level1[6] == 1 || level1[2] == 1 && level1[5] == 1 && level1[8] == 1 || level1[0] == 1 && level1[4] == 1 && level1[8] == 1 || level1[2] == 1 && level1[4] == 1 && level1[6] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 1 won,click Restart or Return ";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            mode_choice = 1;
           
            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(1);
            current_cube0 = GameObject.FindWithTag("Cube18"); current_cube1 = GameObject.FindWithTag("Cube19"); current_cube2 = GameObject.FindWithTag("Cube20"); current_cube3 = GameObject.FindWithTag("Cube21"); current_cube4 = GameObject.FindWithTag("Cube22"); current_cube5 = GameObject.FindWithTag("Cube23"); current_cube6 = GameObject.FindWithTag("Cube24"); current_cube7 = GameObject.FindWithTag("Cube25"); current_cube8 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;

        }


        if (level3[0] == 1 && level2[0] == 1 && level1[0] == 1 || level3[1] == 1 && level2[1] == 1 && level1[1] == 1 || level3[2] == 1 && level2[2] == 1 && level1[2] == 1 || level3[3] == 1 && level2[3] == 1 && level1[3] == 1 || level3[4] == 1 && level2[4] == 1 && level1[4] == 1 || level3[5] == 1 && level2[5] == 1 && level1[5] == 1 || level3[6] == 1 && level2[6] == 1 && level1[6] == 1 || level3[7] == 1 && level2[7] == 1 && level1[7] == 1 || level3[8] == 1 && level2[8] == 1 && level1[8] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 1 won,click Restart or Return ";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            mode_choice = 1;
          
            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(1);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube9 = GameObject.FindWithTag("Cube9"); current_cube10 = GameObject.FindWithTag("Cube10"); current_cube11 = GameObject.FindWithTag("Cube11"); current_cube12 = GameObject.FindWithTag("Cube12"); current_cube13 = GameObject.FindWithTag("Cube13"); current_cube14 = GameObject.FindWithTag("Cube14"); current_cube15 = GameObject.FindWithTag("Cube15"); current_cube16 = GameObject.FindWithTag("Cube16"); current_cube17 = GameObject.FindWithTag("Cube17");
            current_cube18 = GameObject.FindWithTag("Cube18"); current_cube19 = GameObject.FindWithTag("Cube19"); current_cube20 = GameObject.FindWithTag("Cube20"); current_cube21 = GameObject.FindWithTag("Cube21"); current_cube22 = GameObject.FindWithTag("Cube22"); current_cube23 = GameObject.FindWithTag("Cube23"); current_cube24 = GameObject.FindWithTag("Cube24"); current_cube25 = GameObject.FindWithTag("Cube25"); current_cube26 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;
            current_cube9.GetComponent<make_cubes_blink2>().enabled = true; current_cube10.GetComponent<make_cubes_blink2>().enabled = true; current_cube11.GetComponent<make_cubes_blink2>().enabled = true; current_cube12.GetComponent<make_cubes_blink2>().enabled = true; current_cube13.GetComponent<make_cubes_blink2>().enabled = true; current_cube14.GetComponent<make_cubes_blink2>().enabled = true; current_cube15.GetComponent<make_cubes_blink2>().enabled = true; current_cube16.GetComponent<make_cubes_blink2>().enabled = true; current_cube17.GetComponent<make_cubes_blink2>().enabled = true;
            current_cube18.GetComponent<make_cubes_blink2>().enabled = true; current_cube19.GetComponent<make_cubes_blink2>().enabled = true; current_cube20.GetComponent<make_cubes_blink2>().enabled = true; current_cube21.GetComponent<make_cubes_blink2>().enabled = true; current_cube22.GetComponent<make_cubes_blink2>().enabled = true; current_cube23.GetComponent<make_cubes_blink2>().enabled = true; current_cube24.GetComponent<make_cubes_blink2>().enabled = true; current_cube25.GetComponent<make_cubes_blink2>().enabled = true; current_cube26.GetComponent<make_cubes_blink2>().enabled = true;

        }

        if (level3[1] == 1 && level2[4] == 1 && level1[7] == 1 || level3[3] == 1 && level2[4] == 1 && level1[5] == 1 || level3[5] == 1 && level2[4] == 1 && level1[3] == 1 || level3[7] == 1 && level2[4] == 1 && level1[1] == 1 || level3[8] == 1 && level2[4] == 1 && level1[0] == 1 || level3[8] == 1 && level2[5] == 1 && level1[2] == 1 || level3[8] == 1 && level2[4] == 1 && level1[0] == 1 || level3[6] == 1 && level2[4] == 1 && level1[2] == 1 || level3[6] == 1 && level2[7] == 1 && level1[8] == 1 || level3[6] == 1 && level2[3] == 1 && level1[0] == 1 || level3[0] == 1 && level2[1] == 1 && level1[2] == 1 || level3[0] == 1 && level2[3] == 1 && level1[6] == 1  || level3[2] == 1 && level2[5] == 1 && level1[8] == 1 || level3[2] == 1 && level2[4] == 1 && level1[6] == 1 || level3[2] == 1 && level2[1] == 1 && level1[0] == 1 || level3[8] == 1 && level2[7] == 1 && level1[6] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 1 won,click Restart or Return ";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            
            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(1);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube9 = GameObject.FindWithTag("Cube9"); current_cube10 = GameObject.FindWithTag("Cube10"); current_cube11 = GameObject.FindWithTag("Cube11"); current_cube12 = GameObject.FindWithTag("Cube12"); current_cube13 = GameObject.FindWithTag("Cube13"); current_cube14 = GameObject.FindWithTag("Cube14"); current_cube15 = GameObject.FindWithTag("Cube15"); current_cube16 = GameObject.FindWithTag("Cube16"); current_cube17 = GameObject.FindWithTag("Cube17");
            current_cube18 = GameObject.FindWithTag("Cube18"); current_cube19 = GameObject.FindWithTag("Cube19"); current_cube20 = GameObject.FindWithTag("Cube20"); current_cube21 = GameObject.FindWithTag("Cube21"); current_cube22 = GameObject.FindWithTag("Cube22"); current_cube23 = GameObject.FindWithTag("Cube23"); current_cube24 = GameObject.FindWithTag("Cube24"); current_cube25 = GameObject.FindWithTag("Cube25"); current_cube26 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;
            current_cube9.GetComponent<make_cubes_blink2>().enabled = true; current_cube10.GetComponent<make_cubes_blink2>().enabled = true; current_cube11.GetComponent<make_cubes_blink2>().enabled = true; current_cube12.GetComponent<make_cubes_blink2>().enabled = true; current_cube13.GetComponent<make_cubes_blink2>().enabled = true; current_cube14.GetComponent<make_cubes_blink2>().enabled = true; current_cube15.GetComponent<make_cubes_blink2>().enabled = true; current_cube16.GetComponent<make_cubes_blink2>().enabled = true; current_cube17.GetComponent<make_cubes_blink2>().enabled = true;
            current_cube18.GetComponent<make_cubes_blink2>().enabled = true; current_cube19.GetComponent<make_cubes_blink2>().enabled = true; current_cube20.GetComponent<make_cubes_blink2>().enabled = true; current_cube21.GetComponent<make_cubes_blink2>().enabled = true; current_cube22.GetComponent<make_cubes_blink2>().enabled = true; current_cube23.GetComponent<make_cubes_blink2>().enabled = true; current_cube24.GetComponent<make_cubes_blink2>().enabled = true; current_cube25.GetComponent<make_cubes_blink2>().enabled = true; current_cube26.GetComponent<make_cubes_blink2>().enabled = true;

        }


        ///player2 check win///

        if (level3[0] == 2 && level3[1] == 2 && level3[2] == 2 || level3[3] == 2 && level3[4] == 2 && level3[5] == 2 || level3[6] == 2 && level3[7] == 2 && level3[8] == 2 || level3[1] == 2 && level3[4] == 2 && level3[7] == 2 || level3[0] == 2 && level3[3] == 2 && level3[6] == 2 || level3[2] == 2 && level3[5] == 2 && level3[8] == 2 || level3[0] == 2 && level3[4] == 2 && level3[8] == 2 || level3[2] == 2 && level3[4] == 2 && level3[6] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 2 won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            
            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;

        }

        if (level2[0] == 2 && level2[1] == 2 && level2[2] == 2 || level2[3] == 2 && level2[4] == 2 && level2[5] == 2 || level2[6] == 2 && level2[7] == 2 && level2[8] == 2 || level2[1] == 2 && level2[4] == 2 && level2[7] == 2 || level2[0] == 2 && level2[3] == 2 && level2[6] == 2 || level2[2] == 2 && level2[5] == 2 && level2[8] == 2 || level2[0] == 2 && level2[4] == 2 && level2[8] == 2 || level2[2] == 2 && level2[4] == 2 && level2[6] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 2 won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            
            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube9"); current_cube1 = GameObject.FindWithTag("Cube10"); current_cube2 = GameObject.FindWithTag("Cube11"); current_cube3 = GameObject.FindWithTag("Cube12"); current_cube4 = GameObject.FindWithTag("Cube13"); current_cube5 = GameObject.FindWithTag("Cube14"); current_cube6 = GameObject.FindWithTag("Cube15"); current_cube7 = GameObject.FindWithTag("Cube16"); current_cube8 = GameObject.FindWithTag("Cube17");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;


        }
        if (level1[0] == 2 && level1[1] == 2 && level1[2] == 2 || level1[3] == 2 && level1[4] == 2 && level1[5] == 2 || level1[6] == 2 && level1[7] == 2 && level1[8] == 2 || level1[1] == 2 && level1[4] == 2 && level1[7] == 2 || level1[0] == 2 && level1[3] == 2 && level1[6] == 2 || level1[2] == 2 && level1[5] == 2 && level1[8] == 2 || level1[0] == 2 && level1[4] == 2 && level1[8] == 2 || level1[2] == 2 && level1[4] == 2 && level1[6] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 2 won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
        
            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube18"); current_cube1 = GameObject.FindWithTag("Cube19"); current_cube2 = GameObject.FindWithTag("Cube20"); current_cube3 = GameObject.FindWithTag("Cube21"); current_cube4 = GameObject.FindWithTag("Cube22"); current_cube5 = GameObject.FindWithTag("Cube23"); current_cube6 = GameObject.FindWithTag("Cube24"); current_cube7 = GameObject.FindWithTag("Cube25"); current_cube8 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;

        }
        if (level3[0] == 2 && level2[0] == 2 && level1[0] == 2 || level3[1] == 2 && level2[1] == 2 && level1[1] == 2 || level3[2] == 2 && level2[2] == 2 && level1[2] == 2 || level3[3] == 2 && level2[3] == 2 && level1[3] == 2 || level3[4] == 2 && level2[4] == 2 && level1[4] == 2 || level3[5] == 2 && level2[5] == 2 && level1[5] == 2 || level3[6] == 2 && level2[6] == 2 && level1[6] == 2 || level3[7] == 2 && level2[7] == 2 && level1[7] == 2 || level3[8] == 2 && level2[8] == 2 && level1[8] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 2 won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
           
            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube9 = GameObject.FindWithTag("Cube9"); current_cube10 = GameObject.FindWithTag("Cube10"); current_cube11 = GameObject.FindWithTag("Cube11"); current_cube12 = GameObject.FindWithTag("Cube12"); current_cube13 = GameObject.FindWithTag("Cube13"); current_cube14 = GameObject.FindWithTag("Cube14"); current_cube15 = GameObject.FindWithTag("Cube15"); current_cube16 = GameObject.FindWithTag("Cube16"); current_cube17 = GameObject.FindWithTag("Cube17");
            current_cube18 = GameObject.FindWithTag("Cube18"); current_cube19 = GameObject.FindWithTag("Cube19"); current_cube20 = GameObject.FindWithTag("Cube20"); current_cube21 = GameObject.FindWithTag("Cube21"); current_cube22 = GameObject.FindWithTag("Cube22"); current_cube23 = GameObject.FindWithTag("Cube23"); current_cube24 = GameObject.FindWithTag("Cube24"); current_cube25 = GameObject.FindWithTag("Cube25"); current_cube26 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;
            current_cube9.GetComponent<make_cubes_blink2>().enabled = true; current_cube10.GetComponent<make_cubes_blink2>().enabled = true; current_cube11.GetComponent<make_cubes_blink2>().enabled = true; current_cube12.GetComponent<make_cubes_blink2>().enabled = true; current_cube13.GetComponent<make_cubes_blink2>().enabled = true; current_cube14.GetComponent<make_cubes_blink2>().enabled = true; current_cube15.GetComponent<make_cubes_blink2>().enabled = true; current_cube16.GetComponent<make_cubes_blink2>().enabled = true; current_cube17.GetComponent<make_cubes_blink2>().enabled = true;
            current_cube18.GetComponent<make_cubes_blink2>().enabled = true; current_cube19.GetComponent<make_cubes_blink2>().enabled = true; current_cube20.GetComponent<make_cubes_blink2>().enabled = true; current_cube21.GetComponent<make_cubes_blink2>().enabled = true; current_cube22.GetComponent<make_cubes_blink2>().enabled = true; current_cube23.GetComponent<make_cubes_blink2>().enabled = true; current_cube24.GetComponent<make_cubes_blink2>().enabled = true; current_cube25.GetComponent<make_cubes_blink2>().enabled = true; current_cube26.GetComponent<make_cubes_blink2>().enabled = true;

        }
        if (level3[1] == 2 && level2[4] == 2 && level1[7] == 2 || level3[3] == 2 && level2[4] == 2 && level1[5] == 2 || level3[5] == 2 && level2[4] == 2 && level1[3] == 2 || level3[7] == 2 && level2[4] == 2 && level1[1] == 2 || level3[8] == 2 && level2[4] == 2 && level1[0] == 2 || level3[8] == 2 && level2[7] == 2 && level1[6] == 2 || level3[8] == 2 && level2[5] == 2 && level1[2] == 2 || level3[8] == 2 && level2[4] == 2 && level1[0] == 2 || level3[6] == 2 && level2[4] == 2 && level1[2] == 2 || level3[6] == 2 && level2[7] == 2 && level1[8] == 2 || level3[6] == 2 && level2[3] == 2 && level1[0] == 2 || level3[0] == 2 && level2[1] == 2 && level1[2] == 2 || level3[0] == 2 && level2[3] == 2 && level1[6] == 2  || level3[2] == 2 && level2[5] == 2 && level1[8] == 2 || level3[2] == 2 && level2[4] == 2 && level1[6] == 2 || level3[2] == 2 && level2[1] == 2 && level1[0] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Player 2 won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
           
            restart_button.gameObject.SetActive(true);
            make_cubes_blink2.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube9 = GameObject.FindWithTag("Cube9"); current_cube10 = GameObject.FindWithTag("Cube10"); current_cube11 = GameObject.FindWithTag("Cube11"); current_cube12 = GameObject.FindWithTag("Cube12"); current_cube13 = GameObject.FindWithTag("Cube13"); current_cube14 = GameObject.FindWithTag("Cube14"); current_cube15 = GameObject.FindWithTag("Cube15"); current_cube16 = GameObject.FindWithTag("Cube16"); current_cube17 = GameObject.FindWithTag("Cube17");
            current_cube18 = GameObject.FindWithTag("Cube18"); current_cube19 = GameObject.FindWithTag("Cube19"); current_cube20 = GameObject.FindWithTag("Cube20"); current_cube21 = GameObject.FindWithTag("Cube21"); current_cube22 = GameObject.FindWithTag("Cube22"); current_cube23 = GameObject.FindWithTag("Cube23"); current_cube24 = GameObject.FindWithTag("Cube24"); current_cube25 = GameObject.FindWithTag("Cube25"); current_cube26 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink2>().enabled = true; current_cube1.GetComponent<make_cubes_blink2>().enabled = true; current_cube2.GetComponent<make_cubes_blink2>().enabled = true; current_cube3.GetComponent<make_cubes_blink2>().enabled = true; current_cube4.GetComponent<make_cubes_blink2>().enabled = true; current_cube5.GetComponent<make_cubes_blink2>().enabled = true; current_cube6.GetComponent<make_cubes_blink2>().enabled = true; current_cube7.GetComponent<make_cubes_blink2>().enabled = true; current_cube8.GetComponent<make_cubes_blink2>().enabled = true;
            current_cube9.GetComponent<make_cubes_blink2>().enabled = true; current_cube10.GetComponent<make_cubes_blink2>().enabled = true; current_cube11.GetComponent<make_cubes_blink2>().enabled = true; current_cube12.GetComponent<make_cubes_blink2>().enabled = true; current_cube13.GetComponent<make_cubes_blink2>().enabled = true; current_cube14.GetComponent<make_cubes_blink2>().enabled = true; current_cube15.GetComponent<make_cubes_blink2>().enabled = true; current_cube16.GetComponent<make_cubes_blink2>().enabled = true; current_cube17.GetComponent<make_cubes_blink2>().enabled = true;
            current_cube18.GetComponent<make_cubes_blink2>().enabled = true; current_cube19.GetComponent<make_cubes_blink2>().enabled = true; current_cube20.GetComponent<make_cubes_blink2>().enabled = true; current_cube21.GetComponent<make_cubes_blink2>().enabled = true; current_cube22.GetComponent<make_cubes_blink2>().enabled = true; current_cube23.GetComponent<make_cubes_blink2>().enabled = true; current_cube24.GetComponent<make_cubes_blink2>().enabled = true; current_cube25.GetComponent<make_cubes_blink2>().enabled = true; current_cube26.GetComponent<make_cubes_blink2>().enabled = true;

        }


        if (player_turn_text_overrule == 0)
        {
            if (player_turn == 1)
            {
                player_turn_text.text = "Player 2 turn";

                player_turn_text.color = Color.red;


            }

            else
            {
                player_turn_text.text = "Player 1 turn";
                player_turn_text.color = Color.blue;
            }
        }


    }

    void check_draw()
    {
        int counter = 0;
        while (counter < 9)
        {
            if (level3[counter] == 0 || level2[counter] == 0 || level1[counter] == 0)
            {
                return;
            }
            else
            {

                counter++;
            }
        }
        player_turn_text.text = "";
        player_won_text.text = "The game is a draw,click Restart or Return ";
        player_won_text.color = Color.green;
        player_turn_text_overrule = 1;
        mode_choice = 1;
        restart_button.gameObject.SetActive(true);


    }

    // Use this for initialization

    void Start()
    {

        level1 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        level2 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        level3 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        player_turn = 0;
       

        


    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnMouseDown()
    {
       
        if (Input.GetMouseButton(0) && mode_choice == 0)
        {

            if (gameObject.tag == "Cube0" && level3[0] == 0)
            {
                if (player_turn == 0)
                    level3[0] = 1;
                else
                    level3[0] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube1" && level3[1] == 0)
            {
                if (player_turn == 0)
                    level3[1] = 1;
                else
                    level3[1] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube2" && level3[2] == 0)
            {
                if (player_turn == 0)
                    level3[2] = 1;
                else
                    level3[2] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube3" && level3[3] == 0)
            {
                if (player_turn == 0)
                    level3[3] = 1;
                else
                    level3[3] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube4" && level3[4] == 0)
            {
                if (player_turn == 0)
                    level3[4] = 1;
                else
                    level3[4] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube5" && level3[5] == 0)
            {
                if (player_turn == 0)
                    level3[5] = 1;
                else
                    level3[5] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube6" && level3[6] == 0)
            {
                if (player_turn == 0)
                    level3[6] = 1;
                else
                    level3[6] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube7" && level3[7] == 0)
            {
                if (player_turn == 0)
                    level3[7] = 1;
                else
                    level3[7] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube8" && level3[8] == 0)
            {
                if (player_turn == 0)
                    level3[8] = 1;
                else
                    level3[8] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube9" && level2[0] == 0)
            {
                if (player_turn == 0)
                    level2[0] = 1;
                else
                    level2[0] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube10" && level2[1] == 0)
            {
                if (player_turn == 0)
                    level2[1] = 1;
                else
                    level2[1] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube11" && level2[2] == 0)
            {
                if (player_turn == 0)
                    level2[2] = 1;
                else
                    level2[2] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube12" && level2[3] == 0)
            {
                if (player_turn == 0)
                    level2[3] = 1;
                else
                    level2[3] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube13" && level2[4] == 0)
            {
                if (player_turn == 0)
                    level2[4] = 1;
                else
                    level2[4] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube14" && level2[5] == 0)
            {
                if (player_turn == 0)
                    level2[5] = 1;
                else
                    level2[5] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube15" && level2[6] == 0)
            {
                if (player_turn == 0)
                    level2[6] = 1;
                else
                    level2[6] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube16" && level2[7] == 0)
            {
                if (player_turn == 0)
                    level2[7] = 1;
                else
                    level2[7] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube17" && level2[8] == 0)
            {
                if (player_turn == 0)
                    level2[8] = 1;
                else
                    level2[8] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube18" && level1[0] == 0)
            {
                if (player_turn == 0)
                    level1[0] = 1;
                else
                    level1[0] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube19" && level1[1] == 0)
            {
                if (player_turn == 0)
                    level1[1] = 1;
                else
                    level1[1] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube20" && level1[2] == 0)
            {
                if (player_turn == 0)
                    level1[2] = 1;
                else
                    level1[2] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube21" && level1[3] == 0)
            {
                if (player_turn == 0)
                    level1[3] = 1;
                else
                    level1[3] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube22" && level1[4] == 0)
            {
                if (player_turn == 0)
                    level1[4] = 1;
                else
                    level1[4] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube23" && level1[5] == 0)
            {
                if (player_turn == 0)
                    level1[5] = 1;
                else
                    level1[5] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube24" && level1[6] == 0)
            {
                if (player_turn == 0)
                    level1[6] = 1;
                else
                    level1[6] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube25" && level1[7] == 0)
            {
                if (player_turn == 0)
                    level1[7] = 1;
                else
                    level1[7] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }

            }
            if (gameObject.tag == "Cube26" && level1[8] == 0)
            {
                if (player_turn == 0)
                    level1[8] = 1;
                else
                    level1[8] = 2;
                if (player_turn == 0)
                {

                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    player_turn = 1;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    player_turn = 0;
                }
            }

            checkWin();
        }


    }


}
