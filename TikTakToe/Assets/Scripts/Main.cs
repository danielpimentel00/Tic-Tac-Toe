using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject SingleplayerButton;
    public GameObject MultiplayerButton;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
    public GameObject Button6;
    public GameObject Button7;
    public GameObject Button8;
    public GameObject Button9;
    public GameObject Header;
    public GameObject RestartButton;
    public GameObject MenuButton;
    public GameObject HostButton;
    public GameObject BrowseButton;
    public GameObject inputField;
    public GameObject inputButton;
    public GameObject SPManager_Instance;
    public GameObject StatusMessage;

    public GameObject Server;

    void Start()
    {
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
        Button4.SetActive(false);
        Button5.SetActive(false);
        Button6.SetActive(false);
        Button7.SetActive(false);
        Button8.SetActive(false);
        Button9.SetActive(false);
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);
        HostButton.SetActive(false);
        BrowseButton.SetActive(false);
        inputButton.SetActive(false);
        inputField.SetActive(false);
        StatusMessage.SetActive(false);

        Server = GameObject.Find("MPManager");
    }
    

    void Update()
    {
        SingleplayerButton.GetComponent<Button>().onClick.AddListener(SinglePlayerWindow);
        MultiplayerButton.GetComponent<Button>().onClick.AddListener(MultiPlayerWindow);
        GameEnded();

        if (Server.GetComponent<Servidor>().connected)
        {
            Button1.SetActive(true);
            Button2.SetActive(true);
            Button3.SetActive(true);
            Button4.SetActive(true);
            Button5.SetActive(true);
            Button6.SetActive(true);
            Button7.SetActive(true);
            Button8.SetActive(true);
            Button9.SetActive(true);
        }
    }

    void MenuWindow()
    {
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
        Button4.SetActive(false);
        Button5.SetActive(false);
        Button6.SetActive(false);
        Button7.SetActive(false);
        Button8.SetActive(false);
        Button9.SetActive(false);
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);
        Header.SetActive(true);
        SingleplayerButton.SetActive(true);
        MultiplayerButton.SetActive(true);
        HostButton.SetActive(false);
        BrowseButton.SetActive(false);
        inputButton.SetActive(false);
        inputField.SetActive(false);
        StatusMessage.SetActive(false);

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

    void SinglePlayerWindow()
    {
        Header.SetActive(false);
        SingleplayerButton.SetActive(false);
        MultiplayerButton.SetActive(false);
        Button1.SetActive(true);
        Button2.SetActive(true);
        Button3.SetActive(true);
        Button4.SetActive(true);
        Button5.SetActive(true);
        Button6.SetActive(true);
        Button7.SetActive(true);
        Button8.SetActive(true);
        Button9.SetActive(true);
    }

    void MultiPlayerWindow()
    {
        SingleplayerButton.SetActive(false);
        MultiplayerButton.SetActive(false);
        HostButton.SetActive(true);
        BrowseButton.SetActive(true);

        HostButton.GetComponent<Button>().onClick.AddListener(HostGame);
        BrowseButton.GetComponent<Button>().onClick.AddListener(BrowseGame);

        MenuButton.SetActive(true);
        MenuButton.GetComponent<Button>().onClick.AddListener(MenuWindow);

    }

    void HostGame()
    {
        HostButton.SetActive(false);
        BrowseButton.SetActive(false);
        StatusMessage.SetActive(true);
        Server.GetComponent<Servidor>().host = true;
        Server.GetComponent<Servidor>().guest = false;
        MenuButton.SetActive(true);
        Header.SetActive(false);
        Server.GetComponent<Servidor>().Connect();
    }

    void BrowseGame()
    {
        HostButton.SetActive(false);
        BrowseButton.SetActive(false);
        inputButton.SetActive(true);
        inputField.SetActive(true);
        MenuButton.SetActive(true);
        MenuButton.GetComponent<Button>().onClick.AddListener(MenuWindow);
        inputButton.GetComponent<Button>().onClick.AddListener(OnClickEnter);
    }
    
    void OnClickEnter()
    {
        inputButton.SetActive(false);
        inputField.SetActive(false);
        Header.SetActive(false);

        Server.GetComponent<Servidor>().host = false;
        Server.GetComponent<Servidor>().guest = true;
        Debug.Log(Server.GetComponent<Servidor>().address);
    }

    void RestartSP()
    {
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);

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

    void GameEnded()
    {
        if (SPManager_Instance.GetComponent<SPManager>().End)
        {
            RestartButton.SetActive(true);
            MenuButton.SetActive(true);
            RestartButton.GetComponent<Button>().onClick.AddListener(RestartSP);
            MenuButton.GetComponent<Button>().onClick.AddListener(MenuWindow);
        }
    }
}
