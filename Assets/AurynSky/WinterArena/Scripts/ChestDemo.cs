using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestDemos : MonoBehaviour
{

    //This script goes on the ChestComplete prefab;

    public Animator chestAnims; //Animator for the chest;

    // Use this for initialization
    void Awake()
    {
        //get the Animator component from the chest;
        chestAnims = GetComponent<Animator>();
        //start opening and closing the chest for demo purposes;
        StartCoroutine(OpenCloseChests());
    }


    IEnumerator OpenCloseChests()
    {
        //play open animation;
        chestAnims.SetTrigger("open");
        //wait 2 seconds;
        yield return new WaitForSeconds(2);
        //play close animation;
        chestAnims.SetTrigger("close");
        //wait 2 seconds;
        yield return new WaitForSeconds(2);
        //Do it again;
        StartCoroutine(OpenCloseChests());

    }
}