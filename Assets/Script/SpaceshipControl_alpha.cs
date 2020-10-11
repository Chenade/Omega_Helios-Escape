using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SpaceshipControl_alpha : MonoBehaviour
{
    public TextMeshProUGUI Engine_Name;
    public TextMeshProUGUI Destination;
    public TextMeshProUGUI Remain_Dist;

    public GameObject menu;

    // public Text txt;
    public Slider energy_slider;
    public Slider food_slider;

    private float target;
    private float dist;
    private float dist_energy;
    public float speed = 80f;
    public Transform worm_hole;



    // Start is called before the first frame update
    void Start()
    {
        Main_System.energy = 100f;
        Main_System.food = 100f;
        energy_slider.value = Main_System.energy;
        food_slider.value = Main_System.food;

        //dist = 400*80* Time.deltaTime / Main_System.Solar_dist;
        dist = 0.04f;
    }

    private void Update()
    {
        if (transform.position == new Vector3(-449, 1503, 2333))
        {
            Debug.Log("effs");
        }
        Engine_Name.text = "Bussard Ramjet";
        Destination.text = "Alpha Centauri";

        if (!menu.activeSelf)
        {

            speed = 8000f;
            dist_energy = speed * 80 * Time.deltaTime / Main_System.Bussard_dist;

            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, worm_hole.position, step);
            Remain_Dist.text = Vector3.Distance(worm_hole.position, transform.position).ToString("#0");


            Main_System.energy -= dist_energy;
            energy_slider.value = Main_System.energy;

            Main_System.food -= dist;
            Debug.Log(dist);
            food_slider.value = Main_System.food;

        }
    }
}