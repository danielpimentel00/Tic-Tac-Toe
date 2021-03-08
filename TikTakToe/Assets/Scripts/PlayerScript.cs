using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class PlayerScript : NetworkBehaviour
{
    public GameObject MPManager_Instance;
    public GameObject Main_Instance;
    public GameObject NetworkManager_Instance;

    public bool isHost = false;
    public bool PanelDisplayed = false;

    void Start()
    {
        MPManager_Instance = GameObject.Find("MPManager");
        Main_Instance = GameObject.Find("Canvas");
        NetworkManager_Instance = GameObject.Find("NetworkManager");

        if (isLocalPlayer)
        {
            IncreasePlayerCount();
        }

        if (isLocalPlayer && isServer)
            isHost = true;
    }

    void Update()
    {

        if (isLocalPlayer && !PanelDisplayed) { IWantToPlay(); }

        if (isLocalPlayer)
        {
            MPManager_Instance.GetComponent<MPManager>().MPButtons[0].onClick.AddListener(Play1);
            MPManager_Instance.GetComponent<MPManager>().MPButtons[1].onClick.AddListener(Play2);
            MPManager_Instance.GetComponent<MPManager>().MPButtons[2].onClick.AddListener(Play3);
            MPManager_Instance.GetComponent<MPManager>().MPButtons[3].onClick.AddListener(Play4);
            MPManager_Instance.GetComponent<MPManager>().MPButtons[4].onClick.AddListener(Play5);
            MPManager_Instance.GetComponent<MPManager>().MPButtons[5].onClick.AddListener(Play6);
            MPManager_Instance.GetComponent<MPManager>().MPButtons[6].onClick.AddListener(Play7);
            MPManager_Instance.GetComponent<MPManager>().MPButtons[7].onClick.AddListener(Play8);
            MPManager_Instance.GetComponent<MPManager>().MPButtons[8].onClick.AddListener(Play9);
        }
        
    }

    [Command]
    void IWantToPlay()
    {
        if(MPManager_Instance.GetComponent<MPManager>().PlayerCount == 2)
            DisplayGamePanel();
    }
    
    [TargetRpc]
    void DisplayGamePanel()
    {
        MPManager_Instance.GetComponent<MPManager>().PlayerCount = 2;
        Main_Instance.GetComponent<Main>().GameButtons.SetActive(true);
        NetworkManager_Instance.GetComponent<NetworkManagerHUD>().showGUI = false;
        PanelDisplayed = true;
    }

    [Command]
    void IncreasePlayerCount()
    {
        MPManager_Instance.GetComponent<MPManager>().PlayerCount++;
    }

    [Command]
    void Play1()
    {
        //Validate
        if(isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 0)
        {
            Play1RPCHost();
            MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        }
        else if (!isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 1)
        {
            Play1RPCGuest();
            MPManager_Instance.GetComponent<MPManager>().Turn = 0;
        }
    }

    [ClientRpc]
    void Play1RPCHost()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed1 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        

        Debug.Log("Jugada en la posicion 1");
    }

    [ClientRpc]
    void Play1RPCGuest()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed1 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 0;


        Debug.Log("Jugada en la posicion 1");
    }

    [Command]
    void Play2()
    {
        //Validate
        if (isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 0)
        {
            Play2RPCHost();
            MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        }
        else if (!isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 1)
        {
            Play2RPCGuest();
            MPManager_Instance.GetComponent<MPManager>().Turn = 0;
        }
    }

    [ClientRpc]
    void Play2RPCHost()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed2 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 1;


        Debug.Log("Jugada en la posicion 2");
    }

    [ClientRpc]
    void Play2RPCGuest()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed2 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 0;


        Debug.Log("Jugada en la posicion 2");
    }

    [Command]
    void Play3()
    {
        //Validate
        if (isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 0)
        {
            Play3RPCHost();
            MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        }
        else if (!isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 1)
        {
            Play3RPCGuest();
            MPManager_Instance.GetComponent<MPManager>().Turn = 0;
        }
    }

    [ClientRpc]
    void Play3RPCHost()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed3 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 1;


        Debug.Log("Jugada en la posicion 3");
    }

    [ClientRpc]
    void Play3RPCGuest()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed3 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 0;


        Debug.Log("Jugada en la posicion 3");
    }

    [Command]
    void Play4()
    {
        //Validate
        if (isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 0)
        {
            Play4RPCHost();
            MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        }
        else if (!isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 1)
        {
            Play4RPCGuest();
            MPManager_Instance.GetComponent<MPManager>().Turn = 0;
        }
    }

    [ClientRpc]
    void Play4RPCHost()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed4 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 1;


        Debug.Log("Jugada en la posicion 4");
    }

    [ClientRpc]
    void Play4RPCGuest()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed4 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 0;


        Debug.Log("Jugada en la posicion 4");
    }

    [Command]
    void Play5()
    {
        //Validate
        if (isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 0)
        {
            Play5RPCHost();
            MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        }
        else if (!isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 1)
        {
            Play5RPCGuest();
            MPManager_Instance.GetComponent<MPManager>().Turn = 0;
        }
    }

    [ClientRpc]
    void Play5RPCHost()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed5 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 1;


        Debug.Log("Jugada en la posicion 5");
    }

    [ClientRpc]
    void Play5RPCGuest()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed5 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 0;


        Debug.Log("Jugada en la posicion 5");
    }

    [Command]
    void Play6()
    {
        //Validate
        if (isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 0)
        {
            Play6RPCHost();
            MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        }
        else if (!isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 1)
        {
            Play6RPCGuest();
            MPManager_Instance.GetComponent<MPManager>().Turn = 0;
        }
    }

    [ClientRpc]
    void Play6RPCHost()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed6 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 1;


        Debug.Log("Jugada en la posicion 6");
    }

    [ClientRpc]
    void Play6RPCGuest()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed6 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 0;


        Debug.Log("Jugada en la posicion 6");
    }

    [Command]
    void Play7()
    {
        //Validate
        if (isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 0)
        {
            Play7RPCHost();
            MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        }
        else if (!isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 1)
        {
            Play7RPCGuest();
            MPManager_Instance.GetComponent<MPManager>().Turn = 0;
        }
    }

    [ClientRpc]
    void Play7RPCHost()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed7 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 1;


        Debug.Log("Jugada en la posicion 7");
    }

    [ClientRpc]
    void Play7RPCGuest()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed7 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 0;


        Debug.Log("Jugada en la posicion 7");
    }

    [Command]
    void Play8()
    {
        //Validate
        if (isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 0)
        {
            Play8RPCHost();
            MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        }
        else if (!isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 1)
        {
            Play8RPCGuest();
            MPManager_Instance.GetComponent<MPManager>().Turn = 0;
        }
    }

    [ClientRpc]
    void Play8RPCHost()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed8 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 1;


        Debug.Log("Jugada en la posicion 8");
    }

    [ClientRpc]
    void Play8RPCGuest()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed8 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 0;


        Debug.Log("Jugada en la posicion 8");
    }

    [Command]
    void Play9()
    {
        //Validate
        if (isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 0)
        {
            Play9RPCHost();
            MPManager_Instance.GetComponent<MPManager>().Turn = 1;
        }
        else if (!isHost && MPManager_Instance.GetComponent<MPManager>().Turn == 1)
        {
            Play9RPCGuest();
            MPManager_Instance.GetComponent<MPManager>().Turn = 0;
        }
    }

    [ClientRpc]
    void Play9RPCHost()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed9 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 1;


        Debug.Log("Jugada en la posicion 9");
    }

    [ClientRpc]
    void Play9RPCGuest()
    {
        MPManager_Instance.GetComponent<MPManager>().pressed9 = true;
        MPManager_Instance.GetComponent<MPManager>().PlayGame();

        MPManager_Instance.GetComponent<MPManager>().Turn = 0;


        Debug.Log("Jugada en la posicion 9");
    }
}
