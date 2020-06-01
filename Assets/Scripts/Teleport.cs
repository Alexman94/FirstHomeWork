using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform finishTeleport;
    bool teleportation = true;
    static int count = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (teleportation && (count % 3) != 0)
            {
                other.transform.position = finishTeleport.position;
            }
            count++;
        }
    }
}
