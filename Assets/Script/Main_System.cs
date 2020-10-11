using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_System : MonoBehaviour
{

    public static float Solar_dist;
    public static float MassDriver_dist;
    public static float MPD_dist;
    public static float NEMP_dist;
    public static float Bussard_dist;
    public static float Warp_dist;

    public static int current_index = 0;
    public static int target_index;
    public static float energy;
    public static float food;

    public static int now_playing;
    public static string now_quizing;
    public static string quiz_answer;

    public static string player_name;

    public static string destination;
    
    public static string Engine_type;
    public static bool Engine_show = true;
    public static bool menu_show = false;

    public static bool Engine_solar = false;
    public static bool Engine_massdrive = false;
    public static bool Engine_MPD = false;
    public static bool Engine_NEMP = false;
    public static bool Engine_bussard = false;

    public static bool arrived_Mars = false;
    public static bool arrived_Jupiter = false;
    public static bool arrived_Saturn = false;
    public static bool arrived_Urans = false;
    public static bool arrived_Neptune = false;
    public static bool arrived_alpha = false;

    public static bool solar_01 = true;
    public static bool solar_02 = true;
    public static bool solar_03 = true;
    public static bool solar_04 = true;
    public static bool solar_05 = true;

    public static bool massdriver_01 = true;
    public static bool massdriver_02 = true;
   

    public static bool MPD_01 = true;
    public static bool MPD_02 = true;
    public static bool MPD_03 = true;
    public static bool MPD_04 = true;
    public static bool MPD_05 = true;

    public static bool NEMP_01 = true;
    public static bool NEMP_02 = true;
    public static bool NEMP_03 = true;
    public static bool NEMP_04 = true;
    public static bool NEMP_05 = true;

    public static bool Bussard_01 = true;
    public static bool Bussard_02 = true;
    public static bool Bussard_03 = true;
    public static bool Bussard_04 = true;

    public static bool Warp_01 = true;
    public static bool Warp_02 = true;
    public static bool Warp_03 = true;
    public static bool Warp_04 = true;
    public static bool Warp_05 = true;

    public static Vector3 planet_mars;
    public static Vector3 planet_jupiter;
    public static Vector3 planet_saturn;
    public static Vector3 planet_urans;
    public static Vector3 planet_neptune;

    

    public GameObject button_solar;
    public GameObject button_massdrive;
    public GameObject button_MPD;
    public GameObject button_NEMP;
    public GameObject button_bussard;

    public Button button_Mars;
    public Button button_Jupiter;
    public Button button_Saturn;
    public Button button_Urans;
    public Button button_Neptune;

    // Start is called before the first frame update
    void Start()
    {

        
        //Warp_dist = Vector3.Distance(planet06.position, planet08.position);

        Engine_show = false;
 

    }

    // Update is called once per frame
    void Update()
    {

        Solar_dist = Vector3.Distance(planet_mars, planet_saturn);
        MassDriver_dist = Vector3.Distance(planet_jupiter, planet_urans);
        MPD_dist = Vector3.Distance(planet_saturn, planet_neptune);
        NEMP_dist = Vector3.Distance(planet_urans, planet_mars);
        Bussard_dist = Vector3.Distance(planet_neptune, planet_mars);
            
        if (button_Mars)
        {
            refresh();

            var colors = button_Mars.GetComponent<Button>().colors;

            switch (target_index)
            {
                case 1:
                    destination = "Mars";
                    colors = button_Mars.GetComponent<Button>().colors;
                    colors.normalColor = Color.yellow;
                    button_Mars.GetComponent<Button>().colors = colors;
                    break;

                case 2:
                    destination = "Jupiter";
                    colors = button_Jupiter.GetComponent<Button>().colors;
                    colors.normalColor = Color.yellow;
                    button_Jupiter.GetComponent<Button>().colors = colors;
                    break;

                case 3:
                    destination = "Saturn";
                    colors = button_Saturn.GetComponent<Button>().colors;
                    colors.normalColor = Color.yellow;
                    button_Saturn.GetComponent<Button>().colors = colors;
                    break;

                case 4:
                    destination = "Uranus";
                    colors = button_Urans.GetComponent<Button>().colors;
                    colors.normalColor = Color.yellow;
                    button_Urans.GetComponent<Button>().colors = colors;
                    break;

                case 5:
                    destination = "Neptune";
                    colors = button_Neptune.GetComponent<Button>().colors;
                    colors.normalColor = Color.yellow;
                    button_Neptune.GetComponent<Button>().colors = colors;
                    break;

                case 6:
                    destination = "Mars";
                    break;

                case 7:
                    destination = "Mars";
                    break;

                case 8:
                    destination = "Mars";
                    break;


                case 99:
                    destination = "HOLE";
                    Engine_type = "Bussard";
                    break;
            }
        }


        if (Engine_solar) button_solar.SetActive(true);
        if (Engine_massdrive) button_massdrive.SetActive(true);
        if (Engine_MPD) button_MPD.SetActive(true);
        if (Engine_NEMP) button_NEMP.SetActive(true);
        if (Engine_bussard) button_bussard.SetActive(true);

        
    }

    void refresh()
    {
        var colors = button_Mars.GetComponent<Button>().colors;
        colors.normalColor = Color.white;
        button_Mars.GetComponent<Button>().colors = colors;

        colors = button_Jupiter.GetComponent<Button>().colors;
        colors.normalColor = Color.white;
        button_Jupiter.GetComponent<Button>().colors = colors;

        colors = button_Saturn.GetComponent<Button>().colors;
        colors.normalColor = Color.white;
        button_Saturn.GetComponent<Button>().colors = colors;

        colors = button_Urans.GetComponent<Button>().colors;
        colors.normalColor = Color.white;
        button_Urans.GetComponent<Button>().colors = colors;


        colors = button_Neptune.GetComponent<Button>().colors;
        colors.normalColor = Color.white;
        button_Neptune.GetComponent<Button>().colors = colors;


    }
}
