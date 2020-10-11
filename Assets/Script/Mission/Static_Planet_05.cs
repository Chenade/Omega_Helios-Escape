using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Static_Planet_05 : MonoBehaviour
{

    public GameObject Bussard_01_GO;
    public GameObject Bussard_02_GO;
    public GameObject Bussard_03_GO;
    public GameObject Bussard_04_GO;

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
    public GameObject Bussard_engine;

    public static int current_part = 0;
    public static int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        dist_mars.text = Vector3.Distance(Main_System.planet_neptune, Main_System.planet_mars).ToString("#0");
        dist_jupiter.text = Vector3.Distance(Main_System.planet_neptune, Main_System.planet_jupiter).ToString("#0");
        dist_saturn.text = Vector3.Distance(Main_System.planet_neptune, Main_System.planet_saturn).ToString("#0");
        dist_urans.text = Vector3.Distance(Main_System.planet_neptune, Main_System.planet_urans).ToString("#0");
        dist_neptune.text = Vector3.Distance(Main_System.planet_neptune, Main_System.planet_neptune).ToString("#0");

    }

    // Update is called once per frame
    void Update()
    {
        count = 0;
        if (!Main_System.Bussard_01) { Destroy(Bussard_01_GO); count += 25; }
        if (!Main_System.Bussard_02) { Destroy(Bussard_02_GO); count += 25; }
        if (!Main_System.Bussard_03) { Destroy(Bussard_03_GO); count += 25; }
        if (!Main_System.Bussard_04) { Destroy(Bussard_04_GO); count += 25; }

        if (open_dialogue.Bussard)
        {
            panel_first.SetActive(false);
            panel_mission.SetActive(true);
        }

        slider.value = count;


        if (count == 100)
        {
            Main_System.Engine_bussard = true;
            panel_mission.SetActive(false);
            panel_mission_end.SetActive(true);
        }
    }

}
