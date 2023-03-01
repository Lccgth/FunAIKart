using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateReplay.Storage;
using System;

namespace UltimateReplay.Example
{
    public class WriteReplayFile : MonoBehaviour
    {
        // Private
        private ReplayScene recordScene = null;
        private ReplayFileTarget recordStorage = null;
        private ReplayHandle recordHandle;
        private bool stop_record = false;
        private string replayname;

        // Public 
        public ReplayObject playerCar;

        // Start is called before the first frame update
        void Start()
        {
            // replayname = ReadJson.LoadData.WriteFileName + ".replay";
            replayname = "FunAI.replay";
            recordScene = new ReplayScene(playerCar);
            // change replay file name
            recordStorage = ReplayFileTarget.CreateReplayFile(replayname);
            recordHandle = ReplayManager.BeginRecording(recordStorage, recordScene);
        }

        // Update is called once per frame
        void Update()
        {
            // Check whether stop recording
            if ((CountProgress.progress == 1.0f || (TimerHUDManager.timeRemaining / 60 == 0 && TimerHUDManager.timeRemaining % 60 == 0)) && stop_record == false)
            {
                ReplayManager.StopRecording(ref recordHandle);
                recordStorage.Dispose();
                recordStorage = null;
                Debug.Log("Stop Record");
                stop_record = true;
            }
        }
    }
}
