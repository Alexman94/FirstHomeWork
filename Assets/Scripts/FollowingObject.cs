using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingObject : MonoBehaviour
{
    public Transform obj;
    private Vector3 deltaPos;
    
    // Start is called before the first frame update
    void Start()
    {
        deltaPos = transform.position - obj.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = deltaPos + obj.position;
    }

   
}
