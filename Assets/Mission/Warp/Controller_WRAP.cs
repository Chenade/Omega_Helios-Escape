using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_WRAP : MonoBehaviour
{
    public CharacterController puzzle;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*Move*/
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float speed = 2f;

        Vector3 move = transform.right * -x + transform.up * -y;
        puzzle.Move(move * speed * Time.deltaTime);
    }
}
