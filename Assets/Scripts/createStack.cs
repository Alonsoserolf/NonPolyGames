using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class createStack : MonoBehaviour { 

    public Transform brick;
    public static Transform[] stack;

    public Button restart;

    public int bricksLeft;
    private int turn;
    public int[] vals;
    private int score1;
    private int score2;


    public Text countText;
    public Text playerTurn;
    public Text scoreText1;
    public Text scoreText2;
    public Text winText;
    public Text stackVals;

    

    void Start()
    {
        stackVals.text = "";
        score1 = score2 = 0;
        scoreText1.text = "Player 1's score:" + score1.ToString();
        scoreText2.text = "Player 2's score:" + score2.ToString();
        winText.text = "";
        bricksLeft = 10;
        turn = 2;
        switchTurn();
        setCountText();
        stack = new Transform[bricksLeft];
        vals = new int[bricksLeft];
        System.Random rnd = new System.Random();

	    for(int y = 0; y<bricksLeft; y++){
            vals[y] = rnd.Next(1, 11);
            stack[y] = Instantiate(brick, new Vector3(0,y,0), Quaternion.identity);
            setCountText();
        }
        updateVals();
	 }

    private void updateVals()
    {
        stackVals.text = "{";
        for (int x = 0; x < bricksLeft; x++)
        {
            stackVals.text += vals[x].ToString();
            if (x != bricksLeft - 1)
            {
                stackVals.text += ", ";
            }
            else
            {
                stackVals.text += "}";
            }
        }
        if (bricksLeft == 0)
        stackVals.text += "}";

    }

    public void removeBrick(int num)
    {
       
        for (int x = num; x > 0; x--)
        { 
            if (bricksLeft > 0)
            {
                if (turn == 1)
                {
                    score1 += vals[bricksLeft - 1];
                    scoreText1.text = "Player 1's score:" + score1.ToString();
                }
                else
                {
                    score2 += vals[bricksLeft - 1];
                    scoreText2.text = "Player 2's score:" + score2.ToString();
                }
                stack[bricksLeft - 1].gameObject.SetActive(false);
                bricksLeft--;
                setCountText();
            }
        }

        updateVals();
        switchTurn();
        if (bricksLeft == 0)
            endGame();
    }

    void endGame()
    {
        if (score1 > score2)
        {
            winText.text = "Player 1 wins";
        }
        else if (score1 < score2)
        {
            winText.text = "Player 2 wins";
        }
        else
        {
            winText.text = "Tie";
        }
        restart.gameObject.SetActive(true);

    }

    void setCountText()
    {
        countText.text = "Bricks left:"+bricksLeft.ToString();
    }

    void switchTurn()
    {
        if (turn == 1)
        {
            turn = 2;
        }
        else
        {
            turn = 1;
        }

        playerTurn.text = "Player " + turn.ToString() + "'s turn";
    }

    

}

