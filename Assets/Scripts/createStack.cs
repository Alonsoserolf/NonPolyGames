using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class createStack : MonoBehaviour
{

    public Transform brick;
    public static Transform[] stack;

    public Button restart;
    public Button take1;
    public Button take2;

    public int bricksLeft;
    private int turn;
    public int[] vals;
    public int[] optimalPlays;
    private int score1;
    private int score2;
    public static int mode;

   
    public Text playerTurn;
    public Text scoreText1;
    public Text scoreText2;
    public Text winText;
    public Text stackVals;
    public Text plus1;
    public Text plus2;



    void Start()
    {
        stackVals.text = "";
        score1 = score2 = 0;
        scoreText1.text = "Score 1\n" + score1.ToString();
        scoreText2.text = "Score 2\n" + score2.ToString();
        winText.text = "";
        bricksLeft = 10;
        turn = 2;
        switchTurn();

        stack = new Transform[bricksLeft];
        vals = new int[bricksLeft];
        optimalPlays = new int[bricksLeft];
        System.Random rnd = new System.Random();

        for (int y = 0; y < bricksLeft; y++)
        {
            vals[y] = rnd.Next(1, 11);
            stack[y] = Instantiate(brick, new Vector3(0, y, 0), Quaternion.identity);
          /*TextMesh t = stack[y].gameObject.AddComponent<TextMesh>();
            t.text = vals[y].ToString();
            t.fontSize = 20;
            t.font = Resources.GetBuiltinResource(typeof(Font), "neuropol x rg.ttf") as Font ;*/
        }
        updateVals();
        optimal(bricksLeft - 1);
    }



    private void updateVals()
    {
        stackVals.text = "";
        for (int x = bricksLeft - 1; x >= 0; x--)
        {
            Console.WriteLine("brick val =" + vals[x]);
            stackVals.text += vals[x].ToString() + "\n";
        }

    }

    public void removeBrick(int num)
    {
        int total = 0;
        for (int x = num; x > 0; x--)
        {
            if (bricksLeft > 0)
            {
                total+=vals[bricksLeft - 1]; 
                if (turn == 1)
                {
                    score1 += vals[bricksLeft - 1];
                    scoreText1.text = "Score 1\n" + score1.ToString();
                }
                else
                {
                    score2 += vals[bricksLeft - 1];
                    scoreText2.text = "Score 2\n" + score2.ToString();
                }
                stack[bricksLeft - 1].gameObject.SetActive(false);
                bricksLeft--;
            }
        }
        updateVals();
        if (mode == 1 && turn == 1)
        {
            take1.interactable = false;
            take2.interactable = false;
            StartCoroutine("compTurn");
           
        }
        if(turn==1)
            plus1.gameObject.GetComponent<Fade>().StartFade(total);
        else
            plus2.gameObject.GetComponent<Fade>().StartFade(total);

        switchTurn();
        if (bricksLeft == 0)
            endGame();
    }

    IEnumerator compTurn()
    {
        yield return new WaitForSeconds(3.0f);
        take1.interactable = true;
        take2.interactable = true;
        if (optimalPlays[bricksLeft - 1] == 1)
            removeBrick(1);
        else
            removeBrick(2);
    }

    int optimal(int ind)
    {
        if (ind <= 0)
        {
            if (ind == 0)
            {
                optimalPlays[0] = 2;
                return vals[0];
            }
            else
                return 0;
        }
        else
        {
            int take1 = min(optimal(ind - 2), optimal(ind - 3));
            int take2 = vals[ind - 1] + min(optimal(ind - 3), optimal(ind - 4));

            if (take1 > take2)
                optimalPlays[ind] = 1;
            else
                optimalPlays[ind] = 2;

            return vals[ind] + max(take1, take2);
        }
    }

    int max(int x, int y)
    {
        if (x > y)
            return x;
        else
            return y;
    }

    int min(int x, int y)
    {
        if (x > y)
            return y;
        else
            return x;
    }
    void endGame()
    {
        if (score1 > score2)
        {
            winText.color = Color.red;
            winText.text = "Player 1 wins";
        }
        else if (score1 < score2)
        {
            winText.color = Color.blue;
            winText.text = "Player 2 wins";
        }
        else
        {
            winText.text = "Tie";
        }
        restart.gameObject.SetActive(true);

    }

    void switchTurn()
    {
        if (turn == 1)
        {
            turn = 2;
            playerTurn.color = Color.blue;
        }
        else
        {
            turn = 1;
            playerTurn.color = Color.red;
        }

        playerTurn.text = "Player " + turn.ToString() + "'s turn";

    }


}

