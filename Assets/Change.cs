using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Change : MonoBehaviour
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
        text.text = "Hello";
    }
}
