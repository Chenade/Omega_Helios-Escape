using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class open_dialogue : MonoBehaviour
{
    public string dialogue_index;
    public GameObject panel_end;
    public static bool solar = false;
    public static bool massdriver = false;
    public static bool MPD = false;
    public static bool NEMP = false;
    public static bool Bussard = false;
    public static bool Warp = false;

    void OnTriggerEnter(Collider other)
    {
        switch (dialogue_index)
        {
            case "SolarSail":
                if (Static_Planet_01.count < 100)
                {
                    Main_System.arrived_Mars = true;
                    SceneManager.LoadScene(8);
                    solar = true;
                }
                else
                {
                    panel_end.SetActive(true);
                }
               
                break;

            case "MassDriver":
                if(Static_Planet_02.count < 100)
                {
                    Main_System.arrived_Jupiter = true;
                    SceneManager.LoadScene(9);
                    massdriver = true;
                }
                else
                {
                    panel_end.SetActive(true);
                }
                
                break;

            case "MPD":
                if (Static_Planet_03.count < 100)
                {
                    Main_System.arrived_Saturn = true;
                    SceneManager.LoadScene(10);
                    MPD = true;
                }
                else
                {
                    panel_end.SetActive(true);
                }
                
                break;

            case "NEMP":
                if (Static_Planet_04.count < 100)
                {
                    Main_System.arrived_Urans = true;
                    SceneManager.LoadScene(11);
                    NEMP = true;
                }
                else
                {
                    panel_end.SetActive(true);
                }
                
                break;
            
            case "Bussard":
                if (Static_Planet_05.count < 100)
                {
                    Main_System.arrived_Neptune = true;
                    SceneManager.LoadScene(12);
                    Bussard = true;
                }
                else
                {
                    SceneManager.LoadScene(30);
                }

                break;

            case "Warp":
                if (Static_Planet_05.count < 100)
                {
                    Main_System.arrived_alpha = true;
                    SceneManager.LoadScene(13);
                    Warp = true;
                }
                else
                {
                    SceneManager.LoadScene(33);
                }

                break;
        }
        
    }
}
