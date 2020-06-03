using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySwitch : MonoBehaviour
{
    public bool switchOn = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switchOn = true;
        }
    }
}
