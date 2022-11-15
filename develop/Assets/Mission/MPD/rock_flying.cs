using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock_flying : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 2000f;

    void Update()
    {
        rb.velocity = new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
