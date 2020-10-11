using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_solar : MonoBehaviour
{
    public int index;
    void OnTriggerEnter(Collider other)
    {
        Static_Planet_01.current_part = index;
    }
}
