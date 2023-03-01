using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateReplay.Storage;
using System.IO;
using System.Threading;


namespace UltimateReplay.Example
{
    public class ReadReplayFile : MonoBehaviour
    {
        // Private
        private ReplayScene playbackScene = null;
        private ReplayFileTarget playbackStorage = null;
        private ReplayHandle playbackHandle;
        private string readModel;
        private int tag = 0;
        private float timer = 0;

        // Public
        public ReplayObject playerCar;
        public ReplayObject ghostCar;


        // Start is called before the first frame update
        void Start()
        {
            // From Read_Json get replay model name
            // Debug.Log("Current Path = " + System.Environment.CurrentDirectory);
            // readModel = ReadJson.LoadData.ReplayFile;
            // ReplayObject.CloneReplayObjectIdentity(playerCar, ghostCar);
            // playbackScene = new ReplayScene(ghostCar);
            // playbackStorage = ReplayFileTarget.ReadReplayFile(readModel);
            // playbackHandle = ReplayManager.BeginPlayback(playbackStorage, playbackScene);
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
            else if(tag == 1)
            {
                readModel = ReadJson.LoadData.ReplayFile;
                ReplayObject.CloneReplayObjectIdentity(playerCar, ghostCar);
                playbackScene = new ReplayScene(ghostCar);
                playbackStorage = ReplayFileTarget.ReadReplayFile(readModel);
                playbackHandle = ReplayManager.BeginPlayback(playbackStorage, playbackScene);
                tag = 2;
            }
        }
    }
}