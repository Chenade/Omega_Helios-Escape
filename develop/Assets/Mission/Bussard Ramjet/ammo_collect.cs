using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ammo_collect : MonoBehaviour
{
    public string type;

    private void Start()
    {
        Amno_System.amno = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        switch (type)
        {
            case "h_11":
                Amno_System.amno += 1;
                break;

            case "h_21":
                Amno_System.amno += 3;
                break;

            case "h_31":
                Amno_System.amno += 5;
                break;

            case "next_level":
                SceneManager.LoadScene(19);
                break;
        }
        Destroy(gameObject);
    }
}
