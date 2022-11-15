using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using System.Collections;

public class Camera_Follow_x : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);
        transform.position = new Vector3(player.position.x - 40, 0, -20);


    }
}
