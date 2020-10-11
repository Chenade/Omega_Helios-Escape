using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Button_Click : MonoBehaviour
{
    public GameObject button_engine;
    public GameObject button_detail;
    public GameObject planet_txt;
    public TextMeshProUGUI distance_txt;
    

    public int new_target;
    public int scene;
    public string engine;
    public string button_value;

    public void game_pause() {
        Main_System.menu_show = true;


    }

    public void change_des()
    {
        Main_System.target_index = new_target;

    }

    public void new_des()
    {
        Main_System.target_index = new_target;
        SceneManager.LoadScene(1);

    }

    public void new_des_MD()
    {
        Main_System.target_index = new_target;
        SceneManager.LoadScene(29);

    }

    public void change_engine()
    {
        Main_System.Engine_type = engine;
        if (engine == "SolarSail") distance_txt.text = Main_System.Solar_dist.ToString("#0");
        if (engine == "MassDriver") distance_txt.text = Main_System.MassDriver_dist.ToString("#0");
        if (engine == "MPD") distance_txt.text = Main_System.MPD_dist.ToString("#0");
        if (engine == "NEMP") distance_txt.text = Main_System.NEMP_dist.ToString("#0");
        if (engine == "Bussard") distance_txt.text = Main_System.Bussard_dist.ToString("#0");
    }

    public void open_engine()
    {
        if (!Main_System.Engine_show)
        {
            button_detail.SetActive(true);
            Main_System.Engine_show = true;
           
        }
        else
        {
            button_detail.SetActive(false);
            Main_System.Engine_show = false;
        }
    }

    public void game_play()
    {
       
        SceneManager.LoadScene(Main_System.now_playing);
    }

    public void Quiz_answer()
    {
        if(button_value == Main_System.quiz_answer)
        {
            if(Game_Quiz.index == Game_Quiz.max_index)
            {
                if (Main_System.now_quizing == "Solar") SceneManager.LoadScene(2);
                if (Main_System.now_quizing == "MassDriver") SceneManager.LoadScene(3);
                if (Main_System.now_quizing == "MPD") SceneManager.LoadScene(4);
                if (Main_System.now_quizing == "NEMP") SceneManager.LoadScene(5);
                if (Main_System.now_quizing == "Bussard") SceneManager.LoadScene(6);
                if (Main_System.now_quizing == "Warp") SceneManager.LoadScene(7);
            }
            else
            {
                Game_Quiz.index += 1;
            }
           
        }
    }

    public void mission_die()
    {
        SceneManager.LoadScene(scene);
    }


    public void breakthrough() 
    {
        Main_System.target_index = 99;
        
        SceneManager.LoadScene(30);
    }


    public void Exit_game()
    {
        SceneManager.LoadScene(0);
    }

    public void NEMP_start()
    {
        Timing_System.is_playing = true;
    }
}
