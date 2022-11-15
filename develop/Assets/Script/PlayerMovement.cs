using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    public float gravity = 9.81f;
    public float jumpheight = 3f;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      

        /*Move*/
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
        
            Vector3 move = transform.right * x + transform.forward * z;
            controller.Move(move * speed * Time.deltaTime);


        /*Drop*/
            velocity.y -= gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);

        /*Jump*/
            if(Input.GetButtonDown("Jump"))  //Space
            {
                //Debug.Log("Jump");
                velocity.y = Mathf.Sqrt(jumpheight * -2f * -gravity);
            }

    }
}
