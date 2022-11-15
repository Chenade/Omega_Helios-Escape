using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class MouseLook : MonoBehaviour
{

    public Transform playerBody;
    public float mouseSensitvity = 300f;

    public GameObject panel;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!panel.activeSelf)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitvity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitvity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            playerBody.Rotate(Vector3.up * mouseX);
        }
       
    }
}
