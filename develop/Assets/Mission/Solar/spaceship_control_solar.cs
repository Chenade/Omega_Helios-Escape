using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class spaceship_control_solar : MonoBehaviour
{

    public CharacterController controller;
    public TextMeshProUGUI LifeLeft;
    public GameObject panel;
    public GameObject panel_win;

    public float speed = 2f;
    public float gravity = 9.81f;
    public float jumpheight = 0.5f;

    public static int life;
    Vector3 velocity;

    public Slider mainSlider;
    // Start is called before the first frame update
    void Start()
    {
        mainSlider.value = 0;
        spaceship_control_solar.life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        LifeLeft.GetComponent<TextMeshProUGUI>().text = spaceship_control_solar.life.ToString("#0");
        float x = mainSlider.value;

        if (x < 0) x += 1;
        else x -= 1;
        //Debug.Log(x);
        Vector3 move = transform.right * x;
        controller.Move(move * speed * Time.deltaTime);

        if(Timing_solar.time <= 0)
        {
            Die();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (Main_System.solar_04 && other.transform.name != "Spaceship")
        {
            spaceship_control_solar.life -= 1;
            Destroy(other);
          
            if (spaceship_control_solar.life < 0) Die();
        }
    }

    void Die()
    {
        if(spaceship_control_solar.life > -1 && Timing_solar.time < 1)
        {
            UnityEngine.Debug.Log("WIN");
            Main_System.solar_04 = false;
            panel_win.SetActive(true);
        }
        else
        {
            panel.SetActive(true);
            UnityEngine.Debug.Log("BOOM");
        }

    }


}
