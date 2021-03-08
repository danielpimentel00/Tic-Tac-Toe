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

    public bool pressed1 = false;
    public bool pressed2 = false;
    public bool pressed3 = false;
    public bool pressed4 = false;
    public bool pressed5 = false;
    public bool pressed6 = false;
    public bool pressed7 = false;
    public bool pressed8 = false;
    public bool pressed9 = false;

    public int Turn = 0;

    public void PlayGame()
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
}
