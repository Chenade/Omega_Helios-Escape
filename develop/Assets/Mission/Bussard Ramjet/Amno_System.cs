using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Amno_System : MonoBehaviour
{
    public TextMeshProUGUI AmnoText;
    public GameObject panel;
    public GameObject panel_fail;
    public static int amno;

    // Start is called before the first frame update
    void Start()
    {
        
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        AmnoText.GetComponent<TextMeshProUGUI>().text = amno.ToString();

        if(amno < 0)
        {
            Cursor.lockState = CursorLockMode.Confined;
            if (Score_System.score == 9)
            {
                Cursor.lockState = CursorLockMode.None;
                Main_System.Bussard_02 = false;
                panel.SetActive(true);
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                panel_fail.SetActive(true);
            }
            
        }
}
}
