using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public GameObject Engine;
    private float rotation = 20;
    private float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotate = speed * Time.deltaTime;
        transform.Rotate(0, rotate, 0);
    }
}
