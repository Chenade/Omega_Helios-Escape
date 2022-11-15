    using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class spaceshp_control_MPD : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 100f;

    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //UnityEngine.Debug.Log(mousePos);
            //UnityEngine.Debug.Log(transform.position);
            mousePos.x = (mousePos.x - transform.position.x) * -0.01f;
            mousePos.y = (mousePos.y - transform.position.y) * -0.01f;
            mousePos.z = 0;
            UnityEngine.Debug.Log(mousePos);
            controller.Move(mousePos * speed * Time.deltaTime);
        }


        /*Move*/
        controller.Move(mousePos * speed * Time.deltaTime);



    }

    void OnTriggerEnter(Collider other)
    {
        life_store.life -= 1;

    }
}

