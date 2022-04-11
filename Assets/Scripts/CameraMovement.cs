using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float mSensivity = 200f;
    //public Transform benBody;
    float xRotation, yRotation = 0f;
    public CharacterController controller;


    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        yRotation += mouseX;
        yRotation = Mathf.Clamp(-90f, yRotation, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        //benBody.Rotate(Vector3.up * mouseX);

       

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * y;
        controller.Move(move * 16f * Time.deltaTime);
        
        
    }
}