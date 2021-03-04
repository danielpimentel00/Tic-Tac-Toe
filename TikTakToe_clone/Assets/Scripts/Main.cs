using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject Header;
    public GameObject MatchMessage;
    public GameObject MainMenu;
    public GameObject MultiPlayerMenu;
    public GameObject GameButtons;
    public GameObject RestartButton;
    public GameObject MenuButton;
    public GameObject SPManager_Instance;

    public bool SinglePlayer;

    void Start()
    {
        MatchMessage.SetActive(false);
        MultiPlayerMenu.SetActive(false);
        GameButtons.SetActive(false);
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);

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
        MultiPlayerMenu.SetActive(false);

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

        MainMenu.SetActive(false);
        MultiPlayerMenu.SetActive(true);

        MenuButton.SetActive(true);

        SinglePlayer = false;
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

    void GameEnded()
    {
        if (SPManager_Instance.GetComponent<SPManager>().End)
        {
            RestartButton.SetActive(true);
            MenuButton.SetActive(true);
        }
    }
}
