using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NetworkManagerScript : NetworkManager
{
    public GameObject Main_Instance;

    public override void OnStartServer()
    {
        Debug.Log("Server has started.");
        Main_Instance.GetComponent<Main>().MenuButton.SetActive(false);
    }

    public override void OnStopServer()
    {
        Debug.Log("Server has stopped");
        Main_Instance.SetActive(true);
        Main_Instance.GetComponent<Main>().MultiPlayerWindow();
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Client has connected");
        Main_Instance.GetComponent<Main>().MenuButton.SetActive(false);
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        Debug.Log("Client has disconnected");
    }
}
