using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MLAPI;
using MLAPI.Messaging;

public class MPManager : NetworkedBehaviour
{
    public GameObject HostButton;
    public GameObject JoinButton;
    public GameObject StatusMessage;
    public GameObject Main_Instance;
    public GameObject Player_Instance;

    public GameObject[] MPButtons;

    public Text[] MPTexts;

    public bool pressed1;
    public bool pressed2;
    public bool pressed3;
    public bool pressed4;
    public bool pressed5;
    public bool pressed6;
    public bool pressed7;
    public bool pressed8;
    public bool pressed9;

    public bool HostConnected;
    public bool ClientConnected;
    public bool CanPlay;
    public bool HostTurn;
    public bool connected;

    void Start()
    {
        HostTurn = true;
        HostConnected = false;
        ClientConnected = false;
        connected = false;
        CanPlay = false;

        pressed1 = false;
        pressed2 = false;
        pressed3 = false;
        pressed4 = false;
        pressed5 = false;
        pressed6 = false;
        pressed7 = false;
        pressed8 = false;
        pressed9 = false;

        StatusMessage.SetActive(false);
    }

    void Update()
    {
        if(HostConnected && ClientConnected && !connected)
        {
            Debug.Log("Connected");
            connected = true;
        }

        if (HostConnected && ClientConnected)
        {
            InvokeClientRpcOnEveryone(PlayGame);
        }


        /*MPButtons[0].GetComponent<Button>().onClick.AddListener(Play1);
        MPButtons[1].GetComponent<Button>().onClick.AddListener(Play2);
        MPButtons[2].GetComponent<Button>().onClick.AddListener(Play3);
        MPButtons[3].GetComponent<Button>().onClick.AddListener(Play4);
        MPButtons[4].GetComponent<Button>().onClick.AddListener(Play5);
        MPButtons[5].GetComponent<Button>().onClick.AddListener(Play6);
        MPButtons[6].GetComponent<Button>().onClick.AddListener(Play7);
        MPButtons[7].GetComponent<Button>().onClick.AddListener(Play8);
        MPButtons[8].GetComponent<Button>().onClick.AddListener(Play9);*/
    }

    public void Host()
    {
        HostButton.SetActive(false);
        JoinButton.SetActive(false);

        NetworkingManager.Singleton.StartHost();

        StatusMessage.SetActive(true);

        Main_Instance.GetComponent<Main>().MenuButton.SetActive(false);
    }

    public void Join()
    {
        HostButton.SetActive(false);
        JoinButton.SetActive(false);

        NetworkingManager.Singleton.StartClient();

        StatusMessage.SetActive(true);

        Main_Instance.GetComponent<Main>().MenuButton.SetActive(false);
    }

    //[ClientRPC][ServerRPC]
    public void PlayGame()
    {
        StatusMessage.SetActive(false);

        Main_Instance.GetComponent<Main>().GameButtons.SetActive(true);

        if (pressed1 && MPTexts[0].text == "")
        {
            MPTexts[0].text = "X";
            //HostTurn = false;
        }
        else if (HostTurn && pressed2 && MPTexts[1].text == "")
        {
            MPTexts[1].text = "X";
            //HostTurn = false;
        }
        else if (HostTurn && pressed3 && MPTexts[2].text == "")
        {
            MPTexts[2].text = "X";
            //HostTurn = false;
        }
        else if (HostTurn && pressed4 && MPTexts[3].text == "")
        {
            MPTexts[3].text = "X";
            //HostTurn = false;
        }
        else if (HostTurn && pressed5 && MPTexts[4].text == "")
        {
            MPTexts[4].text = "X";
            //HostTurn = false;
        }
        else if (HostTurn && pressed6 && MPTexts[5].text == "")
        {
            MPTexts[5].text = "X";
            HostTurn = false;
        }
        else if (HostTurn && pressed7 && MPTexts[6].text == "")
        {
            MPTexts[6].text = "X";
            HostTurn = false;
        }
        else if (HostTurn && pressed8 && MPTexts[7].text == "")
        {
            MPTexts[7].text = "X";
            HostTurn = false;
        }
        else if (HostTurn && pressed9 && MPTexts[8].text == "")
        {
            MPTexts[8].text = "X";
            HostTurn = false;
        }
    }

    public void Play1()
    {
        //Player_Instance.GetComponent<PlayerScript>().pressed1 = true;
    }

    public void Play2()
    {
        pressed2 = true;
    }

    public void Play3()
    {
        pressed3 = true;
    }

    public void Play4()
    {
        pressed4 = true;
    }

    public void Play5()
    {
        pressed5 = true;
    }

    public void Play6()
    {
        pressed6 = true;
    }

    public void Play7()
    {
        pressed7 = true;
    }

    public void Play8()
    {
        pressed8 = true;
    }

    public void Play9()
    {
        pressed9 = true;
    }


}
