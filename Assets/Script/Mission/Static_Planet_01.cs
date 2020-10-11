using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Static_Planet_01 : MonoBehaviour
{

    public GameObject solar_01_GO;
    public GameObject solar_02_GO;
    public GameObject solar_03_GO;
    public GameObject solar_04_GO;
    public GameObject solar_05_GO;
    public GameObject solar_engine;

    public Slider Slider;
    public GameObject panel_first;
    public GameObject panel_mission;
    public GameObject panel_mission_end;

    public TextMeshProUGUI dist_mars;
    public TextMeshProUGUI dist_jupiter;
    public TextMeshProUGUI dist_saturn;
    public TextMeshProUGUI dist_urans;
    public TextMeshProUGUI dist_neptune;

    public static int current_part = 0;

    public static int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        dist_mars.text = Vector3.Distance(Main_System.planet_mars, Main_System.planet_mars).ToString("#0");
        dist_jupiter.text = Vector3.Distance(Main_System.planet_mars, Main_System.planet_jupiter).ToString("#0");
        dist_saturn.text = Vector3.Distance(Main_System.planet_mars, Main_System.planet_saturn).ToString("#0");
        dist_urans.text = Vector3.Distance(Main_System.planet_mars, Main_System.planet_urans).ToString("#0");
        dist_neptune.text = Vector3.Distance(Main_System.planet_mars, Main_System.planet_neptune).ToString("#0");
    }

    // Update is called once per frame
    void Update()
    {
        count = 0;
        if (!Main_System.solar_01) { Destroy(solar_01_GO); count += 20; }
        if (!Main_System.solar_02) { Destroy(solar_02_GO); count += 20; }
        if (!Main_System.solar_03) { Destroy(solar_03_GO); count += 20; }
        if (!Main_System.solar_04) { Destroy(solar_04_GO); count += 20; }
        if (!Main_System.solar_05) { Destroy(solar_05_GO); count += 20; }

        if (open_dialogue.solar)
        {
            panel_first.SetActive(false);
            panel_mission.SetActive(true);
        }
      

        Slider.value = count;

        if (count == 100)
        {
            Main_System.Engine_solar = true;
            panel_mission.SetActive(false);
            panel_mission_end.SetActive(true);
        }
        
    }

}
