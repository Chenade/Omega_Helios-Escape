using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_End : MonoBehaviour
{
    public string status;
    void OnTriggerEnter(Collider other)
    {
        if(status == "finish")
        {
            if(Timing_System.time < 30)
            {
                Main_System.solar_01 = false;
            }
        }
        Static_Planet_01.current_part = 99;
    }
}
