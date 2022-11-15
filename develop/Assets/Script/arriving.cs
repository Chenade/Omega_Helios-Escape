using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arriving : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    public float gravity = 9.81f;
    public GameObject arrived;
    public GameObject player;

    Vector3 velocity;
    Vector3 arrive_place;

    private void Start()
    {
        
        arrive_place = arrived.transform.position;
        
        switch (Main_System.target_index)
        {
            case 1:
                if (!Main_System.arrived_Mars) Main_System.arrived_Mars = true;
                else
                {
                    transform.position = arrive_place;
                    player.transform.position = arrive_place;
                }
                break;
            case 2:
                if (!Main_System.arrived_Jupiter) Main_System.arrived_Jupiter = true;
                else
                {
                    transform.position = arrive_place;
                    player.transform.position = arrive_place;
                }
                break;
            case 3:
                if (!Main_System.arrived_Saturn) Main_System.arrived_Saturn = true;
                else
                {
                    transform.position = arrive_place;
                    player.transform.position = arrive_place;
                }
                break;
            case 4:
                if (!Main_System.arrived_Urans) Main_System.arrived_Urans = true;
                else
                {
                    transform.position = arrive_place;
                    player.transform.position = arrive_place;
                }
                break;
            case 5:
                if (!Main_System.arrived_Neptune) Main_System.arrived_Neptune = true;
                else
                {
                    transform.position = arrive_place;
                    player.transform.position = arrive_place;
                }
                break;
        }
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        /*Drop*/
        velocity.y -= gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
