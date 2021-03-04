using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPManager : MonoBehaviour
{
    public GameObject[] SPButton;

    public GameObject Main_Instance;

    public Text[] Text;

    public Text Message;

    public bool PlayerTurn;
    public bool pressed1;
    public bool pressed2;
    public bool pressed3;
    public bool pressed4;
    public bool pressed5;
    public bool pressed6;
    public bool pressed7;
    public bool pressed8;
    public bool pressed9;
    public bool End;

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

        pressed1 = false;
        pressed2 = false;
        pressed3 = false;
        pressed4 = false;
        pressed5 = false;
        pressed6 = false;
        pressed7 = false;
        pressed8 = false;
        pressed9 = false;
        End = false;

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
        

        SPButton[0].GetComponent<Button>().onClick.AddListener(Play1);
        SPButton[1].GetComponent<Button>().onClick.AddListener(Play2);
        SPButton[2].GetComponent<Button>().onClick.AddListener(Play3);
        SPButton[3].GetComponent<Button>().onClick.AddListener(Play4);
        SPButton[4].GetComponent<Button>().onClick.AddListener(Play5);
        SPButton[5].GetComponent<Button>().onClick.AddListener(Play6);
        SPButton[6].GetComponent<Button>().onClick.AddListener(Play7);
        SPButton[7].GetComponent<Button>().onClick.AddListener(Play8);
        SPButton[8].GetComponent<Button>().onClick.AddListener(Play9);
        
    }

    void GameSense()
    {
        if (PlayerTurn && pressed1 && Text[0].text == "")
        {
            Text[0].text = "X";
            PlayerTurn = false;
        }
        else if(PlayerTurn && pressed2 && Text[1].text == "")
        {
            Text[1].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed3 && Text[2].text == "")
        {
            Text[2].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed4 && Text[3].text == "")
        {
            Text[3].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed5 && Text[4].text == "")
        {
            Text[4].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed6 && Text[5].text == "")
        {
            Text[5].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed7 && Text[6].text == "")
        {
            Text[6].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed8 && Text[7].text == "")
        {
            Text[7].text = "X";
            PlayerTurn = false;
        }
        else if (PlayerTurn && pressed9 && Text[8].text == "")
        {
            Text[8].text = "X";
            PlayerTurn = false;
        }
        else if(!PlayerTurn)
        {
            MachinePlay();
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

    void MachinePlay()
    {
        for(int i = 0; i<100; i++)
        { 
            random = Random.Range(0, 5);
            //primera jugada (si empieza la maquina)
            if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[firstPlay[random]].text = "O";
                break;
            }
            //jugada en el centro
            else if(Text[4].text == "")
            {
                Text[4].text = "O";
                break;
            }
            //jugada en las esquinas
            else if (Text[4].text == "X" && Text[0].text == "" && Text[2].text == "" && Text[6].text == "" && Text[8].text == "")
            {
                random = Random.Range(0, 4);
                Text[corners[random]].text = "O";
                break;
            }
            //evitar perder cuando juegan en el medio
            else if(Text[4].text == "X" && Text[0].text == "O" && Text[8].text == "X" && Text[1].text == "" && Text[2].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[6].text == "" && Text[7].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[4].text == "X" && Text[2].text == "O" && Text[6].text == "X" && Text[0].text == "" && Text[1].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[4].text == "X" && Text[8].text == "O" && Text[0].text == "X" && Text[1].text == "" && Text[2].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[6].text == "" && Text[7].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[4].text == "X" && Text[6].text == "O" && Text[2].text == "X" && Text[0].text == "" && Text[1].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[0].text = "O";
                break;
            }
            //evitar perder cuando juegan en las esquinas
            else if (Text[2].text == "X" && Text[4].text == "O" && Text[6].text == "X" && Text[0].text == "" && Text[1].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                random = Random.Range(0, 4);
                Text[notcorners[random]].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[4].text == "O" && Text[8].text == "X" && Text[1].text == "" && Text[2].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[6].text == "" && Text[7].text == "")
            {
                random = Random.Range(0, 4);
                Text[notcorners[random]].text = "O";
                break;
            }
            //tratar de ganar con jugada en el centro (x en esquinas)
            //1
            else if(Text[2].text == "X" && Text[4].text == "O" && Text[0].text == "" && Text[1].text == "" && Text[3].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[2].text == "X" && Text[4].text == "O" && Text[0].text == "" && Text[1].text == "" && Text[3].text == "X"
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[2].text == "X" && Text[4].text == "O" && Text[0].text == "" && Text[1].text == "" && Text[3].text == ""
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "X" && Text[8].text == "")
            {
                Text[0].text = "O";
                break;
            }
            //2
            else if (Text[0].text == "X" && Text[4].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[4].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "X" && Text[8].text == "O")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[4].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == ""
                && Text[5].text == "X" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[6].text = "O";
                break;
            }
            //3
            else if (Text[4].text == "O" && Text[6].text == "X" && Text[0].text == "" && Text[1].text == "" && Text[2].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[6].text == "X" && Text[0].text == "" && Text[1].text == "" && Text[2].text == "O"
                && Text[3].text == "" && Text[5].text == "X" && Text[7].text == "" && Text[8].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[6].text == "X" && Text[0].text == "" && Text[1].text == "X" && Text[2].text == "O"
                && Text[3].text == "" && Text[5].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            //4
            else if (Text[4].text == "O" && Text[8].text == "X" && Text[0].text == "" && Text[1].text == "" && Text[2].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[6].text == "" && Text[7].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[8].text == "X" && Text[0].text == "O" && Text[1].text == "" && Text[2].text == ""
                && Text[3].text == "X" && Text[5].text == "" && Text[6].text == "" && Text[7].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[8].text == "X" && Text[0].text == "O" && Text[1].text == "X" && Text[2].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[6].text == "" && Text[7].text == "")
            {
                Text[6].text = "O";
                break;
            }
            //tratar de ganar con jugada en el centro (x en no esquinas)
            else if (Text[4].text == "O" && Text[1].text == "X" && Text[0].text == "" && Text[2].text == "" && Text[3].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[5].text == "X" && Text[0].text == "" && Text[1].text == "" && Text[2].text == ""
                && Text[3].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[7].text == "X" && Text[0].text == "" && Text[1].text == "" && Text[2].text == ""
                && Text[3].text == "" && Text[5].text == "" && Text[6].text == "" && Text[8].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[3].text == "X" && Text[0].text == "" && Text[1].text == "" && Text[2].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            //tratar de ganar con jugada en esquina (x en centro)
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == "X"
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == "X"
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == "X"
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == "X"
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[0].text = "O";
                break;
            }
            //tratar de ganar con jugada en esquina (x en esquina)
            //1
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "X" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "X" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "X" && Text[8].text == "O")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "X")
            {
                Text[2].text = "O";
                break;
            }
            //2
            else if (Text[0].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "X")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "X" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "X")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "" && Text[2].text == "X" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "X" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            //3
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "X" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "X" && Text[6].text == "X" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "X")
            {
                Text[6].text = "O";
                break;
            }
            //4
            else if (Text[0].text == "X" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "X" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "X" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "X" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[0].text = "O";
                break;
            }
            //tratar de ganar con jugada en esquina (x en no esquina)
            //1
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "X" && Text[8].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "X" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "X" && Text[8].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "X" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "X" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "X" && Text[8].text == "O")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "X" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "X" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "")
            {
                Text[4].text = "O";
                break;
            }
            //2
            else if (Text[0].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "X" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "X" && Text[2].text == "O" && Text[3].text == "X" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "X" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "X" && Text[2].text == "" && Text[3].text == "X" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "O" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "" && Text[7].text == "X" && Text[8].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "X" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[4].text = "O";
                break;
            }
            //3
            else if (Text[0].text == "" && Text[1].text == "X" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "X" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "X" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "X" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[1].text == "X" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "X" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "X" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "" && Text[7].text == "X" && Text[8].text == "")
            {
                Text[4].text = "O";
                break;
            }
            //4
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "" && Text[6].text == "" && Text[7].text == "X" && Text[8].text == "O")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "O" && Text[3].text == "" && Text[4].text == ""
                && Text[5].text == "X" && Text[6].text == "" && Text[7].text == "X" && Text[8].text == "O")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "X" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "X" && Text[6].text == "O" && Text[7].text == "X" && Text[8].text == "O")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "" && Text[2].text == "" && Text[3].text == "X" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[0].text == "" && Text[1].text == "X" && Text[2].text == "" && Text[3].text == "" && Text[4].text == ""
               && Text[5].text == "" && Text[6].text == "" && Text[7].text == "" && Text[8].text == "O")
            {
                Text[4].text = "O";
                break;
            }
            //ultima jugada para ganar  
            else if (Text[0].text == "O" && Text[1].text == "O" && Text[2].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[2].text == "O" && Text[1].text == "")
            {
                Text[1].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[3].text == "O" && Text[6].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[6].text == "O" && Text[3].text == "")
            {
                Text[3].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[4].text == "O" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "O" && Text[8].text == "O" && Text[4].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[1].text == "O" && Text[2].text == "O" && Text[0].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[1].text == "O" && Text[4].text == "O" && Text[7].text == "")
            {
                Text[7].text = "O";
                break;
            }
            else if (Text[1].text == "O" && Text[7].text == "O" && Text[4].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[2].text == "O" && Text[4].text == "O" && Text[6].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[2].text == "O" && Text[6].text == "O" && Text[4].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[2].text == "O" && Text[5].text == "O" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[2].text == "O" && Text[8].text == "O" && Text[5].text == "")
            {
                Text[5].text = "O";
                break;
            }
            else if (Text[3].text == "O" && Text[4].text == "O" && Text[5].text == "")
            {
                Text[5].text = "O";
                break;
            }
            else if (Text[3].text == "O" && Text[5].text == "O" && Text[4].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[3].text == "O" && Text[6].text == "O" && Text[0].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[5].text == "O" && Text[3].text == "")
            {
                Text[3].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[7].text == "O" && Text[1].text == "")
            {
                Text[1].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[8].text == "O" && Text[0].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[4].text == "O" && Text[6].text == "O" && Text[2].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[5].text == "O" && Text[8].text == "O" && Text[2].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[6].text == "O" && Text[7].text == "O" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[6].text == "O" && Text[8].text == "O" && Text[7].text == "")
            {
                Text[7].text = "O";
                break;
            }
            else if (Text[7].text == "O" && Text[8].text == "O" && Text[6].text == "")
            {
                Text[6].text = "O";
                break;
            }
            //jugada para evitar perder  
            else if (Text[0].text == "X" && Text[1].text == "X" && Text[2].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[2].text == "X" && Text[1].text == "")
            {
                Text[1].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[3].text == "X" && Text[6].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[6].text == "X" && Text[3].text == "")
            {
                Text[3].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[4].text == "X" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[0].text == "X" && Text[8].text == "X" && Text[4].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[1].text == "X" && Text[2].text == "X" && Text[0].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[1].text == "X" && Text[4].text == "X" && Text[7].text == "")
            {
                Text[7].text = "O";
                break;
            }
            else if (Text[1].text == "X" && Text[7].text == "X" && Text[4].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[2].text == "X" && Text[4].text == "X" && Text[6].text == "")
            {
                Text[6].text = "O";
                break;
            }
            else if (Text[2].text == "X" && Text[6].text == "X" && Text[4].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[2].text == "X" && Text[5].text == "X" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[2].text == "X" && Text[8].text == "X" && Text[5].text == "")
            {
                Text[5].text = "O";
                break;
            }
            else if (Text[3].text == "X" && Text[4].text == "X" && Text[5].text == "")
            {
                Text[5].text = "O";
                break;
            }
            else if (Text[3].text == "X" && Text[5].text == "X" && Text[4].text == "")
            {
                Text[4].text = "O";
                break;
            }
            else if (Text[3].text == "X" && Text[6].text == "X" && Text[0].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[4].text == "X" && Text[5].text == "X" && Text[3].text == "")
            {
                Text[3].text = "O";
                break;
            }
            else if (Text[4].text == "X" && Text[7].text == "X" && Text[1].text == "")
            {
                Text[1].text = "O";
                break;
            }
            else if (Text[4].text == "X" && Text[8].text == "X" && Text[0].text == "")
            {
                Text[0].text = "O";
                break;
            }
            else if (Text[4].text == "X" && Text[6].text == "X" && Text[2].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[5].text == "X" && Text[8].text == "X" && Text[2].text == "")
            {
                Text[2].text = "O";
                break;
            }
            else if (Text[6].text == "X" && Text[7].text == "X" && Text[8].text == "")
            {
                Text[8].text = "O";
                break;
            }
            else if (Text[6].text == "X" && Text[8].text == "X" && Text[7].text == "")
            {
                Text[7].text = "O";
                break;
            }
            else if (Text[7].text == "X" && Text[8].text == "X" && Text[6].text == "")
            {
                Text[6].text = "O";
                break;
            }
            //default
            else if (Text[random].text == "")
            {
                Text[random].text = "O";
                break;
            }
            else if(Text[0].text != "" && Text[1].text != "" && Text[2].text != "" && Text[3].text != "" && Text[4].text != "" && Text[5].text != "" 
                && Text[6].text != "" && Text[7].text != "" && Text[8].text != "")
            {
                End = true;
                break;
            }
        }

        if (Text[0].text != "" && Text[1].text != "" && Text[2].text != "" && Text[3].text != "" && Text[4].text != "" && Text[5].text != ""
                && Text[6].text != "" && Text[7].text != "" && Text[8].text != "")
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
        if ((Text[0].text == "X" && Text[1].text == "X" && Text[2].text == "X") ||
       (Text[0].text == "X" && Text[4].text == "X" && Text[8].text == "X") ||
       (Text[0].text == "X" && Text[3].text == "X" && Text[6].text == "X") ||
       (Text[1].text == "X" && Text[4].text == "X" && Text[7].text == "X") ||
       (Text[2].text == "X" && Text[5].text == "X" && Text[8].text == "X") ||
       (Text[3].text == "X" && Text[4].text == "X" && Text[5].text == "X") ||
       (Text[6].text == "X" && Text[7].text == "X" && Text[8].text == "X") ||
       (Text[2].text == "X" && Text[4].text == "X" && Text[6].text == "X"))
        {
            return true;
        }
        else
            return false;
    }

    bool MachineWon()
    {
        if ((Text[0].text == "O" && Text[1].text == "O" && Text[2].text == "O") ||
       (Text[0].text == "O" && Text[4].text == "O" && Text[8].text == "O") ||
       (Text[0].text == "O" && Text[3].text == "O" && Text[6].text == "O") ||
       (Text[1].text == "O" && Text[4].text == "O" && Text[7].text == "O") ||
       (Text[2].text == "O" && Text[5].text == "O" && Text[8].text == "O") ||
       (Text[3].text == "O" && Text[4].text == "O" && Text[5].text == "O") ||
       (Text[6].text == "O" && Text[7].text == "O" && Text[8].text == "O") ||
       (Text[2].text == "O" && Text[4].text == "O" && Text[6].text == "O"))
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