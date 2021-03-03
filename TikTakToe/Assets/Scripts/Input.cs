using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Input : MonoBehaviour
{
    public GameObject inputF;

    public void StoreAddress()
    {
        GameObject.Find("MPManager").GetComponent<Servidor>().address = inputF.GetComponent<Text>().text;
    }

}
