using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Static_Planet_03 : MonoBehaviour
{

    public GameObject MPD_01_GO;
    public GameObject MPD_02_GO;
    public GameObject MPD_03_GO;
    public GameObject MPD_04_GO;
    public GameObject MPD_05_GO;

    public Slider slider;
    public GameObject panel_first;
    public GameObject panel_mission;
    public GameObject panel_mission_end;

    public TextMeshProUGUI dist_mars;
    public TextMeshProUGUI dist_jupiter;
    public TextMeshProUGUI dist_saturn;
    public TextMeshProUGUI dist_urans;
    public TextMeshProUGUI dist_neptune;

    public GameObject panel_end;
    public GameObject MPD_engine;

    public Button massdriver;
   
    public static int current_part = 0;
    public static int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        dist_mars.text = Vector3.Distance(Main_System.planet_saturn, Main_System.planet_mars).ToString("#0");
        dist_jupiter.text = Vector3.Distance(Main_System.planet_saturn, Main_System.planet_jupiter).ToString("#0");
        dist_saturn.text = Vector3.Distance(Main_System.planet_saturn, Main_System.planet_saturn).ToString("#0");
        dist_urans.text = Vector3.Distance(Main_System.planet_saturn, Main_System.planet_urans).ToString("#0");
        dist_neptune.text = Vector3.Distance(Main_System.planet_saturn, Main_System.planet_neptune).ToString("#0");

    }

    // Update is called once per frame
    void Update()
    {
        massdriver.interactable = false;

        count = 0;
        if (!Main_System.MPD_01) { Destroy(MPD_01_GO); count += 20; }
        if (!Main_System.MPD_02) { Destroy(MPD_02_GO); count += 20; }
        if (!Main_System.MPD_03) { Destroy(MPD_03_GO); count += 20; }
        if (!Main_System.MPD_04) { Destroy(MPD_04_GO); count += 20; }
        if (!Main_System.MPD_05) { Destroy(MPD_05_GO); count += 20; }

        if (open_dialogue.MPD)
        {
            panel_first.SetActive(false);
            panel_mission.SetActive(true);
        }

        slider.value = count;

        if (count == 100)
        {
            Main_System.Engine_MPD = true;
            panel_mission.SetActive(false);
            panel_mission_end.SetActive(true);
        }
    }

}
