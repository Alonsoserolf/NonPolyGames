using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_cubes_blink : MonoBehaviour {
    public static GameObject current_cube1;
    public static GameObject current_cube2;
    public static GameObject current_cube3;
    private static int player_or_user=0;
    public static void who_won(int y)
    {
        if (y == 1)
            player_or_user = 1;
        else player_or_user = 2;
        
    }
    
    void Start()
    {
        
        
        StartCoroutine(Flash());
       

    }
   
     IEnumerator Flash()


    {
        int x = 0;
       
       
        //user vs cpu
        // if level 3 win

        if (tictac_cpu_mode.level3c[0] == 1 && tictac_cpu_mode.level3c[1] == 1 && tictac_cpu_mode.level3c[2] == 1 || tictac_cpu_mode.level3c[0] == 2 && tictac_cpu_mode.level3c[1] == 2 && tictac_cpu_mode.level3c[2] == 2)
        {
                    current_cube1 = GameObject.FindWithTag("Cube0");
                    current_cube2 = GameObject.FindWithTag("Cube1");
                    current_cube3= GameObject.FindWithTag("Cube2");
           


        }
                if (tictac_cpu_mode.level3c[3] == 1 && tictac_cpu_mode.level3c[4] == 1 && tictac_cpu_mode.level3c[5] == 1|| tictac_cpu_mode.level3c[3] == 2 && tictac_cpu_mode.level3c[4] == 2 && tictac_cpu_mode.level3c[5] == 2)
                {

                    current_cube1 = GameObject.FindWithTag("Cube3");
                    current_cube2 = GameObject.FindWithTag("Cube4");
                    current_cube3 = GameObject.FindWithTag("Cube5");

            
            



        }
                if (tictac_cpu_mode.level3c[6] == 1 && tictac_cpu_mode.level3c[7] == 1 && tictac_cpu_mode.level3c[8] == 1|| tictac_cpu_mode.level3c[6] == 2 && tictac_cpu_mode.level3c[7] == 2 && tictac_cpu_mode.level3c[8] == 2)
                {
                    current_cube1 = GameObject.FindWithTag("Cube6");
                    current_cube2 = GameObject.FindWithTag("Cube7");
                    current_cube3 = GameObject.FindWithTag("Cube8");

            

            



        }
                if (tictac_cpu_mode.level3c[1] == 1 && tictac_cpu_mode.level3c[4] == 1 && tictac_cpu_mode.level3c[7] == 1|| tictac_cpu_mode.level3c[1] == 2 && tictac_cpu_mode.level3c[4] == 2 && tictac_cpu_mode.level3c[7] == 2)
                {
                    current_cube1 = GameObject.FindWithTag("Cube1");
                    current_cube2 = GameObject.FindWithTag("Cube4");
                    current_cube3 = GameObject.FindWithTag("Cube7");

            

            



        }
                if (tictac_cpu_mode.level3c[0] == 1 && tictac_cpu_mode.level3c[3] == 1 && tictac_cpu_mode.level3c[6] == 1||tictac_cpu_mode.level3c[0] == 2 && tictac_cpu_mode.level3c[3] == 2 && tictac_cpu_mode.level3c[6] == 2)
                {
                    current_cube1 = GameObject.FindWithTag("Cube0");
                    current_cube2 = GameObject.FindWithTag("Cube3");
                    current_cube3 = GameObject.FindWithTag("Cube6");
            


            


        }
                if (tictac_cpu_mode.level3c[2] == 1 && tictac_cpu_mode.level3c[5] == 1 && tictac_cpu_mode.level3c[8] == 1|| tictac_cpu_mode.level3c[2] == 2 && tictac_cpu_mode.level3c[5] == 2 && tictac_cpu_mode.level3c[8] == 2)
                {
                    current_cube1 = GameObject.FindWithTag("Cube2");
                    current_cube2 = GameObject.FindWithTag("Cube5");
                    current_cube3 = GameObject.FindWithTag("Cube8");
            


           



        }
                if (tictac_cpu_mode.level3c[0] == 1 && tictac_cpu_mode.level3c[4] == 1 && tictac_cpu_mode.level3c[8] == 1|| tictac_cpu_mode.level3c[0] == 2 && tictac_cpu_mode.level3c[4] == 2 && tictac_cpu_mode.level3c[8] == 2)
                {
                    current_cube1 = GameObject.FindWithTag("Cube0");
                    current_cube2 = GameObject.FindWithTag("Cube4");
                    current_cube3 = GameObject.FindWithTag("Cube8");
            
            



        }
                if (tictac_cpu_mode.level3c[2] == 1 && tictac_cpu_mode.level3c[4] == 1 && tictac_cpu_mode.level3c[6] == 1|| tictac_cpu_mode.level3c[2] == 2 && tictac_cpu_mode.level3c[4] == 2 && tictac_cpu_mode.level3c[6] == 2)
                {
                    current_cube1 = GameObject.FindWithTag("Cube2");
                    current_cube2 = GameObject.FindWithTag("Cube4");
                    current_cube3 = GameObject.FindWithTag("Cube6");
            



            
            



        }

            

            //if level 2 win
          
                if (tictac_cpu_mode.level2c[0] == 1 && tictac_cpu_mode.level2c[1] == 1 && tictac_cpu_mode.level2c[2] == 1|| tictac_cpu_mode.level2c[0] == 2 && tictac_cpu_mode.level2c[1] == 2 && tictac_cpu_mode.level2c[2] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube9");
            current_cube2 = GameObject.FindWithTag("Cube10");
            current_cube3 = GameObject.FindWithTag("Cube11");
            



           
        }
                if (tictac_cpu_mode.level2c[3] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level2c[5] == 1|| tictac_cpu_mode.level2c[3] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level2c[5] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube12");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube14");
            



            
        }
                if (tictac_cpu_mode.level2c[6] == 1 && tictac_cpu_mode.level2c[7] == 1 && tictac_cpu_mode.level2c[8] == 1|| tictac_cpu_mode.level2c[6] == 2 && tictac_cpu_mode.level2c[7] == 2 && tictac_cpu_mode.level2c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube15");
            current_cube2 = GameObject.FindWithTag("Cube16");
            current_cube3 = GameObject.FindWithTag("Cube17");
        }
                if (tictac_cpu_mode.level2c[1] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level2c[7] == 1|| tictac_cpu_mode.level2c[1] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level2c[7] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube10");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube16");
        }
                if (tictac_cpu_mode.level2c[0] == 1 && tictac_cpu_mode.level2c[3] == 1 && tictac_cpu_mode.level2c[6] == 1|| tictac_cpu_mode.level2c[0] == 2 && tictac_cpu_mode.level2c[3] == 2 && tictac_cpu_mode.level2c[6] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube9");
            current_cube2 = GameObject.FindWithTag("Cube12");
            current_cube3 = GameObject.FindWithTag("Cube15");
        }
                if (tictac_cpu_mode.level2c[2] == 1 && tictac_cpu_mode.level2c[5] == 1 && tictac_cpu_mode.level2c[8] == 1|| tictac_cpu_mode.level2c[2] == 2 && tictac_cpu_mode.level2c[5] == 2 && tictac_cpu_mode.level2c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube11");
            current_cube2 = GameObject.FindWithTag("Cube14");
            current_cube3 = GameObject.FindWithTag("Cube17");
        }
                if (tictac_cpu_mode.level2c[0] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level2c[8] == 1|| tictac_cpu_mode.level2c[0] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level2c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube9");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube17");
        }
                if (tictac_cpu_mode.level2c[2] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level2c[6] == 1|| tictac_cpu_mode.level2c[2] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level2c[6] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube11");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube15");
        }

           

            //if level 1 win
          
                if (tictac_cpu_mode.level1c[0] == 1 && tictac_cpu_mode.level1c[1] == 1 && tictac_cpu_mode.level1c[2] == 1|| tictac_cpu_mode.level1c[0] == 2 && tictac_cpu_mode.level1c[1] == 2 && tictac_cpu_mode.level1c[2] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube18");
            current_cube2 = GameObject.FindWithTag("Cube19");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
                if (tictac_cpu_mode.level1c[3] == 1 && tictac_cpu_mode.level1c[4] == 1 && tictac_cpu_mode.level1c[5] == 1|| tictac_cpu_mode.level1c[3] == 2 && tictac_cpu_mode.level1c[4] == 2 && tictac_cpu_mode.level1c[5] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube21");
            current_cube2 = GameObject.FindWithTag("Cube22");
            current_cube3 = GameObject.FindWithTag("Cube23");
        }
                if (tictac_cpu_mode.level1c[6] == 1 && tictac_cpu_mode.level1c[7] == 1 && tictac_cpu_mode.level1c[8] == 1|| tictac_cpu_mode.level1c[6] == 2 && tictac_cpu_mode.level1c[7] == 2 && tictac_cpu_mode.level1c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube24");
            current_cube2 = GameObject.FindWithTag("Cube25");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
                if (tictac_cpu_mode.level1c[1] == 1 && tictac_cpu_mode.level1c[4] == 1 && tictac_cpu_mode.level1c[7] == 1|| tictac_cpu_mode.level1c[1] == 2 && tictac_cpu_mode.level1c[4] == 2 && tictac_cpu_mode.level1c[7] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube19");
            current_cube2 = GameObject.FindWithTag("Cube22");
            current_cube3 = GameObject.FindWithTag("Cube25");
        }
                if (tictac_cpu_mode.level1c[0] == 1 && tictac_cpu_mode.level1c[3] == 1 && tictac_cpu_mode.level1c[6] == 1|| tictac_cpu_mode.level1c[0] == 2 && tictac_cpu_mode.level1c[3] == 2 && tictac_cpu_mode.level1c[6] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube18");
            current_cube2 = GameObject.FindWithTag("Cube21");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }
                if (tictac_cpu_mode.level1c[2] == 1 && tictac_cpu_mode.level1c[5] == 1 && tictac_cpu_mode.level1c[8] == 1|| tictac_cpu_mode.level1c[2] == 2 && tictac_cpu_mode.level1c[5] == 2 && tictac_cpu_mode.level1c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube20");
            current_cube2 = GameObject.FindWithTag("Cube23");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
                if (tictac_cpu_mode.level1c[0] == 2 && tictac_cpu_mode.level1c[4] == 2 && tictac_cpu_mode.level1c[8] == 2|| tictac_cpu_mode.level1c[0] == 2 && tictac_cpu_mode.level1c[4] == 2 && tictac_cpu_mode.level1c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube18");
            current_cube2 = GameObject.FindWithTag("Cube22");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
                if (tictac_cpu_mode.level1c[2] == 1 && tictac_cpu_mode.level1c[4] == 1 && tictac_cpu_mode.level1c[6] == 1|| tictac_cpu_mode.level1c[2] == 2 && tictac_cpu_mode.level1c[4] == 2 && tictac_cpu_mode.level1c[6] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube20");
            current_cube2 = GameObject.FindWithTag("Cube22");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }

            
            //if up and down win
           
                if (tictac_cpu_mode.level3c[0] == 1 && tictac_cpu_mode.level2c[0] == 1 && tictac_cpu_mode.level1c[0] == 1|| tictac_cpu_mode.level3c[0] == 2 && tictac_cpu_mode.level2c[0] == 2 && tictac_cpu_mode.level1c[0] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube9");
            current_cube3 = GameObject.FindWithTag("Cube18");
        }
                if (tictac_cpu_mode.level3c[1] == 1 && tictac_cpu_mode.level2c[1] == 1 && tictac_cpu_mode.level1c[1] == 1|| tictac_cpu_mode.level3c[1] == 2 && tictac_cpu_mode.level2c[1] == 2 && tictac_cpu_mode.level1c[1] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube1");
            current_cube2 = GameObject.FindWithTag("Cube10");
            current_cube3 = GameObject.FindWithTag("Cube19");
        }

                if (tictac_cpu_mode.level3c[2] == 1 && tictac_cpu_mode.level2c[2] == 1 && tictac_cpu_mode.level1c[2] == 1|| tictac_cpu_mode.level3c[2] == 2 && tictac_cpu_mode.level2c[2] == 2 && tictac_cpu_mode.level1c[2] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube2");
            current_cube2 = GameObject.FindWithTag("Cube11");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
                if (tictac_cpu_mode.level3c[3] == 1 && tictac_cpu_mode.level2c[3] == 1 && tictac_cpu_mode.level1c[3] == 1|| tictac_cpu_mode.level3c[3] == 2 && tictac_cpu_mode.level2c[3] == 2 && tictac_cpu_mode.level1c[3] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube3");
            current_cube2 = GameObject.FindWithTag("Cube12");
            current_cube3 = GameObject.FindWithTag("Cube21");
        }
                if (tictac_cpu_mode.level3c[4] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[4] == 1|| tictac_cpu_mode.level3c[4] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level1c[4] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube4");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube22");
        }
                if (tictac_cpu_mode.level3c[5] == 1 && tictac_cpu_mode.level2c[5] == 1 && tictac_cpu_mode.level1c[5] == 1|| tictac_cpu_mode.level3c[5] == 2 && tictac_cpu_mode.level2c[5] == 2 && tictac_cpu_mode.level1c[5] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube5");
            current_cube2 = GameObject.FindWithTag("Cube14");
            current_cube3 = GameObject.FindWithTag("Cube23");
        }
                if (tictac_cpu_mode.level3c[6] == 1 && tictac_cpu_mode.level2c[6] == 1 && tictac_cpu_mode.level1c[6] == 1|| tictac_cpu_mode.level3c[6] == 2 && tictac_cpu_mode.level2c[6] == 2 && tictac_cpu_mode.level1c[6] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube6");
            current_cube2 = GameObject.FindWithTag("Cube15");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }
                if (tictac_cpu_mode.level3c[7] == 1 && tictac_cpu_mode.level2c[7] == 1 && tictac_cpu_mode.level1c[7] == 1|| tictac_cpu_mode.level3c[7] == 2 && tictac_cpu_mode.level2c[7] == 2 && tictac_cpu_mode.level1c[7] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube7");
            current_cube2 = GameObject.FindWithTag("Cube16");
            current_cube3 = GameObject.FindWithTag("Cube25");
        }
                if (tictac_cpu_mode.level3c[8] == 1 && tictac_cpu_mode.level2c[8] == 1 && tictac_cpu_mode.level1c[8] == 1|| tictac_cpu_mode.level3c[8] == 2 && tictac_cpu_mode.level2c[8] == 2 && tictac_cpu_mode.level1c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube8");
            current_cube2 = GameObject.FindWithTag("Cube17");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }

            

            //if diagonal win
           
                if (tictac_cpu_mode.level3c[1] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[7] == 1|| tictac_cpu_mode.level3c[1] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level1c[7] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube1");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube25");
        }
                if (tictac_cpu_mode.level3c[3] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[5] == 1|| tictac_cpu_mode.level3c[3] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level1c[5] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube3");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube23");
        }
                if (tictac_cpu_mode.level3c[5] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[3] == 1|| tictac_cpu_mode.level3c[5] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[3] == 1)
                {
            current_cube1 = GameObject.FindWithTag("Cube5");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube21");
        }
                if (tictac_cpu_mode.level3c[7] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[1] == 1|| tictac_cpu_mode.level3c[7] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level1c[1] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube7");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube19");
        }
                if (tictac_cpu_mode.level3c[8] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[0] == 1|| tictac_cpu_mode.level3c[8] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level1c[0] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube8");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube18");
        }

                if (tictac_cpu_mode.level3c[8] == 1 && tictac_cpu_mode.level2c[5] == 1 && tictac_cpu_mode.level1c[2] == 1|| tictac_cpu_mode.level3c[8] == 2 && tictac_cpu_mode.level2c[5] == 2 && tictac_cpu_mode.level1c[2] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube8");
            current_cube2 = GameObject.FindWithTag("Cube14");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
                if (tictac_cpu_mode.level3c[0] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[8] == 1|| tictac_cpu_mode.level3c[0] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level1c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
                if (tictac_cpu_mode.level3c[6] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[2] == 1|| tictac_cpu_mode.level3c[6] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level1c[2] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube6");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
                if (tictac_cpu_mode.level3c[6] == 1 && tictac_cpu_mode.level2c[7] == 1 && tictac_cpu_mode.level1c[8] == 1|| tictac_cpu_mode.level3c[6] == 2 && tictac_cpu_mode.level2c[7] == 2 && tictac_cpu_mode.level1c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube6");
            current_cube2 = GameObject.FindWithTag("Cube16");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
                if (tictac_cpu_mode.level3c[6] == 1 && tictac_cpu_mode.level2c[3] == 1 && tictac_cpu_mode.level1c[0] == 1|| tictac_cpu_mode.level3c[6] == 2 && tictac_cpu_mode.level2c[3] == 2 && tictac_cpu_mode.level1c[0] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube6");
            current_cube2 = GameObject.FindWithTag("Cube12");
            current_cube3 = GameObject.FindWithTag("Cube18");
        }
                if (tictac_cpu_mode.level3c[0] == 1 && tictac_cpu_mode.level2c[1] == 1 && tictac_cpu_mode.level1c[2] == 1|| tictac_cpu_mode.level3c[0] == 2 && tictac_cpu_mode.level2c[1] == 2 && tictac_cpu_mode.level1c[2] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube10");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
                if (tictac_cpu_mode.level3c[0] == 1 && tictac_cpu_mode.level2c[3] == 1 && tictac_cpu_mode.level1c[6] == 1|| tictac_cpu_mode.level3c[0] == 2 && tictac_cpu_mode.level2c[3] == 2 && tictac_cpu_mode.level1c[6] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube12");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }
                if (tictac_cpu_mode.level3c[8] == 1 && tictac_cpu_mode.level2c[7] == 1 && tictac_cpu_mode.level1c[6] == 1|| tictac_cpu_mode.level3c[8] == 2 && tictac_cpu_mode.level2c[7] == 2 && tictac_cpu_mode.level1c[6] == 2)

                {
            current_cube1 = GameObject.FindWithTag("Cube8");
            current_cube2 = GameObject.FindWithTag("Cube16");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }

                if (tictac_cpu_mode.level3c[2] == 1 && tictac_cpu_mode.level2c[5] == 1 && tictac_cpu_mode.level1c[8] == 1|| tictac_cpu_mode.level3c[2] == 2 && tictac_cpu_mode.level2c[5] == 2 && tictac_cpu_mode.level1c[8] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube2");
            current_cube2 = GameObject.FindWithTag("Cube14");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
                if (tictac_cpu_mode.level3c[2] == 1 && tictac_cpu_mode.level2c[4] == 1 && tictac_cpu_mode.level1c[6] == 1|| tictac_cpu_mode.level3c[2] == 2 && tictac_cpu_mode.level2c[4] == 2 && tictac_cpu_mode.level1c[6] == 2)
                {
            current_cube1 = GameObject.FindWithTag("Cube2");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }
                if (tictac_cpu_mode.level3c[2] == 1 && tictac_cpu_mode.level2c[1] == 1 && tictac_cpu_mode.level1c[0] == 1|| tictac_cpu_mode.level3c[2] == 2 && tictac_cpu_mode.level2c[1] == 2 && tictac_cpu_mode.level1c[0] == 2)
                {

            current_cube1 = GameObject.FindWithTag("Cube2");
            current_cube2 = GameObject.FindWithTag("Cube10");
            current_cube3 = GameObject.FindWithTag("Cube18");
        }








        





       
        
            if (player_or_user == 1)
            {
            while (x == 0)
            {
                current_cube1.GetComponent<Renderer>().material.color = Color.magenta;

                current_cube2.GetComponent<Renderer>().material.color = Color.magenta;
                current_cube3.GetComponent<Renderer>().material.color = Color.magenta;
                yield return new WaitForSeconds(1.0f);
                current_cube1.GetComponent<Renderer>().material.color = Color.blue;

                current_cube2.GetComponent<Renderer>().material.color = Color.blue;
                current_cube3.GetComponent<Renderer>().material.color = Color.blue;
                yield return new WaitForSeconds(1.0f);
            }
            }
            if (player_or_user==2)
            {
            while (x == 0)
            {
                current_cube1.GetComponent<Renderer>().material.color = Color.magenta;

                current_cube2.GetComponent<Renderer>().material.color = Color.magenta;
                current_cube3.GetComponent<Renderer>().material.color = Color.magenta;
                yield return new WaitForSeconds(1.0f);
                current_cube1.GetComponent<Renderer>().material.color = Color.red;

                current_cube2.GetComponent<Renderer>().material.color = Color.red;
                current_cube3.GetComponent<Renderer>().material.color = Color.red;
                yield return new WaitForSeconds(1.0f);
            }
            }




        
    }











    




    // Update is called once per frame
    void Update ()
    {
		

	}

   


}


 

