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
    public GameObject GameButtons;
    public GameObject RestartButton;
    public GameObject MenuButton;
    public GameObject Easy;
    public GameObject Normal;
    public GameObject Hard;
    public GameObject SPManager_Instance;
    public GameObject MPManager_Instance;
    public GameObject Network_Instance;

    public bool SinglePlayer = false;

    void Start()
    {
        MenuWindow();
    }
    
    
    void Update()
    {
        SPGameEnded();
    }

    public void MenuWindow()
    {
        GameButtons.SetActive(false);
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);
        Easy.SetActive(false);
        Normal.SetActive(false);
        Hard.SetActive(false);
        Header.SetActive(true);
        MainMenu.SetActive(true);

        // ---------CAMBIOS AL SINGLE PLAYER-----------

        SPManager_Instance.GetComponent<SPManager>().randomTurn = Random.Range(0, 2);

        if (SPManager_Instance.GetComponent<SPManager>().randomTurn == 0)
            SPManager_Instance.GetComponent<SPManager>().PlayerTurn = true;
        else
            SPManager_Instance.GetComponent<SPManager>().PlayerTurn = false;

        for (int i = 0; i < 9; i++)
        {
            SPManager_Instance.GetComponent<SPManager>().SPTexts[i].text = "";
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

        // ---------CAMBIOS AL MULTIPLAYER--------

        for (int i = 0; i < 9; i++)
        {
            MPManager_Instance.GetComponent<MPManager>().MPTexts[i].text = "";
        }

        MPManager_Instance.GetComponent<MPManager>().pressed1 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed2 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed3 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed4 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed5 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed6 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed7 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed8 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed9 = false;
        MPManager_Instance.GetComponent<MPManager>().End = false;

        MPManager_Instance.GetComponent<MPManager>().Message.GetComponent<Text>().text = "";

        Network_Instance.GetComponent<NetworkManagerHUD>().showGUI = false;

    }

    public void Restart()
    {
        RestartButton.SetActive(false);
        MenuButton.SetActive(true);

        // ---------CAMBIOS AL SINGLE PLAYER-----------

        SPManager_Instance.GetComponent<SPManager>().randomTurn = Random.Range(0, 2);

        if (SPManager_Instance.GetComponent<SPManager>().randomTurn == 0)
            SPManager_Instance.GetComponent<SPManager>().PlayerTurn = true;
        else
            SPManager_Instance.GetComponent<SPManager>().PlayerTurn = false;

        for (int i = 0; i < 9; i++)
        {
            SPManager_Instance.GetComponent<SPManager>().SPTexts[i].text = "";
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

        // ---------CAMBIOS AL MULTIPLAYER--------

        for (int i = 0; i < 9; i++)
        {
            MPManager_Instance.GetComponent<MPManager>().MPTexts[i].text = "";
        }

        MPManager_Instance.GetComponent<MPManager>().pressed1 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed2 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed3 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed4 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed5 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed6 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed7 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed8 = false;
        MPManager_Instance.GetComponent<MPManager>().pressed9 = false;
        MPManager_Instance.GetComponent<MPManager>().End = false;

        MPManager_Instance.GetComponent<MPManager>().Message.GetComponent<Text>().text = "";
    }

    public void SinglePlayerWindow()
    {
        Header.SetActive(false);
        MainMenu.SetActive(false);
        MenuButton.SetActive(true);
        Easy.SetActive(true);
        Normal.SetActive(true);
        Hard.SetActive(true);

        SinglePlayer = true;
    }

    public void EasyMode()
    {
        Easy.SetActive(false);
        Normal.SetActive(false);
        Hard.SetActive(false);
        GameButtons.SetActive(true);

        SPManager_Instance.GetComponent<SPManager>().EasyMode = true;
        SPManager_Instance.GetComponent<SPManager>().NormalMode = false;
        SPManager_Instance.GetComponent<SPManager>().HardMode = false;
    }

    public void NormalMode()
    {
        Easy.SetActive(false);
        Normal.SetActive(false);
        Hard.SetActive(false);
        GameButtons.SetActive(true);

        SPManager_Instance.GetComponent<SPManager>().EasyMode = false;
        SPManager_Instance.GetComponent<SPManager>().NormalMode = true;
        SPManager_Instance.GetComponent<SPManager>().HardMode = false;
    }

    public void HardMode()
    {
        Easy.SetActive(false);
        Normal.SetActive(false);
        Hard.SetActive(false);
        GameButtons.SetActive(true);

        SPManager_Instance.GetComponent<SPManager>().EasyMode = false;
        SPManager_Instance.GetComponent<SPManager>().NormalMode = false;
        SPManager_Instance.GetComponent<SPManager>().HardMode = true;
    }

    void SPGameEnded()
    {
        if (SPManager_Instance.GetComponent<SPManager>().End)
        {
            RestartButton.SetActive(true);
            MenuButton.SetActive(true);
        }
    }

    public void MultiPlayerWindow()
    {
        Header.SetActive(false);
        MenuButton.SetActive(true);
        MainMenu.SetActive(false);

        SinglePlayer = false;

        Network_Instance.GetComponent<NetworkManagerHUD>().showGUI = true;
    }
}
