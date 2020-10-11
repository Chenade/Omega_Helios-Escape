using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SpaceshipControl : MonoBehaviour
{
    public TextMeshProUGUI Engine_Name;
    public TextMeshProUGUI Destination;
    public TextMeshProUGUI Remain_Dist;

    public TextMeshProUGUI dist_mars;
    public TextMeshProUGUI dist_jupiter;
    public TextMeshProUGUI dist_saturn;
    public TextMeshProUGUI dist_uranus;
    public TextMeshProUGUI dist_neptune;
    public TextMeshProUGUI dist_toilman;

    public GameObject menu;
    public GameObject panel_die;

    public Text txt;
    public Slider energy_slider;
    public Slider food_slider;

    private float target;
    private float dist;
    private float dist_energy;
    public float speed = 80f;

    public Transform planet01;
    public Transform planet02;
    public Transform planet03;
    public Transform planet04;
    public Transform planet05;
    public Transform planet06;
    public Transform planet07;
    public Transform planet08;
    public Transform planet_hole;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
       

        Main_System.planet_mars = planet01.transform.position;
        Main_System.planet_jupiter = planet02.transform.position;
        Main_System.planet_saturn = planet03.transform.position;
        Main_System.planet_urans = planet04.transform.position;
        Main_System.planet_neptune = planet05.transform.position;

        Main_System.energy = 100f;
        Main_System.food = 100f;
        energy_slider.value = Main_System.energy;
        food_slider.value = Main_System.food;
        count = 0;

        //dist = 400*80* Time.deltaTime / Main_System.Solar_dist;
        dist = 0.04f;

        dist_mars.text = Vector3.Distance(planet01.position, transform.position).ToString("#0");
        dist_jupiter.text = Vector3.Distance(planet02.position, transform.position).ToString("#0");
        dist_saturn.text = Vector3.Distance(planet03.position, transform.position).ToString("#0");
        dist_uranus.text = Vector3.Distance(planet04.position, transform.position).ToString("#0");
        dist_neptune.text = Vector3.Distance(planet05.position, transform.position).ToString("#0");
        dist_toilman.text = Vector3.Distance(planet06.position, transform.position).ToString("#0");

        switch (Main_System.current_index)
        {
            case 1:
                transform.position = planet01.transform.position;
                break;
            case 2:
                transform.position = planet02.transform.position;
                break;
            case 3:
                transform.position = planet03.transform.position;
                break;
            case 4:
                transform.position = planet04.transform.position;
                break;
            case 5:
                transform.position = planet05.transform.position;
                break;
        }

    }

    private void Update()
    {
        Debug.Log(speed);
        target = Main_System.target_index;
        Engine_Name.text = Main_System.Engine_type;
        Destination.text = Main_System.destination;
        count += 1;

        if(count % 10 == 0)
        {
            dist_mars.text = Vector3.Distance(planet01.position, transform.position).ToString("#0");
            dist_jupiter.text = Vector3.Distance(planet02.position, transform.position).ToString("#0");
            dist_saturn.text = Vector3.Distance(planet03.position, transform.position).ToString("#0");
            dist_uranus.text = Vector3.Distance(planet04.position, transform.position).ToString("#0");
            dist_neptune.text = Vector3.Distance(planet05.position, transform.position).ToString("#0");
            dist_toilman.text = Vector3.Distance(planet06.position, transform.position).ToString("#0");            
        }

        if (!menu.activeSelf && !panel_die.activeSelf)
        {

            set_target(target);

            Main_System.energy -= dist_energy;
            energy_slider.value = Main_System.energy;
            //Debug.Log(Main_System.MassDriver_dist);
            //Debug.Log(dist_energy);

            Main_System.food -= dist;
            food_slider.value = Main_System.food;

        }

        if (Main_System.food < 1 || Main_System.energy < 1)
        {
            panel_die.SetActive(true);
        }
    }
   

    public void set_target(float planet)
    {
        Engine_Name.text = Main_System.Engine_type;

        if (Main_System.Engine_type == "SolarSail")
        {
            speed = 400f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.Solar_dist;
        }
        if (Main_System.Engine_type == "MassDriver")
        {
            speed = 2000f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.MassDriver_dist;
            
        }
        if (Main_System.Engine_type == "MPD")
        {
            speed = 4000f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.MPD_dist;
        }
        if (Main_System.Engine_type == "NEMP")
        {
            speed = 6400f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.NEMP_dist;
        }
        if (Main_System.Engine_type == "Bussard")
        {
            speed = 8000f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.Bussard_dist;
        }




        float step = speed * Time.deltaTime;
        switch (target)
        {
            case 1f:
                transform.position = Vector3.MoveTowards(transform.position, planet01.position, step);
                txt.text = "Mars, also known as the 'Red Planet', is the fourth closest planet to the sun and the second smallest planet in the solar system after Mercury. It is one of the four terrestrial planets in the solar system. It is called the 'Red Planet' because the surface is covered with iron oxide. And the little red planet has the highest mountains and valleys in the solar system!!";
                Remain_Dist.text = Vector3.Distance(planet01.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 2f:
                transform.position = Vector3.MoveTowards(transform.position, planet02.position, step);
                txt.text = "Europa, also known as 'Europa', is one of Jupiter's natural satellites. Europa is slightly smaller than the moon, and has a water-ice crust, and possibly an iron-nickel core; it has a thin atmosphere, mainly composed of oxygen, so in the distant future, we may be able to migrate to it. ";
                Remain_Dist.text = Vector3.Distance(planet02.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 3f:
                transform.position = Vector3.MoveTowards(transform.position, planet03.position, step);
                txt.text = "Titan, also known as 'Titan', is the largest of Saturn's moons. Titan has a thick atmosphere, and its main components are nitrogen and methane. Scientists speculate that there may not only be rain on Titan, but also the sea, but the composition is methane. Maybe one day in the future, we may be able to surf on it. ";
                Remain_Dist.text = Vector3.Distance(planet03.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 4f:
                transform.position = Vector3.MoveTowards(transform.position, planet04.position, step);
                txt.text = "Uranus is the seventh planet from the inside to the outside of the solar system. The ring system of Uranus is very special, because its rotation axis lies almost on the orbital plane of the orbiting sun, so the South Pole and North Pole also lie on other planets At the equator of. From the earth, Uranus’s ring looks like a ring around the target.";
                Remain_Dist.text = Vector3.Distance(planet04.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 5f:
                transform.position = Vector3.MoveTowards(transform.position, planet05.position, step);
                txt.text = "Neptune is the farthest from the sun among the eight planets in the solar system. The atmosphere of Neptune is dominated by hydrogen and helium, and there are traces of methane. Because it is the farthest from the sun, it is, on average, one of the coldest regions in the solar system , It seems that the manufacturers of ice machines should not enter Neptune in the future.";
                Remain_Dist.text = Vector3.Distance(planet05.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 6f:
                transform.position = Vector3.MoveTowards(transform.position, planet06.position, step);
                txt.text = "South Gate 2 is the star system closest to the sun, of which Alpha Centauri C is the closest star to us. Two planets have been discovered so far, and colonies may be established here later, although the naked eye cannot distinguish Come out, Nanmen 2 is actually a triple star system, which means that the sunrise and sunset on the colony must be exceptionally wonderful.";
                Remain_Dist.text = Vector3.Distance(planet06.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 7f:
                transform.position = Vector3.MoveTowards(transform.position, planet07.position, step);
                Remain_Dist.text = Vector3.Distance(planet07.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 8f:
                transform.position = Vector3.MoveTowards(transform.position, planet08.position, step);
                Remain_Dist.text = Vector3.Distance(planet08.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;

            case 99f:
                transform.position = Vector3.MoveTowards(planet06.position, planet_hole.position, step);
                Remain_Dist.text = Vector3.Distance(planet_hole.position, planet06.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
        }
    }
}