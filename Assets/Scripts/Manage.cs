using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class Manage : MonoBehaviourPunCallbacks
{

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("Server'a girildi.");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        print("Lobby'e girildi.");
        PhotonNetwork.JoinOrCreateRoom("oda", new RoomOptions { MaxPlayers = 2, IsOpen = true, IsVisible = true }, TypedLobby.Default);
        //PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
        print("Room'a girildi.");
       
    }

    public override void OnLeftLobby()
    {
        print("Lobby'den ayrýlýndý.");
    }

    public override void OnLeftRoom()
    {
        print("Room'dan ayrýlýndý.");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        print("Hata: Room'a girilemedi.");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        print("Hata: Herhangi bir Room'a girilemedi.");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print("Hata: Room kurulamadý.");
    }
}
