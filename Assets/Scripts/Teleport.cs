using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Switch1;
    public GameObject Switch2;
    public Transform finishTeleport1;
    public Transform finishTeleport2;
    static int count = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!(Switch1.GetComponent<MySwitch>().switchOn) || !(Switch2.GetComponent<MySwitch>().switchOn))
            {
                if (count % 2 == 0)
                    other.transform.position = finishTeleport1.position;
                else
                    other.transform.position = finishTeleport2.position;
                count++;
            }
        }
    }


}
