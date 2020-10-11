using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initalize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Main_System.Engine_type = "Basic";
        Main_System.target_index = 1;
        Main_System.current_index = 0;


        Main_System.energy = 100f;
        Main_System.food = 100f;
   
        Main_System.Engine_solar = false;
        Main_System.Engine_massdrive = false;
        Main_System.Engine_MPD = false;
        Main_System.Engine_NEMP = false;
        Main_System.Engine_bussard = false;

        Main_System.arrived_Mars = false;
        Main_System.arrived_Jupiter = false;
        Main_System.arrived_Saturn = false;
        Main_System.arrived_Urans = false;
        Main_System.arrived_Neptune = false;
        Main_System.arrived_alpha = false;

        Main_System.solar_01 = true;
        Main_System.solar_02 = true;
        Main_System.solar_03 = true;
        Main_System.solar_04 = true;
        Main_System.solar_05 = true;

        Main_System.massdriver_01 = true;
        Main_System.massdriver_02 = true;


        Main_System.MPD_01 = true;
        Main_System.MPD_02 = true;
        Main_System.MPD_03 = true;
        Main_System.MPD_04 = true;
        Main_System.MPD_05 = true;

        Main_System.NEMP_01 = true;
        Main_System.NEMP_02 = true;
        Main_System.NEMP_03 = true;
        Main_System.NEMP_04 = true;
        Main_System.NEMP_05 = true;

        Main_System.Bussard_01 = true;
        Main_System.Bussard_02 = true;
        Main_System.Bussard_03 = true;
        Main_System.Bussard_04 = true;

        Main_System.Warp_01 = true;
        Main_System.Warp_02 = true;
        Main_System.Warp_03 = true;
        Main_System.Warp_04 = true;
        Main_System.Warp_05 = true;
    }
}
