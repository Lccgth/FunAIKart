using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnableReplayCarName: MonoBehaviour
{
    public TextMeshPro text;

    // Start is called before the first frame update
    void Start()
    {
        text = FindObjectOfType<TextMeshPro>();

    }
    // Update is called once per frame
    void Update()
    {
        if (text.enabled == false)
        {
            text.enabled = true;
        }
        text.text = ReadJson.LoadData.CarName;
        Debug.Log(ChangeCamera.cam_current);

        // Let car_name follow camera
        text.transform.LookAt(ChangeCamera.cam_current.transform);
        text.transform.Rotate(Vector3.up, 180);
    }
}
