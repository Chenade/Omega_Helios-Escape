using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Static_BassardRamjet : MonoBehaviour
{

    public static bool Bass_01 = true;
    public static bool Bass_02 = true;
    public static bool Bass_03 = true;
    public static bool Bass_04 = true;
    public static bool Bass_05 = true;

    public static int current_part = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        switch (current_part)
        {
            case 99:
                SceneManager.LoadScene(2);
                current_part = 0;
                break;
            case 1:
                if (Bass_01)
                {
                    SceneManager.LoadScene(5);
                }
                break;
            case 2:
                if (Bass_02)
                {
                    SceneManager.LoadScene(2);
                }
                break;
            case 3:
                if (Bass_03)
                {
                    SceneManager.LoadScene(2);
                }
                break;
            case 4:
                if (Bass_04)
                {
                    SceneManager.LoadScene(2);
                }
                break;
            case 5:
                if (Bass_05)
                {
                    SceneManager.LoadScene(2);
                }
                break;
        }
    }

}
