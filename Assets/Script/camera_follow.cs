using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class camera_follow : MonoBehaviour
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
        transform.position = player.position +  offset;
        
        
    }
}
