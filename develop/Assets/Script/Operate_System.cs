using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operate_System : MonoBehaviour
{
    public int total_piece;
    public static int finish_count;
    public GameObject panel;
    public GameObject panel_CAD;

    // Start is called before the first frame update
    void Start()
    {
        finish_count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (total_piece == Operate_System.finish_count)
        {
            //UnityEngine.Debug.Log("WIN");
            //panel.SetActive(true);
            panel_CAD.SetActive(true);
        }
    }
}
