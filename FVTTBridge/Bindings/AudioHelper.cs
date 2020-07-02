using Bridge;
using Retyped.Primitive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Retyped.dom;
using static Retyped.howler;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class AudioHelper
    {
        #region fields
        public static float levelAnalyserNativeInterval;
        public bool locked;
        public Howl[] pending;
        public dynamic sounds;
        #endregion

        #region
        public static float inputToVolume(string value, float order)
        {
            //dummy
            return -1;
        }

        public static Howl play(dynamic data,bool push)
        {
            //dummy
            return null;
        }

        public static void preload(dynamic data) { }

        public static void registerSettings() { }

        public static float volumeToInput(float volumne, float order) {
            //dummy
            return -1;
        }

        public virtual void awaitFirstGesture() { }

        public Howl create(string src, bool preload, bool autoplay) {
            //dummy
            return null;
        }

        public AudioContext getAudioContext()
        {
            //dummy 
            return null;
        }

        public void play(string src, float id) { }

        public bool startLevelReports(string id, MediaStream stream,Action<float> callback, float interval, 
            float smoothing)
        {
            //return
            return false;
        }

        public void stopLevelReports(string id) { }

        #endregion
    }
}
