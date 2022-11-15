using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_arrival : MonoBehaviour
{

    public string index;

    
    private void OnTriggerEnter(Collider other)
    {
       
        switch (index)
        {
            case "Mars":
                if(Main_System.destination == "Mars")  SceneManager.LoadScene(2);
                break;

            case "Jupiter":
                if (Main_System.destination == "Jupiter")  SceneManager.LoadScene(3);
                break;

            case "Saturn":
                if (Main_System.destination == "Saturn")  SceneManager.LoadScene(4);
                break;

            case "Uranus":
                if (Main_System.destination == "Uranus")  SceneManager.LoadScene(5);
                break;

            case "Neptune":
                if (Main_System.destination == "Neptune")  SceneManager.LoadScene(6);
                break;

            case "Alpha Centauri":
                
                SceneManager.LoadScene(7);
                break;
            
            case "Unknown":
                if (Main_System.destination == "Mars")  SceneManager.LoadScene(7);
                break;
        }
        
    }
}
