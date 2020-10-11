using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Robert_control : MonoBehaviour
{

	public CharacterController controller;
	public float speed = 2f;
	public float gravity = 9.81f;
	public float jumpheight = 0.5f;

	Vector3 velocity;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{



		/*Move*/
		float x = Input.GetAxis("Horizontal");

		Vector3 move = transform.right * x;
		//if (x != 0) move.y = -2f;
		controller.Move(move * speed * Time.deltaTime);


		/*Drop*/
		velocity.y -= gravity * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime);

		/*Jump*/
		if (Input.GetKey(KeyCode.W))  
		{
			velocity.y = Mathf.Sqrt(jumpheight * -2f * -gravity);
		}

	}
}
