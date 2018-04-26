using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class tictac_cpu_mode : MonoBehaviour
{

    private GameObject find_cube;
    public static int[] level1c;
    public static int[] level2c;
    public static int[] level3c;
    public static int mode_choice = 0;
    public Text player_turn_text;
    public Text player_won_text;
    private int player_turn_text_overrule = 0;
    public Button restart_button;
    int[,] win_combo;
    int[,] win_combo_up_down;
    int[,] win_combo_diagonal;
    public static GameObject current_cube0; public static GameObject current_cube1; public static GameObject current_cube2; public static GameObject current_cube3; public static GameObject current_cube4; public static GameObject current_cube5; public static GameObject current_cube6; public static GameObject current_cube7; public static GameObject current_cube8;
    public static GameObject current_cube9; public static GameObject current_cube10; public static GameObject current_cube11; public static GameObject current_cube12; public static GameObject current_cube13; public static GameObject current_cube14; public static GameObject current_cube15; public static GameObject current_cube16; public static GameObject current_cube17;
    public static GameObject current_cube18; public static GameObject current_cube19; public static GameObject current_cube20; public static GameObject current_cube21; public static GameObject current_cube22; public static GameObject current_cube23; public static GameObject current_cube24; public static GameObject current_cube25; public static GameObject current_cube26;
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
            mode_choice = 1;
           
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(1);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1");current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;
            
        }
        //check for level2c only win
        if (level2c[0] == 1 && level2c[1] == 1 && level2c[2] == 1 || level2c[3] == 1 && level2c[4] == 1 && level2c[5] == 1 || level2c[6] == 1 && level2c[7] == 1 && level2c[8] == 1 || level2c[1] == 1 && level2c[4] == 1 && level2c[7] == 1 || level2c[0] == 1 && level2c[3] == 1 && level2c[6] == 1 || level2c[2] == 1 && level2c[5] == 1 && level2c[8] == 1 || level2c[0] == 1 && level2c[4] == 1 && level2c[8] == 1 || level2c[2] == 1 && level2c[4] == 1 && level2c[6] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "You won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            mode_choice = 1;
          
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(1);
            current_cube0 = GameObject.FindWithTag("Cube9"); current_cube1 = GameObject.FindWithTag("Cube10"); current_cube2 = GameObject.FindWithTag("Cube11"); current_cube3 = GameObject.FindWithTag("Cube12"); current_cube4 = GameObject.FindWithTag("Cube13"); current_cube5 = GameObject.FindWithTag("Cube14"); current_cube6 = GameObject.FindWithTag("Cube15"); current_cube7 = GameObject.FindWithTag("Cube16"); current_cube8 = GameObject.FindWithTag("Cube17");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;
           
        }

        //check for level1c only win
        if (level1c[0] == 1 && level1c[1] == 1 && level1c[2] == 1 || level1c[3] == 1 && level1c[4] == 1 && level1c[5] == 1 || level1c[6] == 1 && level1c[7] == 1 && level1c[8] == 1 || level1c[1] == 1 && level1c[4] == 1 && level1c[7] == 1 || level1c[0] == 1 && level1c[3] == 1 && level1c[6] == 1 || level1c[2] == 1 && level1c[5] == 1 && level1c[8] == 1 || level1c[0] == 1 && level1c[4] == 1 && level1c[8] == 1 || level1c[2] == 1 && level1c[4] == 1 && level1c[6] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "You won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(1);
            current_cube0 = GameObject.FindWithTag("Cube18"); current_cube1 = GameObject.FindWithTag("Cube19"); current_cube2 = GameObject.FindWithTag("Cube20"); current_cube3 = GameObject.FindWithTag("Cube21"); current_cube4 = GameObject.FindWithTag("Cube22"); current_cube5 = GameObject.FindWithTag("Cube23"); current_cube6 = GameObject.FindWithTag("Cube24"); current_cube7 = GameObject.FindWithTag("Cube25"); current_cube8 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;
            
        }

        //check for up and down level win
        if (level3c[0] == 1 && level2c[0] == 1 && level1c[0] == 1 || level3c[1] == 1 && level2c[1] == 1 && level1c[1] == 1 || level3c[2] == 1 && level2c[2] == 1 && level1c[2] == 1 || level3c[3] == 1 && level2c[3] == 1 && level1c[3] == 1 || level3c[4] == 1 && level2c[4] == 1 && level1c[4] == 1 || level3c[5] == 1 && level2c[5] == 1 && level1c[5] == 1 || level3c[6] == 1 && level2c[6] == 1 && level1c[6] == 1 || level3c[7] == 1 && level2c[7] == 1 && level1c[7] == 1 || level3c[8] == 1 && level2c[8] == 1 && level1c[8] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "You won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(1);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube9 = GameObject.FindWithTag("Cube9"); current_cube10 = GameObject.FindWithTag("Cube10"); current_cube11 = GameObject.FindWithTag("Cube11"); current_cube12 = GameObject.FindWithTag("Cube12"); current_cube13 = GameObject.FindWithTag("Cube13"); current_cube14 = GameObject.FindWithTag("Cube14"); current_cube15 = GameObject.FindWithTag("Cube15"); current_cube16 = GameObject.FindWithTag("Cube16"); current_cube17 = GameObject.FindWithTag("Cube17");
            current_cube18 = GameObject.FindWithTag("Cube18"); current_cube19 = GameObject.FindWithTag("Cube19"); current_cube20 = GameObject.FindWithTag("Cube20"); current_cube21 = GameObject.FindWithTag("Cube21"); current_cube22 = GameObject.FindWithTag("Cube22"); current_cube23 = GameObject.FindWithTag("Cube23"); current_cube24 = GameObject.FindWithTag("Cube24"); current_cube25 = GameObject.FindWithTag("Cube25"); current_cube26 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;
            current_cube9.GetComponent<make_cubes_blink>().enabled = true; current_cube10.GetComponent<make_cubes_blink>().enabled = true; current_cube11.GetComponent<make_cubes_blink>().enabled = true; current_cube12.GetComponent<make_cubes_blink>().enabled = true; current_cube13.GetComponent<make_cubes_blink>().enabled = true; current_cube14.GetComponent<make_cubes_blink>().enabled = true; current_cube15.GetComponent<make_cubes_blink>().enabled = true; current_cube16.GetComponent<make_cubes_blink>().enabled = true; current_cube17.GetComponent<make_cubes_blink>().enabled = true;
            current_cube18.GetComponent<make_cubes_blink>().enabled = true; current_cube19.GetComponent<make_cubes_blink>().enabled = true; current_cube20.GetComponent<make_cubes_blink>().enabled = true; current_cube21.GetComponent<make_cubes_blink>().enabled = true; current_cube22.GetComponent<make_cubes_blink>().enabled = true; current_cube23.GetComponent<make_cubes_blink>().enabled = true; current_cube24.GetComponent<make_cubes_blink>().enabled = true; current_cube25.GetComponent<make_cubes_blink>().enabled = true; current_cube26.GetComponent<make_cubes_blink>().enabled = true;
            

        }
        //check for diagonal between level win
        if (level3c[1] == 1 && level2c[4] == 1 && level1c[7] == 1 || level3c[3] == 1 && level2c[4] == 1 && level1c[5] == 1 || level3c[5] == 1 && level2c[4] == 1 && level1c[3] == 1 || level3c[7] == 1 && level2c[4] == 1 && level1c[1] == 1 || level3c[8] == 1 && level2c[4] == 1 && level1c[0] == 1 || level3c[8] == 1 && level2c[5] == 1 && level1c[2] == 1 || level3c[0] == 1 && level2c[4] == 1 && level1c[8] == 1 || level3c[6] == 1 && level2c[4] == 1 && level1c[2] == 1 || level3c[6] == 1 && level2c[7] == 1 && level1c[8] == 1 || level3c[6] == 1 && level2c[3] == 1 && level1c[0] == 1 || level3c[0] == 1 && level2c[1] == 1 && level1c[2] == 1 || level3c[0] == 1 && level2c[3] == 1 && level1c[6] == 1 || level3c[8] == 1 && level2c[7] == 1 && level1c[6] == 1 || level3c[2] == 1 && level2c[5] == 1 && level1c[8] == 1 || level3c[2] == 1 && level2c[4] == 1 && level1c[6] == 1 || level3c[2] == 1 && level2c[1] == 1 && level1c[0] == 1)
        {
            player_turn_text.text = "";
            player_won_text.text = "You won,click Restart or Return";
            player_won_text.color = Color.blue;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(1);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube9 = GameObject.FindWithTag("Cube9"); current_cube10 = GameObject.FindWithTag("Cube10"); current_cube11 = GameObject.FindWithTag("Cube11"); current_cube12 = GameObject.FindWithTag("Cube12"); current_cube13 = GameObject.FindWithTag("Cube13"); current_cube14 = GameObject.FindWithTag("Cube14"); current_cube15 = GameObject.FindWithTag("Cube15"); current_cube16 = GameObject.FindWithTag("Cube16"); current_cube17 = GameObject.FindWithTag("Cube17");
            current_cube18 = GameObject.FindWithTag("Cube18"); current_cube19 = GameObject.FindWithTag("Cube19"); current_cube20 = GameObject.FindWithTag("Cube20"); current_cube21 = GameObject.FindWithTag("Cube21"); current_cube22 = GameObject.FindWithTag("Cube22"); current_cube23 = GameObject.FindWithTag("Cube23"); current_cube24 = GameObject.FindWithTag("Cube24"); current_cube25 = GameObject.FindWithTag("Cube25"); current_cube26 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;
            current_cube9.GetComponent<make_cubes_blink>().enabled = true; current_cube10.GetComponent<make_cubes_blink>().enabled = true; current_cube11.GetComponent<make_cubes_blink>().enabled = true; current_cube12.GetComponent<make_cubes_blink>().enabled = true; current_cube13.GetComponent<make_cubes_blink>().enabled = true; current_cube14.GetComponent<make_cubes_blink>().enabled = true; current_cube15.GetComponent<make_cubes_blink>().enabled = true; current_cube16.GetComponent<make_cubes_blink>().enabled = true; current_cube17.GetComponent<make_cubes_blink>().enabled = true;
            current_cube18.GetComponent<make_cubes_blink>().enabled = true; current_cube19.GetComponent<make_cubes_blink>().enabled = true; current_cube20.GetComponent<make_cubes_blink>().enabled = true; current_cube21.GetComponent<make_cubes_blink>().enabled = true; current_cube22.GetComponent<make_cubes_blink>().enabled = true; current_cube23.GetComponent<make_cubes_blink>().enabled = true; current_cube24.GetComponent<make_cubes_blink>().enabled = true; current_cube25.GetComponent<make_cubes_blink>().enabled = true; current_cube26.GetComponent<make_cubes_blink>().enabled = true;
            

        }


        ///cpu check win///

        if (level3c[0] == 2 && level3c[1] == 2 && level3c[2] == 2 || level3c[3] == 2 && level3c[4] == 2 && level3c[5] == 2 || level3c[6] == 2 && level3c[7] == 2 && level3c[8] == 2 || level3c[1] == 2 && level3c[4] == 2 && level3c[7] == 2 || level3c[0] == 2 && level3c[3] == 2 && level3c[6] == 2 || level3c[2] == 2 && level3c[5] == 2 && level3c[8] == 2 || level3c[0] == 2 && level3c[4] == 2 && level3c[8] == 2 || level3c[2] == 2 && level3c[4] == 2 && level3c[6] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;


        }

        if (level2c[0] == 2 && level2c[1] == 2 && level2c[2] == 2 || level2c[3] == 2 && level2c[4] == 2 && level2c[5] == 2 || level2c[6] == 2 && level2c[7] == 2 && level2c[8] == 2 || level2c[1] == 2 && level2c[4] == 2 && level2c[7] == 2 || level2c[0] == 2 && level2c[3] == 2 && level2c[6] == 2 || level2c[2] == 2 && level2c[5] == 2 && level2c[8] == 2 || level2c[0] == 2 && level2c[4] == 2 && level2c[8] == 2 || level2c[2] == 2 && level2c[4] == 2 && level2c[6] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube9"); current_cube1 = GameObject.FindWithTag("Cube10"); current_cube2 = GameObject.FindWithTag("Cube11"); current_cube3 = GameObject.FindWithTag("Cube12"); current_cube4 = GameObject.FindWithTag("Cube13"); current_cube5 = GameObject.FindWithTag("Cube14"); current_cube6 = GameObject.FindWithTag("Cube15"); current_cube7 = GameObject.FindWithTag("Cube16"); current_cube8 = GameObject.FindWithTag("Cube17");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;



        }
        if (level1c[0] == 2 && level1c[1] == 2 && level1c[2] == 2 || level1c[3] == 2 && level1c[4] == 2 && level1c[5] == 2 || level1c[6] == 2 && level1c[7] == 2 && level1c[8] == 2 || level1c[1] == 2 && level1c[4] == 2 && level1c[7] == 2 || level1c[0] == 2 && level1c[3] == 2 && level1c[6] == 2 || level1c[2] == 2 && level1c[5] == 2 && level1c[8] == 2 || level1c[0] == 2 && level1c[4] == 2 && level1c[8] == 2 || level1c[2] == 2 && level1c[4] == 2 && level1c[6] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube18"); current_cube1 = GameObject.FindWithTag("Cube19"); current_cube2 = GameObject.FindWithTag("Cube20"); current_cube3 = GameObject.FindWithTag("Cube21"); current_cube4 = GameObject.FindWithTag("Cube22"); current_cube5 = GameObject.FindWithTag("Cube23"); current_cube6 = GameObject.FindWithTag("Cube24"); current_cube7 = GameObject.FindWithTag("Cube25"); current_cube8 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;


        }
        if (level3c[0] == 2 && level2c[0] == 2 && level1c[0] == 2 || level3c[1] == 2 && level2c[1] == 2 && level1c[1] == 2 || level3c[2] == 2 && level2c[2] == 2 && level1c[2] == 2 || level3c[3] == 2 && level2c[3] == 2 && level1c[3] == 2 || level3c[4] == 2 && level2c[4] == 2 && level1c[4] == 2 || level3c[5] == 2 && level2c[5] == 2 && level1c[5] == 2 || level3c[6] == 2 && level2c[6] == 2 && level1c[6] == 2 || level3c[7] == 2 && level2c[7] == 2 && level1c[7] == 2 || level3c[8] == 2 && level2c[8] == 2 && level1c[8] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube9 = GameObject.FindWithTag("Cube9"); current_cube10 = GameObject.FindWithTag("Cube10"); current_cube11 = GameObject.FindWithTag("Cube11"); current_cube12 = GameObject.FindWithTag("Cube12"); current_cube13 = GameObject.FindWithTag("Cube13"); current_cube14 = GameObject.FindWithTag("Cube14"); current_cube15 = GameObject.FindWithTag("Cube15"); current_cube16 = GameObject.FindWithTag("Cube16"); current_cube17 = GameObject.FindWithTag("Cube17");
            current_cube18 = GameObject.FindWithTag("Cube18"); current_cube19 = GameObject.FindWithTag("Cube19"); current_cube20 = GameObject.FindWithTag("Cube20"); current_cube21 = GameObject.FindWithTag("Cube21"); current_cube22 = GameObject.FindWithTag("Cube22"); current_cube23 = GameObject.FindWithTag("Cube23"); current_cube24 = GameObject.FindWithTag("Cube24"); current_cube25 = GameObject.FindWithTag("Cube25"); current_cube26 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;
            current_cube9.GetComponent<make_cubes_blink>().enabled = true; current_cube10.GetComponent<make_cubes_blink>().enabled = true; current_cube11.GetComponent<make_cubes_blink>().enabled = true; current_cube12.GetComponent<make_cubes_blink>().enabled = true; current_cube13.GetComponent<make_cubes_blink>().enabled = true; current_cube14.GetComponent<make_cubes_blink>().enabled = true; current_cube15.GetComponent<make_cubes_blink>().enabled = true; current_cube16.GetComponent<make_cubes_blink>().enabled = true; current_cube17.GetComponent<make_cubes_blink>().enabled = true;
            current_cube18.GetComponent<make_cubes_blink>().enabled = true; current_cube19.GetComponent<make_cubes_blink>().enabled = true; current_cube20.GetComponent<make_cubes_blink>().enabled = true; current_cube21.GetComponent<make_cubes_blink>().enabled = true; current_cube22.GetComponent<make_cubes_blink>().enabled = true; current_cube23.GetComponent<make_cubes_blink>().enabled = true; current_cube24.GetComponent<make_cubes_blink>().enabled = true; current_cube25.GetComponent<make_cubes_blink>().enabled = true; current_cube26.GetComponent<make_cubes_blink>().enabled = true;

        }
        if (level3c[1] == 2 && level2c[4] == 2 && level1c[7] == 2 || level3c[3] == 2 && level2c[4] == 2 && level1c[5] == 2 || level3c[5] == 2 && level2c[4] == 2 && level1c[3] == 2 || level3c[7] == 2 && level2c[4] == 2 && level1c[1] == 2 || level3c[8] == 2 && level2c[4] == 2 && level1c[0] == 2 || level3c[8] == 2 && level2c[7] == 2 && level1c[6] == 2 || level3c[8] == 2 && level2c[5] == 2 && level1c[2] == 2 || level3c[0] == 2 && level2c[4] == 2 && level1c[8] == 2 || level3c[6] == 2 && level2c[4] == 2 && level1c[2] == 2 || level3c[6] == 2 && level2c[7] == 2 && level1c[8] == 2 || level3c[6] == 2 && level2c[3] == 2 && level1c[0] == 2 || level3c[0] == 2 && level2c[1] == 2 && level1c[2] == 2 || level3c[0] == 2 && level2c[3] == 2 && level1c[6] == 2  || level3c[2] == 2 && level2c[5] == 2 && level1c[8] == 2 || level3c[2] == 2 && level2c[4] == 2 && level1c[6] == 2 || level3c[2] == 2 && level2c[1] == 2 && level1c[0] == 2)
        {
            player_turn_text.text = "";
            player_won_text.text = "Computer  won,click Restart or Return ";
            player_won_text.color = Color.red;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
            make_cubes_blink.who_won(2);
            current_cube0 = GameObject.FindWithTag("Cube0"); current_cube1 = GameObject.FindWithTag("Cube1"); current_cube2 = GameObject.FindWithTag("Cube2"); current_cube3 = GameObject.FindWithTag("Cube3"); current_cube4 = GameObject.FindWithTag("Cube4"); current_cube5 = GameObject.FindWithTag("Cube5"); current_cube6 = GameObject.FindWithTag("Cube6"); current_cube7 = GameObject.FindWithTag("Cube7"); current_cube8 = GameObject.FindWithTag("Cube8");
            current_cube9 = GameObject.FindWithTag("Cube9"); current_cube10 = GameObject.FindWithTag("Cube10"); current_cube11 = GameObject.FindWithTag("Cube11"); current_cube12 = GameObject.FindWithTag("Cube12"); current_cube13 = GameObject.FindWithTag("Cube13"); current_cube14 = GameObject.FindWithTag("Cube14"); current_cube15 = GameObject.FindWithTag("Cube15"); current_cube16 = GameObject.FindWithTag("Cube16"); current_cube17 = GameObject.FindWithTag("Cube17");
            current_cube18 = GameObject.FindWithTag("Cube18"); current_cube19 = GameObject.FindWithTag("Cube19"); current_cube20 = GameObject.FindWithTag("Cube20"); current_cube21 = GameObject.FindWithTag("Cube21"); current_cube22 = GameObject.FindWithTag("Cube22"); current_cube23 = GameObject.FindWithTag("Cube23"); current_cube24 = GameObject.FindWithTag("Cube24"); current_cube25 = GameObject.FindWithTag("Cube25"); current_cube26 = GameObject.FindWithTag("Cube26");
            current_cube0.GetComponent<make_cubes_blink>().enabled = true; current_cube1.GetComponent<make_cubes_blink>().enabled = true; current_cube2.GetComponent<make_cubes_blink>().enabled = true; current_cube3.GetComponent<make_cubes_blink>().enabled = true; current_cube4.GetComponent<make_cubes_blink>().enabled = true; current_cube5.GetComponent<make_cubes_blink>().enabled = true; current_cube6.GetComponent<make_cubes_blink>().enabled = true; current_cube7.GetComponent<make_cubes_blink>().enabled = true; current_cube8.GetComponent<make_cubes_blink>().enabled = true;
            current_cube9.GetComponent<make_cubes_blink>().enabled = true; current_cube10.GetComponent<make_cubes_blink>().enabled = true; current_cube11.GetComponent<make_cubes_blink>().enabled = true; current_cube12.GetComponent<make_cubes_blink>().enabled = true; current_cube13.GetComponent<make_cubes_blink>().enabled = true; current_cube14.GetComponent<make_cubes_blink>().enabled = true; current_cube15.GetComponent<make_cubes_blink>().enabled = true; current_cube16.GetComponent<make_cubes_blink>().enabled = true; current_cube17.GetComponent<make_cubes_blink>().enabled = true;
            current_cube18.GetComponent<make_cubes_blink>().enabled = true; current_cube19.GetComponent<make_cubes_blink>().enabled = true; current_cube20.GetComponent<make_cubes_blink>().enabled = true; current_cube21.GetComponent<make_cubes_blink>().enabled = true; current_cube22.GetComponent<make_cubes_blink>().enabled = true; current_cube23.GetComponent<make_cubes_blink>().enabled = true; current_cube24.GetComponent<make_cubes_blink>().enabled = true; current_cube25.GetComponent<make_cubes_blink>().enabled = true; current_cube26.GetComponent<make_cubes_blink>().enabled = true;

        }





    }


    // Use this for initialization

    void Start()
    {


        level3c = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        level2c = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        level1c = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
       
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
{ 0,4,8 },
{ 8,5,2 },
{ 6,4,2 },
{ 6,3,0 },
{ 0,1,2 },
{ 0,3,6 },
{ 8,7,6 },
{ 2,5,8 },
{ 2,4,6 },
{ 2,1,0 },
{ 6,7,8 } };


    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnMouseDown()
    {

       
       

        if (Input.GetMouseButton(0)&&mode_choice==0)
        {
           
            if (gameObject.tag == "Cube0" && level3c[0] == 0)
            {
                level3c[0] = 1;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
           

            }
            if (gameObject.tag == "Cube1" && level3c[1] == 0)
            {
                level3c[1] = 1;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
            }
            if (gameObject.tag == "Cube2" && level3c[2] == 0)
            {

                level3c[2] = 1;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube3" && level3c[3] == 0)
            {
                level3c[3] = 1;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
            }
            if (gameObject.tag == "Cube4" && level3c[4] == 0)
            {
                level3c[4] = 1;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
            }
            if (gameObject.tag == "Cube5" && level3c[5] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level3c[5] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
            }
            if (gameObject.tag == "Cube6" && level3c[6] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level3c[6] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube7" && level3c[7] == 0)
            {  
             level3c[7] = 1;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
            }
            if (gameObject.tag == "Cube8" && level3c[8] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level3c[8] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
            }
            if (gameObject.tag == "Cube9" && level2c[0] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level2c[0] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube10" && level2c[1] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level2c[1] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube11" && level2c[2] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level2c[2] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();


            }
            if (gameObject.tag == "Cube12" && level2c[3] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level2c[3] = 1;
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube13" && level2c[4] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level2c[4] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube14" && level2c[5] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level2c[5] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube15" && level2c[6] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level2c[6] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube16" && level2c[7] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level2c[7] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube17" && level2c[8] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level2c[8] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube18" && level1c[0] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level1c[0] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();


            }
            if (gameObject.tag == "Cube19" && level1c[1] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level1c[1] = 1;
              gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube20" && level1c[2] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level1c[2] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube21" && level1c[3] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level1c[3] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube22" && level1c[4] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level1c[4] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube23" && level1c[5] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level1c[5] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
            }
            if (gameObject.tag == "Cube24" && level1c[6] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level1c[6] = 1;
             gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
            }
            if (gameObject.tag == "Cube25" && level1c[7] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level1c[7] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();

            }
            if (gameObject.tag == "Cube26" && level1c[8] == 0)
            {
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
                level1c[8] = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                gameObject.GetComponent<tictac_hover>().alreadyEnabled = true;
                checkWin();
                if (mode_choice == 0)
                    computer_algorithm();
            }

            
        }


    }


    void check_tie()
    {
        int counter = 0;
        bool tie_game = true;
        while (counter<9)
        {
            if (level3c[counter] == 0 || level2c[counter] == 0 || level1c[counter] == 0)
            {
                tie_game = false;
                counter = 8;
            }
            counter++;
        }
        if (tie_game)
        {
            player_turn_text.text = "";
            player_won_text.text = "It Is a Tie,Nobody Wins. Click Restart or Return ";
            player_won_text.color = Color.yellow;
            player_turn_text_overrule = 1;
            mode_choice = 1;
            restart_button.gameObject.SetActive(true);
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
            if (level2c[counter] == 1)
            {
                count_1_level_2++;
            }
            if (level1c[counter] == 1)
            {
                count_1_level_1++;
            }
            counter++;
        }
        

        
        while ( num == 1 || num==3||num==4||num==5||num==7)
        {
            num = Random.Range(0, 9);
        }

        

            if (count_1_level_3 == 1 && count_1_level_2 == 0 && count_1_level_1 == 0)
            {
            
            if (level2c[4] == 0)
                {
                    level2c[4] = 2;
                    fill_cpu_color_slot(2, 4);
                }

                computer_offence_initiator = 1;
                computer_defence_initiator = 1;
                final_stage_array = 1;
            }
            else if (count_1_level_2 == 1 && count_1_level_3 == 0 && count_1_level_1 == 0)
            {
            
            if (level2c[4] == 0)

                {
                    level2c[4] = 2;
                    fill_cpu_color_slot(2, 4);
                }
                if (level2c[4] == 1)
                {
                    level2c[num] = 2;
                    fill_cpu_color_slot(2, num);
                }
                computer_offence_initiator = 1;
                computer_defence_initiator = 1;
                final_stage_array = 1;
            }
            else if (count_1_level_1 == 1 && count_1_level_2 == 0 && count_1_level_3 == 0)
            {
          
            if (level2c[4] == 0)
                {
                
                level2c[4] = 2;
                    fill_cpu_color_slot(2, 4);
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
                fill_cpu_color_slot(3,counter1);
                counter1 = 8;
                break_it = 1;
            }

            if (level2c[counter1] != 1 && level2c[counter1] != 2)
            {
                    
                    level2c[counter1] = 2;
                fill_cpu_color_slot(2,counter1);
                counter1 = 8;
                break_it = 1;
            }

            if (level1c[counter1] != 1 && level1c[counter1] != 2)
            {
                   
                    level1c[counter1] = 2;
                fill_cpu_color_slot(1,counter1);
                counter1 = 8;
                break_it = 1;
            }
            counter1++;
        }
    }


        checkWin();
        check_tie();
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
                        fill_cpu_color_slot(3, win_combo[counter1, counter6]);
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
                        fill_cpu_color_slot(2, win_combo[counter1, counter6]);
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
                        fill_cpu_color_slot(1, win_combo[counter1, counter6]);
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

        counter10 = 0;
        counter11 = 0;
        counter8 = 0;
        counter9 = 0;
        sort_level = 2;
        // defence for diagonal

        for (counter8 = 0; counter8 < 16; counter8++)
        {

            counter11 = 0;
            sort_level = 2;
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


                if (counter11 == 2 && level3c[win_combo_diagonal[counter8, 0]] != 2 && level2c[win_combo_diagonal[counter8, 1]] != 2 && level1c[win_combo_diagonal[counter8, 2]] != 2)
                {


                    if ((level3c[win_combo_diagonal[counter8, 0]] != 2 && level3c[win_combo_diagonal[counter8, 0]] != 1) || (level2c[win_combo_diagonal[counter8, 1]] != 2 && level2c[win_combo_diagonal[counter8, 1]] != 1) || (level1c[win_combo_diagonal[counter8, 0]] != 2 && level1c[win_combo_diagonal[counter8, 0]] != 1))
                    {
                        if (level3c[win_combo_diagonal[counter8, 0]] == 0)
                        {
                            level3c[win_combo_diagonal[counter8, 0]] = 2;
                            fill_cpu_color_slot(3, win_combo_diagonal[counter8, 0]);
                            computer_offence_initiator1 = 1;
                            final_stage_array2 = 1;
                            return;
                        }
                        if (level2c[win_combo_diagonal[counter8, 1]] == 0)
                        {
                            level2c[win_combo_diagonal[counter8, 1]] = 2;
                            fill_cpu_color_slot(2, win_combo_diagonal[counter8, 1]);
                            computer_offence_initiator1 = 1;
                            final_stage_array2 = 1;
                            return;
                        }
                        if (level1c[win_combo_diagonal[counter8, 2]] == 0)
                        {
                            level1c[win_combo_diagonal[counter8, 2]] = 2;
                            fill_cpu_color_slot(1, win_combo_diagonal[counter8, 2]);
                            computer_offence_initiator1 = 1;
                            final_stage_array2 = 1;
                            return;
                        }


                        counter8 = 15;
                        counter9 = 3;


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
        //defence for up and down


        for (counter8 = 0; counter8 < 9; counter8++)
    {

            counter11 = 0;
            sort_level = 2;
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


                    if ((level3c[win_combo_up_down[counter8, 0]] != 2 && level3c[win_combo_up_down[counter8, 0]] != 1) || (level2c[win_combo_up_down[counter8, 1]] != 2 && level2c[win_combo_up_down[counter8, 1]] != 1) || (level1c[win_combo_up_down[counter8, 0]] != 2 && level1c[win_combo_up_down[counter8, 0]] != 1))
                    {
                        if (level3c[win_combo_up_down[counter8, 0]] == 0)
                        {
                            level3c[win_combo_up_down[counter8, 0]] = 2;
                            fill_cpu_color_slot(3, win_combo_up_down[counter8, 0]);
                            computer_offence_initiator1 = 1;
                            final_stage_array2 = 1;
                            return;
                        }
                        if (level2c[win_combo_up_down[counter8, 1]] == 0)
                        {
                            level2c[win_combo_up_down[counter8, 1]] = 2;
                            fill_cpu_color_slot(2, win_combo_up_down[counter8, 1]);
                            computer_offence_initiator1 = 1;
                            final_stage_array2 = 1;
                            return;
                        }
                        if (level1c[win_combo_up_down[counter8, 2]] == 0)
                        {
                            level1c[win_combo_up_down[counter8, 2]] = 2;
                            fill_cpu_color_slot(1, win_combo_up_down[counter8, 2]);
                            computer_offence_initiator1 = 1;
                            final_stage_array2 = 1;
                            return;
                        }


                        counter8 = 15;
                        counter9 = 3;


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
                        fill_cpu_color_slot(3, win_combo[counter1, counter6]);
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
                        fill_cpu_color_slot(2, win_combo[counter1, counter6]);
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
                        fill_cpu_color_slot(1, win_combo[counter1, counter6]);
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
            counter11 = 0;
            sort_level = 2;
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





                    if (level3c[win_combo_up_down[counter8, 0]] == 0)
                    {
                              
                                level3c[win_combo_up_down[counter8, 0]] = 2;
                            fill_cpu_color_slot(3, win_combo_up_down[counter8, 0]);
                            computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        return;

                        }

                    if (level2c[win_combo_up_down[counter8, 1]] == 0)
                    {
                               
                                level2c[win_combo_up_down[counter8, 1]] = 2;
                            fill_cpu_color_slot(2, win_combo_up_down[counter8, 1]);
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        return;
                    }

                    if (level1c[win_combo_up_down[counter8, 2]] == 0)
                    {
                                
                                level1c[win_combo_up_down[counter8, 2]] = 2;
                            fill_cpu_color_slot(1, win_combo_up_down[counter8, 2]);
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        return;
                    }
                        counter2 = 3;
                        counter1 = 8;

                    }
                  
                
                
            }





        }

        counter11 = 0;

    


    counter8 = 0;
    counter9 = 0;
    counter10 = 0;
    counter11 = 0;
    sort_level = 2;

    //algorithm for filling the cpu on diagonal win based on 2 cpu slots occupied
    for (counter8 = 0; counter8 < 16; counter8++)
    {

            counter11 = 0;
            sort_level = 2;
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
                    
                            
                            if (level3c[win_combo_diagonal[counter8, 0]]==0)
                        {
                               
                                level3c[win_combo_diagonal[counter8, 0]] = 2;
                            fill_cpu_color_slot(3, win_combo_diagonal[counter8, 0]);
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        return;
                    }
                        if (level2c[win_combo_diagonal[counter8, 1]]==0)
                        {
                                
                                level2c[win_combo_diagonal[counter8, 1]] = 2;
                            fill_cpu_color_slot(2, win_combo_diagonal[counter8, 1]);
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        return;
                    }
                        if (level1c[win_combo_diagonal[counter8, 2]]==0)
                        {
                                level1c[win_combo_diagonal[counter8, 2]] = 2;
                            fill_cpu_color_slot(1, win_combo_diagonal[counter8, 2]);
                        computer_defence_initiator1 = 1;
                        computer_offence_initiator2 = 1;
                        final_stage_array1 = 1;
                        return;
                    }
                       
                        
                        counter9 = 3;
                        counter8 = 15;

                
            }

        }

        counter11 = 0;

    }





}






void computer_offence1( ref int final_stage_array3)
{
        int sort_level = 2;
    int counter1 = 0;
    int counter2 = 0;
    int counter3 = 0;
    int counter5 = 0;
    int counter6 = 0;
    int counter7 = 0;
    int counter8 = 0;
        int counter9 = 0;
        int counter10 = 0;
        int counter11 = 0;
    int cpu_counter_level3c = 0;
    int cpu_counter_level2c = 0;
    int cpu_counter_level1c = 0;
    int[] index_array_level3c;
    index_array_level3c = new int[5] { 9, 9, 9, 9, 9 };
    int[] index_array_level2c;
    index_array_level2c = new int[5] { 9, 9, 9, 9, 9 };
    int[] index_array_level1c;
    index_array_level1c = new int[5] { 9, 9, 9, 9, 9 };
   
       

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



        //filling offence based on cmbination of diagonal and up and down
        for (counter8 = 0; counter8 < 16; counter8++)
        {
            counter11 = 0;
            sort_level = 2;
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
                        
                        if (index_array_level2c[counter10] == win_combo_diagonal[counter8, counter9] )
                        {
                            counter11++;
                           
                        }
                    }
                    if (sort_level % 3 == 2)
                    {
                        
                        if (index_array_level1c[counter10] == win_combo_diagonal[counter8, counter9] )
                        {
                            counter11++;
                           
                        }
                    }

                }



                if ( counter11 == 1 && level3c[win_combo_diagonal[counter8, 0]] != 1   &&   level2c[win_combo_diagonal[counter8, 1]] != 1  &&  level1c[win_combo_diagonal[counter8, 2]] != 1   )
                {





                    if (level3c[win_combo_diagonal[counter8, 0]] == 0 )
                    {
                        
                        if (level2c[win_combo_diagonal[counter8, 0]] == 2 || level1c[win_combo_diagonal[counter8, 0]] == 2)
                        {
                           
                                level3c[win_combo_diagonal[counter8, 0]] = 2;
                                fill_cpu_color_slot(3, win_combo_diagonal[counter8, 0]);
                                final_stage_array3 = 1;
                                Debug.Log("offence cmbo diagonal and up and down level 3");
                                return;

                            
                        }
                       

                    }

                    if (level2c[win_combo_diagonal[counter8, 1]] == 0 )
                    {
                        
                        if (level3c[win_combo_diagonal[counter8, 1]] == 2 || level1c[win_combo_diagonal[counter8, 1]] == 2)
                        {
                           
                                level2c[win_combo_diagonal[counter8, 1]] = 2;
                                fill_cpu_color_slot(2, win_combo_diagonal[counter8, 1]);
                                final_stage_array3 = 1;
                            Debug.Log("offence cmbo diagonal and up and down level 2");
                            return;

                            
                        }
                       
                    }

                    if (level1c[win_combo_diagonal[counter8, 2]] == 0 )
                    {
                       
                        if (level2c[win_combo_diagonal[counter8, 2]] == 2 || level3c[win_combo_diagonal[counter8, 2]] == 2)
                        {
                           
                                level1c[win_combo_diagonal[counter8, 2]] = 2;
                                fill_cpu_color_slot(1, win_combo_diagonal[counter8, 2]);
                                final_stage_array3 = 1;
                            Debug.Log("offence cmbo diagonal and up and down level 1");
                            return;

                            
                        }
                        
                    }
                    counter2 = 3;
                    counter1 = 8;

                }



            }





        }




        



        counter1 = 0;
        counter2 = 0;
        counter3 = 0;
        counter5 = 0;
        counter7 = 0;


        counter6 = 0;
        counter8 = 0;
        counter9 = 0;
        counter10 = 0;
        //filling offence based on diagonal
        for (counter8 = 0; counter8 < 16; counter8++)
        {
            counter11 = 0;
            sort_level = 2;
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



                if (counter11 == 1 && level3c[win_combo_diagonal[counter8, 0]] != 1 && level2c[win_combo_diagonal[counter8, 1]] != 1 && level1c[win_combo_diagonal[counter8, 2]] != 1)
                {





                    if (level3c[win_combo_diagonal[counter8, 0]] == 0)
                    {

                        level3c[win_combo_diagonal[counter8, 0]] = 2;
                        fill_cpu_color_slot(3, win_combo_diagonal[counter8, 0]);
                        final_stage_array3 = 1;
                        return;

                    }

                    if (level2c[win_combo_diagonal[counter8, 1]] == 0)
                    {

                        level2c[win_combo_diagonal[counter8, 1]] = 2;
                        fill_cpu_color_slot(2, win_combo_diagonal[counter8, 1]);
                        final_stage_array3 = 1;
                        return;
                    }

                    if (level1c[win_combo_diagonal[counter8, 2]] == 0)
                    {

                        level1c[win_combo_diagonal[counter8, 2]] = 2;
                        fill_cpu_color_slot(1, win_combo_diagonal[counter8, 2]);
                        final_stage_array3 = 1;
                        return;
                    }
                    counter2 = 3;
                    counter1 = 8;

                }



            }





        }




        counter6 = 0;
        counter8 = 0;
        counter9 = 0;
        counter10 = 0;


        //filling offence based on up and down
        for (counter8 = 0; counter8 < 9; counter8++)
        {
            counter11 = 0;
            sort_level = 2;
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



                if (counter11 == 1 && level3c[win_combo_up_down[counter8, 0]] != 1 && level2c[win_combo_up_down[counter8, 1]] != 1 && level1c[win_combo_up_down[counter8, 2]] != 1)
                {





                    if (level3c[win_combo_up_down[counter8, 0]] == 0)
                    {

                        level3c[win_combo_up_down[counter8, 0]] = 2;
                        fill_cpu_color_slot(3, win_combo_up_down[counter8, 0]);
                        final_stage_array3 = 1;
                        return;

                    }

                    if (level2c[win_combo_up_down[counter8, 1]] == 0)
                    {

                        level2c[win_combo_up_down[counter8, 1]] = 2;
                        fill_cpu_color_slot(2, win_combo_up_down[counter8, 1]);
                        final_stage_array3 = 1;
                        return;
                    }

                    if (level1c[win_combo_up_down[counter8, 2]] == 0)
                    {

                        level1c[win_combo_up_down[counter8, 2]] = 2;
                        fill_cpu_color_slot(1, win_combo_up_down[counter8, 2]);
                        final_stage_array3 = 1;
                        return;
                    }
                    counter2 = 3;
                    counter1 = 8;

                }



            }





        }

        counter6 = 0;
        counter8 = 0;

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
                        fill_cpu_color_slot(3, win_combo[counter1, counter6]);
                        final_stage_array3 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;

                            return;
                        }

                    counter6++;

                }
               

            }
            //fill level2c
            if (counter7 == 1)
            {
                while (counter6 < 3)
                {

                    if (level2c[win_combo[counter1, counter6]] != 2 && level2c[win_combo[counter1, counter6]] != 1)
                    {
                            
                            level2c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot(2, win_combo[counter1, counter6]);
                        final_stage_array3 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;

                            return;
                        }

                    counter6++;

                }
                
            }

            //fill level1c
            if (counter8 == 1)
            {
                while (counter6 < 3)
                {

                    if (level1c[win_combo[counter1, counter6]] != 2 && level1c[win_combo[counter1, counter6]] != 1)
                    {
                           
                        level1c[win_combo[counter1, counter6]] = 2;
                        fill_cpu_color_slot(1, win_combo[counter1, counter6]);
                        final_stage_array3 = 1;
                        counter6 = 3;
                        counter2 = 3;
                        counter1 = 8;
                            return;

                        }

                    counter6++;

                }
                
            }


            counter5 = 0;
            counter7 = 0;
            counter8 = 0;

        }
    }
        counter8 = 0;
       





    }





    

     //function for filling the cpu slot red
     void fill_cpu_color_slot(int array_level,int level_index)
     {

       

        if (array_level == 3)
        {
            if (level_index==0)
            {
                find_cube = GameObject.Find("Cube0");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index==1)
            {

                find_cube = GameObject.Find("Cube1");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index == 2)
            {



                find_cube = GameObject.Find("Cube2");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                



            }
            if (level_index == 3)
            {

                find_cube = GameObject.Find("Cube3");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index == 4)
            {





                find_cube = GameObject.Find("Cube4");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 5)
            {
                find_cube = GameObject.Find("Cube5");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 6)
            {


                find_cube = GameObject.Find("Cube6");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 7)
            {



                find_cube = GameObject.Find("Cube7");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 8)
            {



                find_cube = GameObject.Find("Cube8");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
        }
        if (array_level == 2)
        {

            if (level_index == 0)
            {

                find_cube = GameObject.Find("Cube9");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 1)
            {


                find_cube = GameObject.Find("Cube10");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index == 2)
            {




                find_cube = GameObject.Find("Cube11");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index == 3)
            {


                find_cube = GameObject.Find("Cube12");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index == 4)
            {

                find_cube = GameObject.Find("Cube13");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index == 5)
            {


                find_cube = GameObject.Find("Cube14");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 6)
            {


                find_cube = GameObject.Find("Cube15");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index == 7)
            {


                find_cube = GameObject.Find("Cube16");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index == 8)
            {



                find_cube = GameObject.Find("Cube17");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
        }
        if (array_level == 1)
        {
            if (level_index == 0)
            {


                find_cube = GameObject.Find("Cube18");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                

            }
            if (level_index == 1)
            {


                find_cube = GameObject.Find("Cube19");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
               
            }
            if (level_index == 2)
            {



                find_cube = GameObject.Find("Cube20");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 3)
            {


                find_cube = GameObject.Find("Cube21");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 4)
            {


                find_cube = GameObject.Find("Cube22");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
               
            }
            if (level_index == 5)
            {

                find_cube = GameObject.Find("Cube23");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 6)
            {



                find_cube = GameObject.Find("Cube24");
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
            }
            if (level_index == 7)
            {

                find_cube = GameObject.Find("Cube25");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
                
            }
            if (level_index == 8)
            {



                find_cube = GameObject.Find("Cube26");
                find_cube.GetComponent<tictac_hover>().alreadyEnabled = true;
                find_cube = find_cube.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                find_cube.GetComponent<Renderer>().enabled = true;
                find_cube.GetComponent<Renderer>().material.color = Color.red;
               
            }
        }
     }





 }

   
    
