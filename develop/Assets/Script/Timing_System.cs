using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timing_System : MonoBehaviour
{

    public TextMeshProUGUI TimeText;
    public static float time;
    public static bool is_playing = false;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_playing)
        {
            time += 1f * Time.deltaTime;
            TimeText.GetComponent<TextMeshProUGUI>().text = "Time: " + time.ToString("#0.00");
        }
       
    }
}
