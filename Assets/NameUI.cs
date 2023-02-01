using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameUI : MonoBehaviour
{
    public Transform tans;
    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = tans.position;
        this.transform.rotation = cam.rotation;
    }
}
