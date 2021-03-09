using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPManager : MonoBehaviour
{
    public GameObject[] SPButtons;

    public GameObject Main_Instance;

    public Text[] SPTexts;

    public Text Message;

    public bool PlayerTurn;
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
    public bool EasyMode = false;
    public bool NormalMode = false;
    public bool HardMode = false;

    int random;
    public int randomTurn;
    int[] corners = { 0, 2, 6, 8 };
    int[] notcorners = { 1, 3, 5, 7 };
    int[] firstPlay = { 0, 2, 4, 6, 8 };

    void Start()
    {
        randomTurn = Random.Range(0, 2);

        if (randomTurn == 0)
            PlayerTurn = true;
        else
            PlayerTurn = false;
    }

    void Update()
    {
        if (Main_Instance.GetComponent<Main>().SinglePlayer)
        {
            if (!PlayerWon() && !MachineWon() && !End)
                GameSense();
            else
                MatchMessage();
        }
        

        SPButtons[0].GetComponent<Button>().onClick.AddListener(Play1);
        SPButtons[1].GetComponent<Button>().onClick.AddListener(Play2);
        SPButtons[2].GetComponent<Button>().onClick.AddListener(Play3);
        SPButtons[3].GetComponent<Button>().onClick.AddListener(Play4);
        SPButtons[4].GetComponent<Button>().onClick.AddListener(Play5);
        SPButtons[5].GetComponent<Button>().onClick.AddListener(Play6);
        SPButtons[6].GetComponent<Button>().onClick.AddListener(Play7);
        SPButtons[7].GetComponent<Button>().onClick.AddListener(Play8);
        SPButtons[8].GetComponent<Button>().onClick.AddListener(Play9);
        
    }

    void GameSense()
    {
        if (PlayerTurn && pressed1 && SPTexts[0].text == "")
        {
            SPTexts[0].text = "X";
            PlayerTurn = false;
        }
        else if(PlayerTurn && pressed2 && SPTexts[1].text == "")
        {
            SPTexts[1].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed3 && SPTexts[2].text == "")
        {
            SPTexts[2].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed4 && SPTexts[3].text == "")
        {
            SPTexts[3].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed5 && SPTexts[4].text == "")
        {
            SPTexts[4].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed6 && SPTexts[5].text == "")
        {
            SPTexts[5].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed7 && SPTexts[6].text == "")
        {
            SPTexts[6].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed8 && SPTexts[7].text == "")
        {
            SPTexts[7].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed9 && SPTexts[8].text == "")
        {
            SPTexts[8].text = "X";
            PlayerTurn = false;
        }
        else if(!PlayerTurn && EasyMode)
        {
            MachinePlayEasy();
        }
        else if (!PlayerTurn && NormalMode)
        {
            MachinePlayNormal();
        }
        else if (!PlayerTurn && HardMode)
        {
            MachinePlayHard();
        }

    }

    void Play1()
    {
        pressed1 = true;
    }

    void Play2()
    {
        pressed2 = true;
    }

    void Play3()
    {
        pressed3 = true;
    }

    void Play4()
    {
        pressed4 = true;
    }

    void Play5()
    {
        pressed5 = true;
    }

    void Play6()
    {
        pressed6 = true;
    }

    void Play7()
    {
        pressed7 = true;
    }

    void Play8()
    {
        pressed8 = true;
    }

    void Play9()
    {
        pressed9 = true;
    }

    void MachinePlayEasy()
    {
        for (int i = 0; i < 100; i++)
        {
            random = Random.Range(0, 9);

            //jugada para evitar perder  
            if (SPTexts[0].text == "X" && SPTexts[1].text == "X" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[2].text == "X" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[3].text == "X" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[6].text == "X" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[8].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[1].text == "X" && SPTexts[2].text == "X" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[1].text == "X" && SPTexts[4].text == "X" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[1].text == "X" && SPTexts[7].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[4].text == "X" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[6].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[5].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[8].text == "X" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "X" && SPTexts[4].text == "X" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "X" && SPTexts[5].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[3].text == "X" && SPTexts[6].text == "X" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[5].text == "X" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[7].text == "X" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[8].text == "X" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[6].text == "X" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[5].text == "X" && SPTexts[8].text == "X" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[6].text == "X" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[6].text == "X" && SPTexts[8].text == "X" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[7].text == "X" && SPTexts[8].text == "X" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            //default
            else if (SPTexts[random].text == "")
            {
                SPTexts[random].text = "O";
                break;
            }
            else if (SPTexts[0].text != "" && SPTexts[1].text != "" && SPTexts[2].text != "" && SPTexts[3].text != "" && SPTexts[4].text != "" && SPTexts[5].text != ""
                && SPTexts[6].text != "" && SPTexts[7].text != "" && SPTexts[8].text != "")
            {
                End = true;
                break;
            }
        }

        if (SPTexts[0].text != "" && SPTexts[1].text != "" && SPTexts[2].text != "" && SPTexts[3].text != "" && SPTexts[4].text != "" && SPTexts[5].text != ""
                && SPTexts[6].text != "" && SPTexts[7].text != "" && SPTexts[8].text != "")
        {
            End = true;
        }

        pressed1 = false;
        pressed2 = false;
        pressed3 = false;
        pressed4 = false;
        pressed5 = false;
        pressed6 = false;
        pressed7 = false;
        pressed8 = false;
        pressed9 = false;
        PlayerTurn = true;
    }


    void MachinePlayNormal()
    {
        for (int i = 0; i < 100; i++)
        {
            random = Random.Range(0, 9);

            //primera jugada (si empieza la maquina)
            if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                random = Random.Range(0, 5);
                SPTexts[firstPlay[random]].text = "O";
                break;
            }
            //jugada en el centro
            else if (SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            //tratar de ganar con jugada en el centro (x en esquinas)
            //1
            else if (SPTexts[2].text == "X" && SPTexts[4].text == "O" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[4].text == "O" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[3].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[4].text == "O" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            //2
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[6].text = "O";
                break;
            }
            //3
            else if (SPTexts[4].text == "O" && SPTexts[6].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[6].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O"
                && SPTexts[3].text == "" && SPTexts[5].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[6].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "O"
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            //4
            else if (SPTexts[4].text == "O" && SPTexts[8].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[8].text == "X" && SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "X" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[8].text == "X" && SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            //tratar de ganar con jugada en el centro (x en no esquinas)
            else if (SPTexts[4].text == "O" && SPTexts[1].text == "X" && SPTexts[0].text == "" && SPTexts[2].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[5].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[7].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[3].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            //tratar de ganar con jugada en esquina (x en centro)
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            //tratar de ganar con jugada en esquina (x en esquina)
            //1
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "X" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "X" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "X")
            {
                SPTexts[2].text = "O";
                break;
            }
            //2
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "X")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "X")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "X" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            //3
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "X")
            {
                SPTexts[6].text = "O";
                break;
            }
            //4
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "X" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            //tratar de ganar con jugada en esquina (x en no esquina)
            //1
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            //2
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == "O" && SPTexts[3].text == "X" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            //3
            else if (SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            //4
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[4].text = "O";
                break;
            }
            //ultima jugada para ganar  
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "O" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[2].text == "O" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[3].text == "O" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[6].text == "O" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[4].text == "O" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[8].text == "O" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[1].text == "O" && SPTexts[2].text == "O" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[1].text == "O" && SPTexts[4].text == "O" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[1].text == "O" && SPTexts[7].text == "O" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "O" && SPTexts[4].text == "O" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[2].text == "O" && SPTexts[6].text == "O" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "O" && SPTexts[5].text == "O" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[2].text == "O" && SPTexts[8].text == "O" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "O" && SPTexts[4].text == "O" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "O" && SPTexts[5].text == "O" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[3].text == "O" && SPTexts[6].text == "O" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[5].text == "O" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[7].text == "O" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[8].text == "O" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[6].text == "O" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[5].text == "O" && SPTexts[8].text == "O" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[6].text == "O" && SPTexts[7].text == "O" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[6].text == "O" && SPTexts[8].text == "O" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[7].text == "O" && SPTexts[8].text == "O" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            //jugada para evitar perder  
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "X" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[2].text == "X" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[3].text == "X" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[6].text == "X" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[8].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[1].text == "X" && SPTexts[2].text == "X" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[1].text == "X" && SPTexts[4].text == "X" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[1].text == "X" && SPTexts[7].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[4].text == "X" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[6].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[5].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[8].text == "X" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "X" && SPTexts[4].text == "X" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "X" && SPTexts[5].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[3].text == "X" && SPTexts[6].text == "X" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[5].text == "X" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[7].text == "X" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[8].text == "X" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[6].text == "X" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[5].text == "X" && SPTexts[8].text == "X" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[6].text == "X" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[6].text == "X" && SPTexts[8].text == "X" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[7].text == "X" && SPTexts[8].text == "X" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            //default
            else if (SPTexts[random].text == "")
            {
                SPTexts[random].text = "O";
                break;
            }
            else if (SPTexts[0].text != "" && SPTexts[1].text != "" && SPTexts[2].text != "" && SPTexts[3].text != "" && SPTexts[4].text != "" && SPTexts[5].text != ""
                && SPTexts[6].text != "" && SPTexts[7].text != "" && SPTexts[8].text != "")
            {
                End = true;
                break;
            }
        }

        if (SPTexts[0].text != "" && SPTexts[1].text != "" && SPTexts[2].text != "" && SPTexts[3].text != "" && SPTexts[4].text != "" && SPTexts[5].text != ""
                && SPTexts[6].text != "" && SPTexts[7].text != "" && SPTexts[8].text != "")
        {
            End = true;
        }

        pressed1 = false;
        pressed2 = false;
        pressed3 = false;
        pressed4 = false;
        pressed5 = false;
        pressed6 = false;
        pressed7 = false;
        pressed8 = false;
        pressed9 = false;
        PlayerTurn = true;
    }


    void MachinePlayHard()
    {
        for(int i = 0; i<100; i++)
        { 
            random = Random.Range(0, 9);
            //primera jugada (si empieza la maquina)
            if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                random = Random.Range(0, 5);
                SPTexts[firstPlay[random]].text = "O";
                break;
            }
            //jugada en el centro
            else if(SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            //jugada en las esquinas
            else if (SPTexts[4].text == "X" && SPTexts[0].text == "" && SPTexts[2].text == "" && SPTexts[6].text == "" && SPTexts[8].text == "")
            {
                random = Random.Range(0, 4);
                SPTexts[corners[random]].text = "O";
                break;
            }
            //evitar perder cuando juegan en el medio
            else if(SPTexts[4].text == "X" && SPTexts[0].text == "O" && SPTexts[8].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[2].text == "O" && SPTexts[6].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[8].text == "O" && SPTexts[0].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[6].text == "O" && SPTexts[2].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            //evitar perder cuando juegan en las esquinas
            else if (SPTexts[2].text == "X" && SPTexts[4].text == "O" && SPTexts[6].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                random = Random.Range(0, 4);
                SPTexts[notcorners[random]].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "O" && SPTexts[8].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "")
            {
                random = Random.Range(0, 4);
                SPTexts[notcorners[random]].text = "O";
                break;
            }
            //tratar de ganar con jugada en el centro (x en esquinas)
            //1
            else if(SPTexts[2].text == "X" && SPTexts[4].text == "O" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[4].text == "O" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[3].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[4].text == "O" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            //2
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[6].text = "O";
                break;
            }
            //3
            else if (SPTexts[4].text == "O" && SPTexts[6].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[6].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O"
                && SPTexts[3].text == "" && SPTexts[5].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[6].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "O"
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            //4
            else if (SPTexts[4].text == "O" && SPTexts[8].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[8].text == "X" && SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "X" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[8].text == "X" && SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            //tratar de ganar con jugada en el centro (x en no esquinas)
            else if (SPTexts[4].text == "O" && SPTexts[1].text == "X" && SPTexts[0].text == "" && SPTexts[2].text == "" && SPTexts[3].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[5].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[7].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[3].text == "" && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[3].text == "X" && SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            //tratar de ganar con jugada en esquina (x en centro)
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == "X"
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            //tratar de ganar con jugada en esquina (x en esquina)
            //1
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "X" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "X" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "X")
            {
                SPTexts[2].text = "O";
                break;
            }
            //2
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "X")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "X")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "X" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            //3
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "X")
            {
                SPTexts[6].text = "O";
                break;
            }
            //4
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "X" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "X" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            //tratar de ganar con jugada en esquina (x en no esquina)
            //1
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            //2
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == "O" && SPTexts[3].text == "X" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "O" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            //3
            else if (SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "X" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            //4
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "O" && SPTexts[3].text == "" && SPTexts[4].text == ""
                && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "X" && SPTexts[6].text == "O" && SPTexts[7].text == "X" && SPTexts[8].text == "O")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "" && SPTexts[2].text == "" && SPTexts[3].text == "X" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[0].text == "" && SPTexts[1].text == "X" && SPTexts[2].text == "" && SPTexts[3].text == "" && SPTexts[4].text == ""
               && SPTexts[5].text == "" && SPTexts[6].text == "" && SPTexts[7].text == "" && SPTexts[8].text == "O")
            {
                SPTexts[4].text = "O";
                break;
            }
            //ultima jugada para ganar  
            else if (SPTexts[0].text == "O" && SPTexts[1].text == "O" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[2].text == "O" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[3].text == "O" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[6].text == "O" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[4].text == "O" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "O" && SPTexts[8].text == "O" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[1].text == "O" && SPTexts[2].text == "O" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[1].text == "O" && SPTexts[4].text == "O" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[1].text == "O" && SPTexts[7].text == "O" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "O" && SPTexts[4].text == "O" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[2].text == "O" && SPTexts[6].text == "O" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "O" && SPTexts[5].text == "O" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[2].text == "O" && SPTexts[8].text == "O" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "O" && SPTexts[4].text == "O" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "O" && SPTexts[5].text == "O" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[3].text == "O" && SPTexts[6].text == "O" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[5].text == "O" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[7].text == "O" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[8].text == "O" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "O" && SPTexts[6].text == "O" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[5].text == "O" && SPTexts[8].text == "O" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[6].text == "O" && SPTexts[7].text == "O" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[6].text == "O" && SPTexts[8].text == "O" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[7].text == "O" && SPTexts[8].text == "O" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            //jugada para evitar perder  
            else if (SPTexts[0].text == "X" && SPTexts[1].text == "X" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[2].text == "X" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[3].text == "X" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[6].text == "X" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[4].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[0].text == "X" && SPTexts[8].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[1].text == "X" && SPTexts[2].text == "X" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[1].text == "X" && SPTexts[4].text == "X" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[1].text == "X" && SPTexts[7].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[4].text == "X" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[6].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[5].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[2].text == "X" && SPTexts[8].text == "X" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "X" && SPTexts[4].text == "X" && SPTexts[5].text == "")
            {
                SPTexts[5].text = "O";
                break;
            }
            else if (SPTexts[3].text == "X" && SPTexts[5].text == "X" && SPTexts[4].text == "")
            {
                SPTexts[4].text = "O";
                break;
            }
            else if (SPTexts[3].text == "X" && SPTexts[6].text == "X" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[5].text == "X" && SPTexts[3].text == "")
            {
                SPTexts[3].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[7].text == "X" && SPTexts[1].text == "")
            {
                SPTexts[1].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[8].text == "X" && SPTexts[0].text == "")
            {
                SPTexts[0].text = "O";
                break;
            }
            else if (SPTexts[4].text == "X" && SPTexts[6].text == "X" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[5].text == "X" && SPTexts[8].text == "X" && SPTexts[2].text == "")
            {
                SPTexts[2].text = "O";
                break;
            }
            else if (SPTexts[6].text == "X" && SPTexts[7].text == "X" && SPTexts[8].text == "")
            {
                SPTexts[8].text = "O";
                break;
            }
            else if (SPTexts[6].text == "X" && SPTexts[8].text == "X" && SPTexts[7].text == "")
            {
                SPTexts[7].text = "O";
                break;
            }
            else if (SPTexts[7].text == "X" && SPTexts[8].text == "X" && SPTexts[6].text == "")
            {
                SPTexts[6].text = "O";
                break;
            }
            //default
            else if (SPTexts[random].text == "")
            {
                SPTexts[random].text = "O";
                break;
            }
            else if(SPTexts[0].text != "" && SPTexts[1].text != "" && SPTexts[2].text != "" && SPTexts[3].text != "" && SPTexts[4].text != "" && SPTexts[5].text != "" 
                && SPTexts[6].text != "" && SPTexts[7].text != "" && SPTexts[8].text != "")
            {
                End = true;
                break;
            }
        }

        if (SPTexts[0].text != "" && SPTexts[1].text != "" && SPTexts[2].text != "" && SPTexts[3].text != "" && SPTexts[4].text != "" && SPTexts[5].text != ""
                && SPTexts[6].text != "" && SPTexts[7].text != "" && SPTexts[8].text != "")
        {
            End = true;
        }

        pressed1 = false;
        pressed2 = false;
        pressed3 = false;
        pressed4 = false;
        pressed5 = false;
        pressed6 = false;
        pressed7 = false;
        pressed8 = false;
        pressed9 = false;
        PlayerTurn = true;
    }

    bool PlayerWon()
    {
        if ((SPTexts[0].text == "X" && SPTexts[1].text == "X" && SPTexts[2].text == "X") ||
       (SPTexts[0].text == "X" && SPTexts[4].text == "X" && SPTexts[8].text == "X") ||
       (SPTexts[0].text == "X" && SPTexts[3].text == "X" && SPTexts[6].text == "X") ||
       (SPTexts[1].text == "X" && SPTexts[4].text == "X" && SPTexts[7].text == "X") ||
       (SPTexts[2].text == "X" && SPTexts[5].text == "X" && SPTexts[8].text == "X") ||
       (SPTexts[3].text == "X" && SPTexts[4].text == "X" && SPTexts[5].text == "X") ||
       (SPTexts[6].text == "X" && SPTexts[7].text == "X" && SPTexts[8].text == "X") ||
       (SPTexts[2].text == "X" && SPTexts[4].text == "X" && SPTexts[6].text == "X"))
        {
            return true;
        }
        else
            return false;
    }

    bool MachineWon()
    {
        if ((SPTexts[0].text == "O" && SPTexts[1].text == "O" && SPTexts[2].text == "O") ||
       (SPTexts[0].text == "O" && SPTexts[4].text == "O" && SPTexts[8].text == "O") ||
       (SPTexts[0].text == "O" && SPTexts[3].text == "O" && SPTexts[6].text == "O") ||
       (SPTexts[1].text == "O" && SPTexts[4].text == "O" && SPTexts[7].text == "O") ||
       (SPTexts[2].text == "O" && SPTexts[5].text == "O" && SPTexts[8].text == "O") ||
       (SPTexts[3].text == "O" && SPTexts[4].text == "O" && SPTexts[5].text == "O") ||
       (SPTexts[6].text == "O" && SPTexts[7].text == "O" && SPTexts[8].text == "O") ||
       (SPTexts[2].text == "O" && SPTexts[4].text == "O" && SPTexts[6].text == "O"))
        {
            return true;
        }
        else
            return false;
    }

    void MatchMessage()
    {
        if (PlayerWon())
        {
            Message.GetComponent<Text>().text = "Has Ganado!";
            End = true;
        }
        else if (MachineWon())
        {
            Message.GetComponent<Text>().text = "Has Perdido";
            End = true;
        }
        else
            Message.GetComponent<Text>().text = "Empate";

    }
}