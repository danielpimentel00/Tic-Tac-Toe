using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class MPManager : NetworkBehaviour
{
    public int PlayerCount = 0;

    public Button[] MPButtons;

    public Text[] MPTexts;

    public GameObject Message;
    public GameObject Main_Instance;

    public bool pressed1 = false;
    public bool pressed2 = false;
    public bool pressed3 = false;
    public bool pressed4 = false;
    public bool pressed5 = false;
    public bool pressed6 = false;
    public bool pressed7 = false;
    public bool pressed8 = false;
    public bool pressed9 = false;
    public bool End = false;

    public int Turn = 0;

    public void PlayGame()
    {
        if (!End)
        {
            if (Turn == 1)
            {
                if (pressed1 && MPTexts[0].text == "")
                {
                    MPTexts[0].text = "X";
                }
                else if (pressed2 && MPTexts[1].text == "")
                {
                    MPTexts[1].text = "X";
                }
                else if (pressed3 && MPTexts[2].text == "")
                {
                    MPTexts[2].text = "X";
                }
                else if (pressed4 && MPTexts[3].text == "")
                {
                    MPTexts[3].text = "X";
                }
                else if (pressed5 && MPTexts[4].text == "")
                {
                    MPTexts[4].text = "X";
                }
                else if (pressed6 && MPTexts[5].text == "")
                {
                    MPTexts[5].text = "X";
                }
                else if (pressed7 && MPTexts[6].text == "")
                {
                    MPTexts[6].text = "X";
                }
                else if (pressed8 && MPTexts[7].text == "")
                {
                    MPTexts[7].text = "X";
                }
                else if (pressed9 && MPTexts[8].text == "")
                {
                    MPTexts[8].text = "X";
                }
            }
            else
            {
                if (pressed1 && MPTexts[0].text == "")
                {
                    MPTexts[0].text = "O";
                }
                else if (pressed2 && MPTexts[1].text == "")
                {
                    MPTexts[1].text = "O";
                }
                else if (pressed3 && MPTexts[2].text == "")
                {
                    MPTexts[2].text = "O";
                }
                else if (pressed4 && MPTexts[3].text == "")
                {
                    MPTexts[3].text = "O";
                }
                else if (pressed5 && MPTexts[4].text == "")
                {
                    MPTexts[4].text = "O";
                }
                else if (pressed6 && MPTexts[5].text == "")
                {
                    MPTexts[5].text = "O";
                }
                else if (pressed7 && MPTexts[6].text == "")
                {
                    MPTexts[6].text = "O";
                }
                else if (pressed8 && MPTexts[7].text == "")
                {
                    MPTexts[7].text = "O";
                }
                else if (pressed9 && MPTexts[8].text == "")
                {
                    MPTexts[8].text = "O";
                }
            }
        }        

        MatchMessage();
    }

    bool YouWon()
    {
        if ((MPTexts[0].text == "X" && MPTexts[1].text == "X" && MPTexts[2].text == "X") ||
       (MPTexts[0].text == "X" && MPTexts[4].text == "X" && MPTexts[8].text == "X") ||
       (MPTexts[0].text == "X" && MPTexts[3].text == "X" && MPTexts[6].text == "X") ||
       (MPTexts[1].text == "X" && MPTexts[4].text == "X" && MPTexts[7].text == "X") ||
       (MPTexts[2].text == "X" && MPTexts[5].text == "X" && MPTexts[8].text == "X") ||
       (MPTexts[3].text == "X" && MPTexts[4].text == "X" && MPTexts[5].text == "X") ||
       (MPTexts[6].text == "X" && MPTexts[7].text == "X" && MPTexts[8].text == "X") ||
       (MPTexts[2].text == "X" && MPTexts[4].text == "X" && MPTexts[6].text == "X"))
        {
            return true;
        }
        else
            return false;
    }

    bool YouLost()
    {
        if ((MPTexts[0].text == "O" && MPTexts[1].text == "O" && MPTexts[2].text == "O") ||
       (MPTexts[0].text == "O" && MPTexts[4].text == "O" && MPTexts[8].text == "O") ||
       (MPTexts[0].text == "O" && MPTexts[3].text == "O" && MPTexts[6].text == "O") ||
       (MPTexts[1].text == "O" && MPTexts[4].text == "O" && MPTexts[7].text == "O") ||
       (MPTexts[2].text == "O" && MPTexts[5].text == "O" && MPTexts[8].text == "O") ||
       (MPTexts[3].text == "O" && MPTexts[4].text == "O" && MPTexts[5].text == "O") ||
       (MPTexts[6].text == "O" && MPTexts[7].text == "O" && MPTexts[8].text == "O") ||
       (MPTexts[2].text == "O" && MPTexts[4].text == "O" && MPTexts[6].text == "O"))
        {
            return true;
        }
        else
            return false;
    }

    void MatchMessage()
    {

        if (YouWon())
        {
            Message.GetComponent<Text>().text = "Has Ganado!";
            
            End = true;

            Main_Instance.GetComponent<Main>().RestartButton.SetActive(true);
        }
        else if (YouLost())
        {
            Message.GetComponent<Text>().text = "Has Perdido";

            End = true;

            Main_Instance.GetComponent<Main>().RestartButton.SetActive(true);
        }
        else if(MPTexts[0].text != "" && MPTexts[1].text != "" && MPTexts[2].text != "" && MPTexts[3].text != "" && MPTexts[4].text != "" &&
            MPTexts[5].text != "" && MPTexts[6].text != "" && MPTexts[7].text != "" && MPTexts[8].text != "")
        {
            Message.GetComponent<Text>().text = "Empate";

            Main_Instance.GetComponent<Main>().RestartButton.SetActive(true);
        }
    }

}
