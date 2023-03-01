using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class EnableReplayCarName: MonoBehaviour
{
    public TextMeshPro text;

    private int tag = 0;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = FindObjectOfType<TextMeshPro>();
    }
    // Update is called once per frame
    void Update()
    {
        if (tag == 0)
        {
            timer += Time.deltaTime;
            if (timer > 2)
                tag = 1;
        }
        // Enable car name
        else
        {
            if (text.enabled == false)
            {
                text.enabled = true;
            }
            // Load json carName
            text.text = ReadJson.LoadData.CarName;

            // Let car_name follow camera
            text.transform.LookAt(ChangeCamera.cam_current.transform);
            text.transform.Rotate(Vector3.up, 180);
        }
        
    }
}
