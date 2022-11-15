using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class border_trigger : MonoBehaviour
{
    public string type;
    public GameObject panel;
    public GameObject panel_failed;
    void OnTriggerEnter(Collider other)
    {
        if(type == "die")
        {
            SceneManager.LoadScene(23);
        }
        else if (type == "end_bussard")
        {
            SceneManager.LoadScene(18);
        }
        else if(type == "end")
        {
            panel.SetActive(true);
        }
        else if (type == "terminal")
        {
            Main_System.MPD_02 = false;
            panel.SetActive(true);
            //SceneManager.LoadScene(4);
        }
        else if (type == "end_point")
        {
          
            SceneManager.LoadScene(1);
        }
        else if (type == "terminal5")
        {
            if(Timing_System.time < 25)
            {
                Main_System.NEMP_02 = false;
                panel.SetActive(true);
            }
            else
            {
                Timing_System.is_playing = false;
                panel_failed.SetActive(true);
            }
          
        }
        else if (type == "die5")
        {
            Timing_System.is_playing = false;
            panel_failed.SetActive(true);

        }
        else if (type == "alpha")
        {
            Debug.Log("fdghjkuyghjkiouygh");
            //SceneManager.LoadScene(32);
        }
        else
        {
            panel.SetActive(true);
        }   
    }
}
