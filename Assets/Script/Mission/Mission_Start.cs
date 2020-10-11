using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mission_Start : MonoBehaviour
{
    public string planet;
    public int index;

    void OnTriggerEnter(Collider other)
    {
       
        if(true)
        {

            switch (planet)
            {
                case "solar":
                    Main_System.now_quizing = "Solar";
                    switch (index)
                    {
                        case 1:
                            Main_System.solar_01 = false;
                            Destroy(gameObject);
                            break;
                        case 3:
                            Main_System.solar_03 = false;
                            Destroy(gameObject);
                            break;
                        case 5:
                            Main_System.solar_05 = false;
                            SceneManager.LoadScene(27);
                            break;
                        case 2:
                            Main_System.solar_02 = false;
                            Main_System.now_playing = 14;
                            SceneManager.LoadScene(26);
                            break;
                        case 4:
                            Main_System.now_playing = 15;
                            SceneManager.LoadScene(26);
                            break;

                    }
                    break;
                case "MassDriver":
                    Main_System.now_quizing = "MassDriver";
                    switch (index)
                    {
                        case 1:
                            Main_System.massdriver_01 = false;
                            Main_System.now_playing = 23;
                            SceneManager.LoadScene(26);
                        
                            break;
                        case 2:
                            Main_System.massdriver_02 = false;
                            Main_System.now_playing = 24;
                            SceneManager.LoadScene(27);
                            break;

                    }
                    break;

                case "MPD":
                    Main_System.now_quizing = "MPD";
                    switch (index)
                    {
                        case 1:
                            Main_System.MPD_01 = false;
                            Destroy(gameObject);
                            break;
                        case 3:
                            Main_System.MPD_03 = false;
                            Destroy(gameObject);
                            break;
                        case 5:
                            Main_System.MPD_05 = false;
                            SceneManager.LoadScene(27);
                            break;
                        case 2:
                            Main_System.now_playing = 16;
                            SceneManager.LoadScene(26);
                            break;
                        case 4:
                            Main_System.now_playing = 17;
                            Main_System.MPD_04 = false;
                            SceneManager.LoadScene(26);
                            break;

                    }
                    break;

                case "NEMP":
                    Main_System.now_quizing = "NEMP";
                    switch (index)
                    {
                        case 1:
                            Main_System.NEMP_01 = false;
                            Destroy(gameObject);
                            break;
                        case 3:
                            Main_System.NEMP_03 = false;
                            Destroy(gameObject);
                            break;
                        case 5:
                            Main_System.NEMP_05 = false;
                            SceneManager.LoadScene(27);
                            break;
                        case 2:
                            Main_System.now_playing = 22;
                            Main_System.NEMP_02 = false;
                            SceneManager.LoadScene(26);
                            break;
                        case 4:
                            Main_System.now_playing = 21;
                            SceneManager.LoadScene(26);
                            break;

                    }
                    break;

                case "Bussard":
                    Main_System.now_quizing = "Bussard";
                    switch (index)
                    {
                        case 1:
                            Main_System.Bussard_01 = false;
                            Destroy(gameObject);
                            break;
                        case 3:
                            Main_System.Bussard_03 = false;
                            SceneManager.LoadScene(27);
                            break;
                        case 2:
                            Main_System.now_playing = 18;
                            SceneManager.LoadScene(26);
                            break;
                        case 4:
                            Main_System.Bussard_04 = false;
                            Main_System.now_playing = 20;
                            SceneManager.LoadScene(26);
                            break;

                    }
                    break;
                    
                case "Warp":
                    Main_System.now_quizing = "Warp";
                    switch (index)
                    {
                        case 1:
                            Main_System.Warp_01 = false;
                            Destroy(gameObject);
                            break;
                        case 3:
                            Main_System.Warp_03 = false;
                            SceneManager.LoadScene(27);
                            break;

                        case 5:
                            Main_System.Warp_05 = false;
                            Destroy(gameObject);
                            break;

                        case 2:
                            Main_System.now_playing = 24;
                            SceneManager.LoadScene(26);
                             break;
                        case 4:
                            Main_System.now_playing = 25;
                            SceneManager.LoadScene(26);
                            break;

                    }
                    break;

            }
        
        }
    }
}
