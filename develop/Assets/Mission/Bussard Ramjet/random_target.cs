using System;
using System.Linq;
using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class random_target : MonoBehaviour
{
    public GameObject h_11;
    public GameObject h_21;
    public GameObject h_31;
    
    public Transform spaceship;
    public int xPos;
    public int yPos;
    public int zPos;
    public int index; //objectToGenerate
    public int count;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateObjects());
    }

    IEnumerator GenerateObjects()
    {
        while (count < 2000)
        {
            index = Random.Range(1, 4);
            xPos = Random.Range(0, 5);
            yPos = Random.Range(2, 5);
            
            zPos = Random.Range(0, 2);

            if (index == 1)
            {
                Instantiate(h_11, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }

            if (index == 2)
            {
                Instantiate(h_21, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }

            if (index == 3)
            {
                Instantiate(h_31, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }
            yield return new WaitForSeconds(2f);
            count += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
