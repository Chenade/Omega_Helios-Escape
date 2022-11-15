using System;
using System.Linq;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Random_rock : MonoBehaviour
{
    public GameObject Rock_01;
    public GameObject Rock_02;
    public GameObject Rock_03;
    public GameObject Rock_04;
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
            index = Random.Range(1, 3);
            yPos = Random.Range(-24, 30);
            xPos = Random.Range(-90, 1900);
            zPos = 278;

            if (index == 1)
            {
                Instantiate(Rock_01, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }
            if (index == 2)
            {
                Instantiate(Rock_02, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }
            if (index == 3)
            {
                Instantiate(Rock_03, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }
            if (index == 4)
            {
                Instantiate(Rock_04, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }
            yield return new WaitForSeconds(0.5f);
            count += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

