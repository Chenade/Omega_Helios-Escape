using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timing_solar : MonoBehaviour
{

    public TextMeshProUGUI TimeText;
    public static float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timing_solar.time > 0)
        {
            time -= 1f * Time.deltaTime;
            TimeText.GetComponent<TextMeshProUGUI>().text = time.ToString("#0");
        }
    }
}
