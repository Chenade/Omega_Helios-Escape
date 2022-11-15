using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Time_count : MonoBehaviour
{

    public TextMeshProUGUI TimeText;
    public static float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1f * Time.deltaTime;
        TimeText.GetComponent<TextMeshProUGUI>().text = time.ToString("#0.00");
    }
}
