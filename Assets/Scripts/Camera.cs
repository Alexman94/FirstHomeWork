using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform transformCam;
    Transform transformParent;

    Vector3 localRotation;
    public float mouseSensitivity = 3f;
    public float orbitDampening = 10f;

    // Start is called before the first frame update
    void Start()
    {
        transformCam = transform;
        transformParent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        //Задание координат вращения в зависимости от положения мыши
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            localRotation.x += Input.GetAxis("Mouse X") * mouseSensitivity;
            localRotation.y -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        }
        if (localRotation.y < -20f)
            localRotation.y = -20f;
        else if (localRotation.y > 70f)
            localRotation.y = 70f;

        //Переводим в СК Unity
        Quaternion newCoor = Quaternion.Euler(localRotation.y, localRotation.x, 0);

        //Вращаем камеру при помощи ее родителя
        transformParent.rotation = Quaternion.Slerp(transformParent.rotation, newCoor, Time.deltaTime * orbitDampening);
    }
}
