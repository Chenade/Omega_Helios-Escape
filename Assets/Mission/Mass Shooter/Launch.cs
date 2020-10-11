using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public GameObject end_point;
    public GameObject text;
    public CharacterController spaceship;

    private bool launch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            launch = true;
        }

        if (launch)
        {
            text.SetActive(false);
            float speed = 2f;
            transform.position = Vector3.MoveTowards(transform.position, end_point.transform.position, speed);
        }
    }
}
