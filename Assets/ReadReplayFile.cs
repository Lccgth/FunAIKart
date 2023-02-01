using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateReplay.Storage;


namespace UltimateReplay.Example
{
    public class ReadReplayFile : MonoBehaviour
    {
        // Private
        private ReplayScene playbackScene = null;
        private ReplayFileTarget playbackStorage = null;
        private ReplayHandle playbackHandle;
        private string readModel;

        // Public
        public ReplayObject playerCar;
        public ReplayObject ghostCar;

        // Start is called before the first frame update
        void Start()
        {
            // From Read_Json get replay model name
            readModel = ReadJson.LoadData.ReplayFile;
            ReplayObject.CloneReplayObjectIdentity(playerCar, ghostCar);
            playbackScene = new ReplayScene(ghostCar);
            playbackStorage = ReplayFileTarget.ReadReplayFile(readModel);
            playbackHandle = ReplayManager.BeginPlayback(playbackStorage, playbackScene);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}