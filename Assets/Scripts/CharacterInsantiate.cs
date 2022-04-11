using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class CharacterInsantiate : MonoBehaviourPunCallbacks
{

    public void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void left()
    {
        PhotonNetwork.Instantiate("Boximon Fiery", transform.position, Quaternion.Euler(0,90,0), 0, null);
    }
   

}

