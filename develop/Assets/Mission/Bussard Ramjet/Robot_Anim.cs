using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_Anim : MonoBehaviour
{

	Animator anim;


	// Use this for initialization
	void Awake()
	{
		anim = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		CheckKey();
		//gameObject.transform.eulerAngles = rot;
	}

	void CheckKey()
	{
		// Walk Left
		if (Input.GetKey(KeyCode.A))
		{
			anim.SetBool("Walk_Anim", true);
			//UnityEngine.Debug.Log("A");

		}
		else if (Input.GetKeyUp(KeyCode.A))
		{
			anim.SetBool("Walk_Anim", false);
		}

		//Walk Right
		if (Input.GetKey(KeyCode.D))
		{
			anim.SetBool("Walk_Anim", true);
		}
		else if (Input.GetKeyUp(KeyCode.D))
		{
			anim.SetBool("Walk_Anim", false);
		}

		//Jump
		if (Input.GetKey(KeyCode.W))
		{
			anim.SetBool("Roll_Anim", true);
		}
		else if (Input.GetKeyUp(KeyCode.W))
		{
			anim.SetBool("Roll_Anim", false);
		}
	}

}
