using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_cubes_blink2 : MonoBehaviour {
    public static GameObject current_cube1;
    public static GameObject current_cube2;
    public static GameObject current_cube3;
    private static int player_or_user = 0;
    public static void who_won(int y)
    {
        if (y == 1)
            player_or_user = 1;
        else player_or_user = 2;

    }
    // Use this for initialization
    void Start () {
        StartCoroutine(Flash1());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    //user vs user



    IEnumerator Flash1()


    {
        int x = 0;


        //user vs cpu
        // if level 3 win

        if (tictac.level3[0] == 1 && tictac.level3[1] == 1 && tictac.level3[2] == 1 || tictac.level3[0] == 2 && tictac.level3[1] == 2 && tictac.level3[2] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube1");
            current_cube3 = GameObject.FindWithTag("Cube2");



        }
        if (tictac.level3[3] == 1 && tictac.level3[4] == 1 && tictac.level3[5] == 1 || tictac.level3[3] == 2 && tictac.level3[4] == 2 && tictac.level3[5] == 2)
        {

            current_cube1 = GameObject.FindWithTag("Cube3");
            current_cube2 = GameObject.FindWithTag("Cube4");
            current_cube3 = GameObject.FindWithTag("Cube5");

          





        }
        if (tictac.level3[6] == 1 && tictac.level3[7] == 1 && tictac.level3[8] == 1 || tictac.level3[6] == 2 && tictac.level3[7] == 2 && tictac.level3[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube6");
            current_cube2 = GameObject.FindWithTag("Cube7");
            current_cube3 = GameObject.FindWithTag("Cube8");

            





        }
        if (tictac.level3[1] == 1 && tictac.level3[4] == 1 && tictac.level3[7] == 1 || tictac.level3[1] == 2 && tictac.level3[4] == 2 && tictac.level3[7] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube1");
            current_cube2 = GameObject.FindWithTag("Cube4");
            current_cube3 = GameObject.FindWithTag("Cube7");

           





        }
        if (tictac.level3[0] == 1 && tictac.level3[3] == 1 && tictac.level3[6] == 1 || tictac.level3[0] == 2 && tictac.level3[3] == 2 && tictac.level3[6] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube3");
            current_cube3 = GameObject.FindWithTag("Cube6");
       





        }
        if (tictac.level3[2] == 1 && tictac.level3[5] == 1 && tictac.level3[8] == 1 || tictac.level3[2] == 2 && tictac.level3[5] == 2 && tictac.level3[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube2");
            current_cube2 = GameObject.FindWithTag("Cube5");
            current_cube3 = GameObject.FindWithTag("Cube8");
            






        }
        if (tictac.level3[0] == 1 && tictac.level3[4] == 1 && tictac.level3[8] == 1 || tictac.level3[0] == 2 && tictac.level3[4] == 2 && tictac.level3[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube4");
            current_cube3 = GameObject.FindWithTag("Cube8");
            




        }
        if (tictac.level3[2] == 1 && tictac.level3[4] == 1 && tictac.level3[6] == 1 || tictac.level3[2] == 2 && tictac.level3[4] == 2 && tictac.level3[6] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube2");
            current_cube2 = GameObject.FindWithTag("Cube4");
            current_cube3 = GameObject.FindWithTag("Cube6");
            








        }



        //if level 2 win

        if (tictac.level2[0] == 1 && tictac.level2[1] == 1 && tictac.level2[2] == 1 || tictac.level2[0] == 2 && tictac.level2[1] == 2 && tictac.level2[2] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube9");
            current_cube2 = GameObject.FindWithTag("Cube10");
            current_cube3 = GameObject.FindWithTag("Cube11");





        }
        if (tictac.level2[3] == 1 && tictac.level2[4] == 1 && tictac.level2[5] == 1 || tictac.level2[3] == 2 && tictac.level2[4] == 2 && tictac.level2[5] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube12");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube14");





        }
        if (tictac.level2[6] == 1 && tictac.level2[7] == 1 && tictac.level2[8] == 1 || tictac.level2[6] == 2 && tictac.level2[7] == 2 && tictac.level2[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube15");
            current_cube2 = GameObject.FindWithTag("Cube16");
            current_cube3 = GameObject.FindWithTag("Cube17");
        }
        if (tictac.level2[1] == 1 && tictac.level2[4] == 1 && tictac.level2[7] == 1 || tictac.level2[1] == 2 && tictac.level2[4] == 2 && tictac.level2[7] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube10");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube16");
        }
        if (tictac.level2[0] == 1 && tictac.level2[3] == 1 && tictac.level2[6] == 1 || tictac.level2[0] == 2 && tictac.level2[3] == 2 && tictac.level2[6] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube9");
            current_cube2 = GameObject.FindWithTag("Cube12");
            current_cube3 = GameObject.FindWithTag("Cube15");
        }
        if (tictac.level2[2] == 1 && tictac.level2[5] == 1 && tictac.level2[8] == 1 || tictac.level2[2] == 2 && tictac.level2[5] == 2 && tictac.level2[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube11");
            current_cube2 = GameObject.FindWithTag("Cube14");
            current_cube3 = GameObject.FindWithTag("Cube17");
        }
        if (tictac.level2[0] == 1 && tictac.level2[4] == 1 && tictac.level2[8] == 1 || tictac.level2[0] == 2 && tictac.level2[4] == 2 && tictac.level2[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube9");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube17");
        }
        if (tictac.level2[2] == 1 && tictac.level2[4] == 1 && tictac.level2[6] == 1 || tictac.level2[2] == 2 && tictac.level2[4] == 2 && tictac.level2[6] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube11");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube15");
        }



        //if level 1 win

        if (tictac.level1[0] == 1 && tictac.level1[1] == 1 && tictac.level1[2] == 1 || tictac.level1[0] == 2 && tictac.level1[1] == 2 && tictac.level1[2] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube18");
            current_cube2 = GameObject.FindWithTag("Cube19");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
        if (tictac.level1[3] == 1 && tictac.level1[4] == 1 && tictac.level1[5] == 1 || tictac.level1[3] == 2 && tictac.level1[4] == 2 && tictac.level1[5] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube21");
            current_cube2 = GameObject.FindWithTag("Cube22");
            current_cube3 = GameObject.FindWithTag("Cube23");
        }
        if (tictac.level1[6] == 1 && tictac.level1[7] == 1 && tictac.level1[8] == 1 || tictac.level1[6] == 2 && tictac.level1[7] == 2 && tictac.level1[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube24");
            current_cube2 = GameObject.FindWithTag("Cube25");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
        if (tictac.level1[1] == 1 && tictac.level1[4] == 1 && tictac.level1[7] == 1 || tictac.level1[1] == 2 && tictac.level1[4] == 2 && tictac.level1[7] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube19");
            current_cube2 = GameObject.FindWithTag("Cube22");
            current_cube3 = GameObject.FindWithTag("Cube25");
        }
        if (tictac.level1[0] == 1 && tictac.level1[3] == 1 && tictac.level1[6] == 1 || tictac.level1[0] == 2 && tictac.level1[3] == 2 && tictac.level1[6] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube18");
            current_cube2 = GameObject.FindWithTag("Cube21");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }
        if (tictac.level1[2] == 1 && tictac.level1[5] == 1 && tictac.level1[8] == 1 || tictac.level1[2] == 2 && tictac.level1[5] == 2 && tictac.level1[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube20");
            current_cube2 = GameObject.FindWithTag("Cube23");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
        if (tictac.level1[0] == 2 && tictac.level1[4] == 2 && tictac.level1[8] == 2 || tictac.level1[0] == 2 && tictac.level1[4] == 2 && tictac.level1[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube18");
            current_cube2 = GameObject.FindWithTag("Cube22");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
        if (tictac.level1[2] == 1 && tictac.level1[4] == 1 && tictac.level1[6] == 1 || tictac.level1[2] == 2 && tictac.level1[4] == 2 && tictac.level1[6] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube20");
            current_cube2 = GameObject.FindWithTag("Cube22");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }


        //if up and down win

        if (tictac.level3[0] == 1 && tictac.level2[0] == 1 && tictac.level1[0] == 1 || tictac.level3[0] == 2 && tictac.level2[0] == 2 && tictac.level1[0] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube9");
            current_cube3 = GameObject.FindWithTag("Cube18");
        }
        if (tictac.level3[1] == 1 && tictac.level2[1] == 1 && tictac.level1[1] == 1 || tictac.level3[1] == 2 && tictac.level2[1] == 2 && tictac.level1[1] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube1");
            current_cube2 = GameObject.FindWithTag("Cube10");
            current_cube3 = GameObject.FindWithTag("Cube19");
        }

        if (tictac.level3[2] == 1 && tictac.level2[2] == 1 && tictac.level1[2] == 1 || tictac.level3[2] == 2 && tictac.level2[2] == 2 && tictac.level1[2] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube2");
            current_cube2 = GameObject.FindWithTag("Cube11");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
        if (tictac.level3[3] == 1 && tictac.level2[3] == 1 && tictac.level1[3] == 1 || tictac.level3[3] == 2 && tictac.level2[3] == 2 && tictac.level1[3] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube3");
            current_cube2 = GameObject.FindWithTag("Cube12");
            current_cube3 = GameObject.FindWithTag("Cube21");
        }
        if (tictac.level3[4] == 1 && tictac.level2[4] == 1 && tictac.level1[4] == 1 || tictac.level3[4] == 2 && tictac.level2[4] == 2 && tictac.level1[4] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube4");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube22");
        }
        if (tictac.level3[5] == 1 && tictac.level2[5] == 1 && tictac.level1[5] == 1 || tictac.level3[5] == 2 && tictac.level2[5] == 2 && tictac.level1[5] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube5");
            current_cube2 = GameObject.FindWithTag("Cube14");
            current_cube3 = GameObject.FindWithTag("Cube23");
        }
        if (tictac.level3[6] == 1 && tictac.level2[6] == 1 && tictac.level1[6] == 1 || tictac.level3[6] == 2 && tictac.level2[6] == 2 && tictac.level1[6] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube6");
            current_cube2 = GameObject.FindWithTag("Cube15");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }
        if (tictac.level3[7] == 1 && tictac.level2[7] == 1 && tictac.level1[7] == 1 || tictac.level3[7] == 2 && tictac.level2[7] == 2 && tictac.level1[7] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube7");
            current_cube2 = GameObject.FindWithTag("Cube16");
            current_cube3 = GameObject.FindWithTag("Cube25");
        }
        if (tictac.level3[8] == 1 && tictac.level2[8] == 1 && tictac.level1[8] == 1 || tictac.level3[8] == 2 && tictac.level2[8] == 2 && tictac.level1[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube8");
            current_cube2 = GameObject.FindWithTag("Cube17");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }



        //if diagonal win

        if (tictac.level3[1] == 1 && tictac.level2[4] == 1 && tictac.level1[7] == 1 || tictac.level3[1] == 2 && tictac.level2[4] == 2 && tictac.level1[7] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube1");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube25");
        }
        if (tictac.level3[3] == 1 && tictac.level2[4] == 1 && tictac.level1[5] == 1 || tictac.level3[3] == 2 && tictac.level2[4] == 2 && tictac.level1[5] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube3");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube23");
        }
        if (tictac.level3[5] == 1 && tictac.level2[4] == 1 && tictac.level1[3] == 1 || tictac.level3[5] == 1 && tictac.level2[4] == 1 && tictac.level1[3] == 1)
        {
            current_cube1 = GameObject.FindWithTag("Cube5");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube21");
        }
        if (tictac.level3[7] == 1 && tictac.level2[4] == 1 && tictac.level1[1] == 1 || tictac.level3[7] == 2 && tictac.level2[4] == 2 && tictac.level1[1] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube7");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube19");
        }
        if (tictac.level3[8] == 1 && tictac.level2[4] == 1 && tictac.level1[0] == 1 || tictac.level3[8] == 2 && tictac.level2[4] == 2 && tictac.level1[0] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube8");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube18");
        }

        if (tictac.level3[8] == 1 && tictac.level2[5] == 1 && tictac.level1[2] == 1 || tictac.level3[8] == 2 && tictac.level2[5] == 2 && tictac.level1[2] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube8");
            current_cube2 = GameObject.FindWithTag("Cube14");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
        if (tictac.level3[0] == 1 && tictac.level2[4] == 1 && tictac.level1[8] == 1 || tictac.level3[0] == 2 && tictac.level2[4] == 2 && tictac.level1[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
        if (tictac.level3[6] == 1 && tictac.level2[4] == 1 && tictac.level1[2] == 1 || tictac.level3[6] == 2 && tictac.level2[4] == 2 && tictac.level1[2] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube6");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
        if (tictac.level3[6] == 1 && tictac.level2[7] == 1 && tictac.level1[8] == 1 || tictac.level3[6] == 2 && tictac.level2[7] == 2 && tictac.level1[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube6");
            current_cube2 = GameObject.FindWithTag("Cube16");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
        if (tictac.level3[6] == 1 && tictac.level2[3] == 1 && tictac.level1[0] == 1 || tictac.level3[6] == 2 && tictac.level2[3] == 2 && tictac.level1[0] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube6");
            current_cube2 = GameObject.FindWithTag("Cube12");
            current_cube3 = GameObject.FindWithTag("Cube18");
        }
        if (tictac.level3[0] == 1 && tictac.level2[1] == 1 && tictac.level1[2] == 1 || tictac.level3[0] == 2 && tictac.level2[1] == 2 && tictac.level1[2] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube10");
            current_cube3 = GameObject.FindWithTag("Cube20");
        }
        if (tictac.level3[0] == 1 && tictac.level2[3] == 1 && tictac.level1[6] == 1 || tictac.level3[0] == 2 && tictac.level2[3] == 2 && tictac.level1[6] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube0");
            current_cube2 = GameObject.FindWithTag("Cube12");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }
        if (tictac.level3[8] == 1 && tictac.level2[7] == 1 && tictac.level1[6] == 1 || tictac.level3[8] == 2 && tictac.level2[7] == 2 && tictac.level1[6] == 2)

        {
            current_cube1 = GameObject.FindWithTag("Cube8");
            current_cube2 = GameObject.FindWithTag("Cube16");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }

        if (tictac.level3[2] == 1 && tictac.level2[5] == 1 && tictac.level1[8] == 1 || tictac.level3[2] == 2 && tictac.level2[5] == 2 && tictac.level1[8] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube2");
            current_cube2 = GameObject.FindWithTag("Cube14");
            current_cube3 = GameObject.FindWithTag("Cube26");
        }
        if (tictac.level3[2] == 1 && tictac.level2[4] == 1 && tictac.level1[6] == 1 || tictac.level3[2] == 2 && tictac.level2[4] == 2 && tictac.level1[6] == 2)
        {
            current_cube1 = GameObject.FindWithTag("Cube2");
            current_cube2 = GameObject.FindWithTag("Cube13");
            current_cube3 = GameObject.FindWithTag("Cube24");
        }
        if (tictac.level3[2] == 1 && tictac.level2[1] == 1 && tictac.level1[0] == 1 || tictac.level3[2] == 2 && tictac.level2[1] == 2 && tictac.level1[0] == 2)
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
        if (player_or_user == 2)
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
}
