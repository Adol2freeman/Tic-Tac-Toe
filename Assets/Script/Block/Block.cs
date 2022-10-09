using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    string Round;
    public string[,] A = new string[3, 3] { { "E", "E", "E" }, { "E", "E", "E" }, { "E", "E", "E" } };
    // Start is called before the first frame update

    void Start()
    {
        Round = "O";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (string i in A)
            {
                Debug.Log(i);
            }
        }
    }

    public void Pushing(GameObject a)
    {
        if (Round == "O")
        {
            a.GetComponent<Text>().text = "O";
            Round = "X";
        }
        else
        {
            a.GetComponent<Text>().text = "X";
            Round = "O";
        }
    }

    public void Mase(int S)
    {
        int x = S / 3;
        int y = S - (S / 3) * 3;
        if (Round == "O")
        {
            A[x, y] = "X";
        }
        else
        {
            A[x, y] = "O";
        }
    }

    public void StopButon(Button B)
    {
        B.enabled = false;
    }

    public void Decision()
    {
        //橫
        for (int i = 0; i < 3; i++)
        {
            int cur_o = 0;
            int cur_x = 0;
            for (int j = 0; j < 3; j++)
            {
                //Debug.Log(i + " " + j + A[i, j]);
                if (A[i, j] == "O")
                {
                    cur_o += 1;
                }
                else if (A[i, j] == "X")
                {
                    cur_x += 1;
                }
                     

            }
            //Debug.Log(i + " " + cur_o + " " + cur_x);

            if (cur_x == 3)
            {
                Debug.Log("Player2 win.");
            }
            if (cur_o == 3)
            {
                Debug.Log("Player1 win.");
            }
        }

        //直
        for (int i = 0; i < 3; i++)
        {
            int cur_o = 0;
            int cur_x = 0;
            for (int j = 0; j < 3; j++)
            {
                //Debug.Log(i + " " + j + A[i, j]);
                if (A[j, i] == "O")
                {
                    cur_o += 1;
                }
                else if (A[j, i] == "X")
                {
                    cur_x += 1;
                }
                else if (A[j, i] == "E")
                {
                    break;
                }

            }
            //Debug.Log(i + " " + cur_o + " " + cur_x);

            if (cur_x == 3)
            {
                Debug.Log("Player2 win.");
            }
            if (cur_o == 3)
            {
                Debug.Log("Player1 win.");
            }
        }

        //斜 
        if(A[0,0] == "O" & A[1,1] == "O" & A[2,2] == "O")
        {
            Debug.Log("Player1 win.");
        }
        else if (A[0, 0] == "X" & A[1, 1] == "X" & A[2, 2] == "X")
        {
            Debug.Log("Player2 win.");
        }

        if (A[0, 2] == "O" & A[1, 1] == "O" & A[2, 0] == "O")
        {
            Debug.Log("Player1 win.");
        }
        else if (A[0, 2] == "X" & A[1, 1] == "X" & A[2, 0] == "X")
        {
            Debug.Log("Player2 win.");
        }

    }
}