using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class CharacterInsantiate : MonoBehaviourPunCallbacks
{
    private PhotonView PV;
    public GameObject Player;
    public GameObject leftSpawn, rightSpawn;
    public void Start()
    {
        PV = Player.GetComponent<PhotonView>();
    }
    void Update()
    {
        
    }
    public void leftE()
    {
        
        PhotonNetwork.Instantiate("Boximon Fiery", leftSpawn.transform.position, Quaternion.Euler(0,90,0), 0, null);
    }
    public void rightE()
    {
        PhotonNetwork.Instantiate("Boximon Fiery", rightSpawn.transform.position, Quaternion.Euler(0, 180, 0), 0, null);
    }

}

