using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnableGameCarName : MonoBehaviour
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
        // text.text = Progress_count.progress.ToString();
       
    }
}
