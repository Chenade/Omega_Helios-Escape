using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class shooting_control : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 2f;

    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {



        /*Move*/
        float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x;
        controller.Move(move * speed * Time.deltaTime);

    }
}
