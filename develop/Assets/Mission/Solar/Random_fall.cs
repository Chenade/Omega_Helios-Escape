using System;
using System.Linq;
using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Random_fall : MonoBehaviour
{
    public GameObject Rock1;
    public GameObject Rock2;
    public GameObject Rock3;
    public GameObject Rock4;
    public int xPos;
    public int yPos;
    public float zPos;
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
            index = Random.Range(1, 5);
            xPos = Random.Range(-12, 18);
            yPos = Random.Range(47, 60);
            zPos = 4.5f;

            if (index == 1)
            {
                Instantiate(Rock1, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }

            if (index == 2)
            {
                Instantiate(Rock2, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }

            if (index == 3)
            {
                Instantiate(Rock3, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }

            if (index == 4)
            {
                Instantiate(Rock4, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }


            yield return new WaitForSeconds(1f);
            count += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
