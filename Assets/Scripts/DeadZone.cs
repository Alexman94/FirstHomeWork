using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public Transform checkPoint1;
    public Transform checkPoint2;
    public Transform respawn;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody playerRb = other.GetComponent<Rigidbody>();
        if (playerRb.CompareTag("Player"))
        {
            playerRb.velocity = new Vector3(0, 0, 0);
            playerRb.position = respawn.position;
        }
    }
}
