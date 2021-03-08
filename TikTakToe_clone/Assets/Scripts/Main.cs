using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Main : NetworkBehaviour
{
    public GameObject Header;
    public GameObject MatchMessage;
    public GameObject MainMenu;
    public GameObject HostButton;
    public GameObject StopHost;
    public GameObject JoinButton;
    public GameObject StopJoin;
    public GameObject StatusMessage;
    public GameObject GameButtons;
    public GameObject RestartButton;
    public GameObject MenuButton;
    public GameObject SPManager_Instance;
    public GameObject Network_Instance;

    public bool SinglePlayer;

    void Start()
    {
        MenuWindow();
        SinglePlayer = false;
    }
    
    
    void Update()
    {
        GameEnded();
    }

    public void MenuWindow()
    {
        GameButtons.SetActive(false);
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);
        Header.SetActive(true);
        MainMenu.SetActive(true);
        HostButton.SetActive(false);
        JoinButton.SetActive(false);
        StatusMessage.SetActive(false);
        StopJoin.SetActive(false);
        StopHost.SetActive(false);

        SPManager_Instance.GetComponent<SPManager>().randomTurn = Random.Range(0, 2);

        if (SPManager_Instance.GetComponent<SPManager>().randomTurn == 0)
            SPManager_Instance.GetComponent<SPManager>().PlayerTurn = true;
        else
            SPManager_Instance.GetComponent<SPManager>().PlayerTurn = false;

        for (int i = 0; i < 9; i++)
        {
            SPManager_Instance.GetComponent<SPManager>().Text[i].text = "";
        }

        SPManager_Instance.GetComponent<SPManager>().pressed1 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed2 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed3 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed4 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed5 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed6 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed7 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed8 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed9 = false;
        SPManager_Instance.GetComponent<SPManager>().End = false;

        SPManager_Instance.GetComponent<SPManager>().Message.GetComponent<Text>().text = "";

        Network_Instance.GetComponent<NetworkManagerHUD>().showGUI = false;

    }

    public void Restart()
    {
        RestartButton.SetActive(false);
        MenuButton.SetActive(true);

        SPManager_Instance.GetComponent<SPManager>().randomTurn = Random.Range(0, 2);

        if (SPManager_Instance.GetComponent<SPManager>().randomTurn == 0)
            SPManager_Instance.GetComponent<SPManager>().PlayerTurn = true;
        else
            SPManager_Instance.GetComponent<SPManager>().PlayerTurn = false;

        for (int i = 0; i < 9; i++)
        {
            SPManager_Instance.GetComponent<SPManager>().Text[i].text = "";
        }

        SPManager_Instance.GetComponent<SPManager>().pressed1 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed2 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed3 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed4 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed5 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed6 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed7 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed8 = false;
        SPManager_Instance.GetComponent<SPManager>().pressed9 = false;
        SPManager_Instance.GetComponent<SPManager>().End = false;

        SPManager_Instance.GetComponent<SPManager>().Message.GetComponent<Text>().text = "";
    }

    public void SinglePlayerWindow()
    {
        Header.SetActive(false);
        MainMenu.SetActive(false);
        GameButtons.SetActive(true);
        MenuButton.SetActive(true);

        SinglePlayer = true;
    }

    public void MultiPlayerWindow()
    {
        Header.SetActive(false);
        MenuButton.SetActive(true);
        MainMenu.SetActive(false);

        SinglePlayer = false;

        Network_Instance.GetComponent<NetworkManagerHUD>().showGUI = true;
    }

    public void Host()
    {
        HostButton.SetActive(false);
        JoinButton.SetActive(false);
        MenuButton.SetActive(false);
    }

    public void StopHosting()
    {
        StopHost.SetActive(false);
        StatusMessage.SetActive(false);
        MultiPlayerWindow();

        /*Network_Instance.GetComponent<NetworkManagerScript>().OnClientDisconnect(connectionToServer);
        Network_Instance.GetComponent<NetworkManagerScript>().OnStopClient();
        Network_Instance.GetComponent<NetworkManagerScript>().OnStopServer();*/
    }

    public void Join()
    {
        HostButton.SetActive(false);
        JoinButton.SetActive(false);
        StatusMessage.SetActive(true);
        MenuButton.SetActive(false);
        StopJoin.SetActive(true);

        Network_Instance.GetComponent<NetworkManagerScript>().OnStartClient();
        Network_Instance.GetComponent<NetworkManagerScript>().OnClientConnect(connectionToServer);
        Network_Instance.GetComponent<NetworkManagerScript>().OnServerReady(connectionToClient);
    }

    public void StopJoining()
    {
        StopJoin.SetActive(false);
        StatusMessage.SetActive(false);
        MultiPlayerWindow();

        Network_Instance.GetComponent<NetworkManagerScript>().OnClientDisconnect(connectionToServer);
        Network_Instance.GetComponent<NetworkManagerScript>().OnStopClient();
    }

    void GameEnded()
    {
        if (SPManager_Instance.GetComponent<SPManager>().End)
        {
            RestartButton.SetActive(true);
            MenuButton.SetActive(true);
        }
    }
}
