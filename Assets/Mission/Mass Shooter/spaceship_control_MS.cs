using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class spaceship_control_MS : MonoBehaviour
{

    public GameObject Text;
    public GameObject Boom;

    public Transform spaceship;
    public CharacterController controller;
    public Transform Planet_A;
    public Transform Planet_B;
    public Slider Angle;
    public Slider Energy;

    public float K = 1f;
    public const float pi = 3.1415926f;

    Vector3 speed = new Vector3(0,0,0);
    
    Vector3 OA;
    Vector3 OB;

    private bool is_trigger = false;
    private float angle_value;
    private float energy_value;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Space2");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Debug.Log("Space");
            Text.SetActive(false);
            is_trigger = true;
            angle_value = Angle.value;
            energy_value = Energy.value;


            speed.x = Mathf.Cos(angle_value/360*2*pi) * energy_value * -1;
            speed.y = Mathf.Sin(angle_value/360*2*pi) * energy_value ;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (is_trigger)
        {
            OA = Planet_A.position - spaceship.position;
            OB = Planet_B.position - spaceship.position;

            float dist_A = Vector3.Distance(Planet_A.position, spaceship.position);
            float dist_B = Vector3.Distance(Planet_B.position, spaceship.position);

            Vector3 N_OA = new Vector3 (OA.x / dist_A, OA.y / dist_A, OA.z / dist_A);
            Vector3 N_OB = new Vector3 (OB.x / dist_B, OB.y / dist_B, OB.z / dist_B);

            Vector3 A_OA = new Vector3 (
                (K * N_OA.x) / (dist_A * dist_A * dist_A),
                (K * N_OA.y) / (dist_A * dist_A * dist_A),
                (K * N_OA.z) / (dist_A * dist_A * dist_A)
            );

            Vector3 A_OB = new Vector3(
                (K * N_OB.x) / (dist_B * dist_B * dist_B),
                (K * N_OB.y) / (dist_B * dist_B * dist_B),
                (K * N_OB.z) / (dist_B * dist_B * dist_B)
            );

            Vector3 move = speed * Time.deltaTime;// + A_OA * Time.deltaTime * Time.deltaTime / 2 + A_OB * Time.deltaTime * Time.deltaTime / 2;
            speed += A_OA * Time.deltaTime + A_OB * Time.deltaTime;
            Debug.Log(move);
            Boom.transform.Rotate(0,0, move.y);
            
        
            controller.Move(move);
            
        }

        

    }


}
