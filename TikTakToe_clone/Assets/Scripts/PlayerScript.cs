using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MLAPI;

public class PlayerScript : NetworkedBehaviour
{
    public GameObject MPManager_Instance;

    public bool check;
    public bool pressed1;
    public bool pressed2;
    public bool pressed3;
    public bool pressed4;
    public bool pressed5;
    public bool pressed6;
    public bool pressed7;
    public bool pressed8;
    public bool pressed9;

    void Start()
    {
        pressed1 = false;
        pressed2 = false;
        pressed3 = false;
        pressed4 = false;
        pressed5 = false;
        pressed6 = false;
        pressed7 = false;
        pressed8 = false;
        pressed9 = false;

        MPManager_Instance = GameObject.Find("MultiPlayerMenu");


        if (IsLocalPlayer)
        {
            MPManager_Instance.GetComponent<MPManager>().HostConnected = true;
        }
        else if (!IsLocalPlayer)
        {
            MPManager_Instance.GetComponent<MPManager>().ClientConnected = true;
        }
    }

    void Update()
    {
        
        if(IsLocalPlayer)
               MPManager_Instance.GetComponent<MPManager>().MPButtons[0].GetComponent<Button>().onClick.AddListener(Play1);
        else if(!IsLocalPlayer)
            MPManager_Instance.GetComponent<MPManager>().MPButtons[0].GetComponent<Button>().onClick.AddListener(Play1);

        if (IsHost)
        {
            InvokeClientRpcOnEveryone(MPManager_Instance.GetComponent<MPManager>().PlayGame);
        }else if (IsClient)
        {
            InvokeServerRpc(MPManager_Instance.GetComponent<MPManager>().PlayGame);
        }


        if (pressed1)
            MPManager_Instance.GetComponent<MPManager>().pressed1 = true;
    }

    public void Play1()
    {
        pressed1 = true;
    }


    
}
