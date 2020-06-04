using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySwitch : MonoBehaviour
{
    public bool switchOn = false;
    public GameObject Door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switchOn = true;
            Door.GetComponent<MeshRenderer>().enabled = false;
            Door.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
