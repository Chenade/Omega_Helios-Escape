using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine;
using System.Collections;

public class Camera_Follow_z : MonoBehaviour
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
        transform.position = new Vector3(offset.x, offset.y, player.position.z);


    }
}
