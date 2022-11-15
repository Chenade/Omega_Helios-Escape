using System;
using System.Linq;
using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Mass_generate : MonoBehaviour
{
    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    public GameObject rock4;
   
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
            index = Random.Range(1, 5);
            xPos = Random.Range(-250, 250);
            yPos = Random.Range(1500, 3000);
            zPos = Random.Range(7316, 32000);

            if (index == 1)
            {
                Instantiate(rock1, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }

            if (index == 2)
            {
                Instantiate(rock2, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }
            

            if (index == 3)
            {
                Instantiate(rock3, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }
            


            if (index == 4)
            {
                Instantiate(rock4, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }
            yield return new WaitForSeconds(0.001f);
            count += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
