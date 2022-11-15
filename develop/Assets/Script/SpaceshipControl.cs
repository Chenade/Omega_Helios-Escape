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

    public GameObject spaceship_basic;
    public GameObject spaceship_solarsail;
    public GameObject spaceship_mpd;
    public GameObject spaceship_nemp;
    public GameObject spaceship_buss;

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

        if(Main_System.target_index < Main_System.current_index)
        {
            transform.Rotate(0, 180, 0);
        }

        Engine_Name.text = Main_System.Engine_type;

        if (Main_System.Engine_type == "SolarSail")
        {
            speed = 400f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.Solar_dist;
            spaceship_basic.SetActive(false);
            spaceship_solarsail.SetActive(true);
            spaceship_mpd.SetActive(false);
            spaceship_nemp.SetActive(false);
            spaceship_buss.SetActive(false);
        }
        if (Main_System.Engine_type == "MassDriver")
        {
            speed = 2000f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.MassDriver_dist;
            spaceship_basic.SetActive(true);
            spaceship_solarsail.SetActive(false);
            spaceship_mpd.SetActive(false);
            spaceship_nemp.SetActive(false);
            spaceship_buss.SetActive(false);

        }
        if (Main_System.Engine_type == "MPD")
        {
            speed = 4000f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.MPD_dist;
            spaceship_basic.SetActive(false);
            spaceship_solarsail.SetActive(false);
            spaceship_mpd.SetActive(true);
            spaceship_nemp.SetActive(false);
            spaceship_buss.SetActive(false);
        }
        if (Main_System.Engine_type == "NEMP")
        {
            speed = 6400f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.NEMP_dist;
            spaceship_basic.SetActive(false);
            spaceship_solarsail.SetActive(false);
            spaceship_mpd.SetActive(false);
            spaceship_nemp.SetActive(true);
            spaceship_buss.SetActive(false);
        }
        if (Main_System.Engine_type == "Bussard")
        {
            speed = 8000f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.Bussard_dist;
            spaceship_basic.SetActive(false);
            spaceship_solarsail.SetActive(false);
            spaceship_mpd.SetActive(false);
            spaceship_nemp.SetActive(false);
            spaceship_buss.SetActive(true);
        }




        float step = speed * Time.deltaTime;
        switch (target)
        {
            case 1f:
                transform.position = Vector3.MoveTowards(transform.position, planet01.position, step);
                txt.text = "Mar, as known as 'Red Planet', is the fourth planet from the Sun and the second-smallest planet in the Solar System, being larger than only Mercury. Because of the effect of the iron oxide prevalent on Mars's surface, Mars is often referred to as 'Red Planet'. Although it is a small planet, it has the tallest mountain and deepest valley in the solar system!!";
                Remain_Dist.text = Vector3.Distance(planet01.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 2f:
                transform.position = Vector3.MoveTowards(transform.position, planet02.position, step);
                txt.text = "Europa is a moon orbiting Jupiter. Slightly smaller than Earth's Moon, Europa is primarily made of silicate rock and has a water-ice crust and probably an iron–nickel core. It has a very thin atmosphere, composed primarily of oxygen. Oneday, maybe there will be colony on the Europa for the human.";
                Remain_Dist.text = Vector3.Distance(planet02.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 3f:
                transform.position = Vector3.MoveTowards(transform.position, planet03.position, step);
                txt.text = "Titan is the largest moon of Saturn. It has a dense atmosphere which is primarily composed by nitrogen and methane. More and more evidence shows that there is not only the rain of methane but also the ocean of methane on the Titan .In the future , perhaps we can surf on the surface of Titan.";
                Remain_Dist.text = Vector3.Distance(planet03.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 4f:
                transform.position = Vector3.MoveTowards(transform.position, planet04.position, step);
                txt.text = "Uranus is the seventh planet from the Sun. The Uranus system has a unique configuration because its axis of rotation is tilted sideways, nearly into the plane of its solar orbit. Its north and south poles, therefore, lie where most other planets have their equators.";
                Remain_Dist.text = Vector3.Distance(planet04.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 5f:
                transform.position = Vector3.MoveTowards(transform.position, planet05.position, step);
                txt.text = "Neptune is the eighth planet from the Sun. Neptune's atmosphere is composed primarily of hydrogen and helium, along with traces of hydrocarbons and possibly nitrogen. Neptune’s weather is magnificent, with winds reaching speeds of almost 600 m/s nearly reaching supersonic flow!!! It must be very excited if we can fly the kite on the Neptune.";
                Remain_Dist.text = Vector3.Distance(planet05.position, transform.position).ToString("#0");
                Main_System.current_index = Main_System.target_index;
                break;
            case 6f:
                transform.position = Vector3.MoveTowards(transform.position, planet06.position, step);
                txt.text = "Alpha Centauri is the closest star system and closest planetary system to Earth's Solar System. Alpha Centauri C, or Proxima Centauri, is the closest star to the Sun at a distance of 4.24 light-years, and has two planet which may colony in the future. In fact, Alpha Centauri is a triple star system, in other words, the sun raising and the sun setting will be magnificent.";
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