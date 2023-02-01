using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadJson : MonoBehaviour
{
    public static ReplayData LoadData;
    // Start is called before the first frame update
    void Start()
    {
        LoadData = JsonUtility.FromJson<ReplayData>(File.ReadAllText("ReplaySetting.json"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class ReplayData
{
    public int CarNum;
    public string WriteFileName;
    public string CarName;
    public string ReplayFile;
}