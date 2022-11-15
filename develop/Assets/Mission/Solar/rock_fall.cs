using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock_fall : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 200f;

    void Update()
    {
        rb.velocity = new Vector3(0, -speed * Time.deltaTime, 0);
    }
}
