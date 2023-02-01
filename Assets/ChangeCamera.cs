using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject cam_car, cam_all, cam_free;

    // Record current camera
    public static GameObject cam_current;       
    // Start is called before the first frame update
    void Start()
    {
        cam_all.SetActive(false);
        cam_free.SetActive(false);
        cam_car.SetActive(true);
        cam_current = cam_car;
    }

    // Change current camera
    void Update()
    {
        if (Input.GetKey("f1"))
        {
            cam_free.SetActive(false);
            cam_all.SetActive(false);
            cam_car.SetActive(true);
            cam_current = cam_car;
        }
        if (Input.GetKey("f2"))
        {
            cam_free.SetActive(false);
            cam_car.SetActive(false);
            cam_all.SetActive(true);
            cam_current = cam_all;
        }
        if (Input.GetKey("f3"))
        {
            cam_car.SetActive(false);
            cam_all.SetActive(false);
            cam_free.SetActive(true);
            cam_current = cam_free;
        }
    }
}
