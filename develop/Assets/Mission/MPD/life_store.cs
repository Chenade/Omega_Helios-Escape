using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class life_store : MonoBehaviour
{
    public static int life;
    public TextMeshProUGUI lifeleft;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        life = 5;
    }

    // Update is called once per frame
    void Update()
    {
        lifeleft.text = life.ToString();
        if(life < 0)
        {
            panel.SetActive(true);
        }
    }
}
