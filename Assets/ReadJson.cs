using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Networking;
using System.Threading;

public class ReadJson : MonoBehaviour
{
    public static ReplayData LoadData;
    public string s;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(File.ReadAllText("ReplaySetting.json").GetType());
        Debug.Log(s.GetType());
        StartCoroutine(GetText());
        // LoadData = JsonUtility.FromJson<ReplayData>(File.ReadAllText("ReplaySetting.json"));
    }

    IEnumerator GetText()
    {
        lock (this)
        {
            UnityWebRequest www = new UnityWebRequest("https://raw.githubusercontent.com/Lccgth/WebGL_FunAI/master/ReplaySetting.json");
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();
            Debug.Log("GetText.");

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log("failed.");
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("success.");
                Debug.Log(www.downloadHandler.data);
                s = System.Text.Encoding.ASCII.GetString(www.downloadHandler.data);
                Debug.Log(s);
                LoadData = JsonUtility.FromJson<ReplayData>(s);
                Debug.Log(LoadData.CarName);
            }
        }
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