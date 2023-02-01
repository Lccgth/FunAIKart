using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CountProgress : MonoBehaviour
{
    public static GameObject[] progress_node;         // store all progress node
    GameObject kart;                    // get kart object
    Vector3 kart_position;              // get kart position

    int previous = 0;
    public static int current = 0;

    public static float diff_distance;                
    public static float progress;                     // current progress

    // Start is called before the first frame update
    void Start()
    {
        // Using FindGameObjectsWithTag needs to sort
        progress_node = GameObject.FindGameObjectsWithTag("Progress").OrderBy(g => Convert.ToInt32(g.name)).ToArray();
        kart = GameObject.Find("PAIAKart 1");
    }

    // Update is called once per frame
    void Update()
    {
        int Max = 1000000;
        kart_position = kart.transform.position;

        for (int i = previous - 5; i < previous + 5; i++)
        {
            if (i < 0 || i > progress_node.Length-1)
            {
                continue;
            }

            Vector3 temp = progress_node[i].transform.position;
            diff_distance = (kart_position - temp).sqrMagnitude;

            if (diff_distance < Max)
            {
                Max = Convert.ToInt32(diff_distance);
                current = i;
            }
        }
        previous = current;
        progress = (Convert.ToSingle(current) / Convert.ToSingle(progress_node.Length-1)) ;
        Debug.Log("Progress = " +progress );
    }
    
}
