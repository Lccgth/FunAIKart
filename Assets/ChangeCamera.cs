using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject camCar, camAll, camFree,camMain;
    public AudioListener listen;
    // Record current camera
    public static GameObject cam_current;

    Vector3 vec_pos = new Vector3(0, 20, 0);
  
    // Start is called before the first frame update
    void Start()
    {
        camMain.SetActive(false);
        camAll.SetActive(false);
        camFree.SetActive(false);
        camCar.SetActive(true);
        cam_current = camCar;
    }

    // Change current camera
    void Update()
    {
        // Open Cam_Car AudioListener
        if (listen.enabled != true)
            listen.enabled = true;
        if (Input.GetKey("z"))
        {
            camFree.SetActive(false);
            camAll.SetActive(false);
            camCar.SetActive(true);
            cam_current = camCar;
        }
        if (Input.GetKey("x"))
        {
            camFree.SetActive(false);
            camCar.SetActive(false);
            camAll.SetActive(true);
            cam_current = camAll;
        }
        if (Input.GetKey("c"))
        {
            camFree.transform.position = camCar.transform.position + vec_pos;
            camCar.SetActive(false);
            camAll.SetActive(false);
            camFree.SetActive(true);
            cam_current = camFree;
        }
    }
}
