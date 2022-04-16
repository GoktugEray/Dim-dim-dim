using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per framex
    void Update()
    {
         transform.Translate(Vector3.forward * 6 * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("turnR"))
        {
            transform.Rotate(0, 90f, 0);
        }
        if (other.CompareTag("turnL"))
        {
            transform.Rotate(0, -90f, 0);
        }
        if (other.CompareTag("bridgeup"))
        {
            transform.Translate(Vector3.up * 1.5f * Time.deltaTime);
        }
        if (other.CompareTag("Bondorus"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 90);
        }
    }
}
