using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchReplayMode : MonoBehaviour
{
    public GameObject[] enable;
    public GameObject[] disable;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enable.Length; i++)
        {
            enable[i].SetActive(true);
            //Debug.Log("enable");
        }  

        for (int i = 0; i < disable.Length; i++)
        {
            disable[i].SetActive(false);
            //Debug.Log("disable");
        } 
        
        
    }
}
