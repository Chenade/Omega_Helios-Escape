using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Static_Planet_06 : MonoBehaviour
{

    public GameObject Warp_01_GO;
    public GameObject Warp_02_GO;
    public GameObject Warp_03_GO;
    public GameObject Warp_04_GO;
    public GameObject Warp_05_GO;
    public GameObject panel_end;

    public Slider slider;
    public GameObject panel_first;
    public GameObject panel_mission;
    public GameObject panel_mission_end;

    public static int current_part = 0;
    public static int count = 0;

    public Button massdriver;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        massdriver.interactable = false;

        count = 0;
        if (!Main_System.Warp_01) Destroy(Warp_01_GO);
        if (!Main_System.Warp_02) Destroy(Warp_02_GO);
        if (!Main_System.Warp_03) Destroy(Warp_03_GO);
        if (!Main_System.Warp_04) Destroy(Warp_04_GO);
        if (!Main_System.Warp_05) Destroy(Warp_05_GO);

        if (open_dialogue.Warp)
        {
            panel_first.SetActive(false);
            panel_mission.SetActive(true);
        }


        slider.value = count;

        if(count == 100)
        {
            
            panel_end.SetActive(true);
        }
    }

}
