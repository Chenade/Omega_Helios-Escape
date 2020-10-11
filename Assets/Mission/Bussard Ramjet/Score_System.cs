using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.PostProcessing;

public class Score_System : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public GameObject panel;
    public GameObject panel_fail;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
        if(score == 9)
        {
            Main_System.Bussard_02 = false;
            panel.SetActive(true);
        }
    }
}
