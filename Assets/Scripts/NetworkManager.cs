using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{

    //  instance
    public static NetworkManager instace;

    private void Awake()
    {
        instace = this;
        DontDestroyOnLoad(gameObject);

    }

    private void Start()
    {
        //  connect to the master server
        PhotonNetwork.ConnectUsingSettings();

    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Server");
    }
}
