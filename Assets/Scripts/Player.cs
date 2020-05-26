using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRb;
    public float force;
    public Transform cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W)) playerRb.AddForce(cameraPos.forward * force);
        if (Input.GetKey(KeyCode.S)) playerRb.AddForce(-cameraPos.forward * force);
        if (Input.GetKey(KeyCode.A)) playerRb.AddForce(-cameraPos.right * force);
        if (Input.GetKey(KeyCode.D)) playerRb.AddForce(cameraPos.right * force);

    }
}
