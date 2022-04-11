using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class Right : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void rightE()
    {
        PhotonNetwork.Instantiate("Boximon Fiery", transform.position, Quaternion.Euler(0, 180, 0), 0, null);
    }
}
