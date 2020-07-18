
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class AudioHelper{
       public AudioHelper(){}//dummy body
       public dynamic _analyserStreams;
       public dynamic _audioContext;
       public dynamic sounds;
       public dynamic _fftArray;
       public dynamic pending;
       public dynamic _analyserInterval;
       public dynamic locked;
       public dynamic registerSettings(){return null;}//dummy return
       public dynamic create(dynamic optionsObject){return null;}//dummy return
       public dynamic play(dynamic src, dynamic id){return null;}//dummy return
       public dynamic awaitFirstGesture(){return null;}//dummy return
       public dynamic _onFirstGesture(dynamic evt){return null;}//dummy return
       public dynamic preload(dynamic data){return null;}//dummy return
       public dynamic socketListeners(dynamic socket){return null;}//dummy return
       //public dynamic play(dynamic data, dynamic push){return null;}//dummy return
       //public dynamic preload(dynamic data){return null;}//dummy return
       public dynamic inputToVolume(dynamic value, dynamic order){return null;}//dummy return
       public dynamic volumeToInput(dynamic volume, dynamic order){return null;}//dummy return
       public dynamic hasAudioExtension(dynamic src){return null;}//dummy return
       public dynamic getAudioContext(){return null;}//dummy return
       public dynamic startLevelReports(dynamic id, dynamic stream, dynamic callback, dynamic interval, dynamic smoothing){return null;}//dummy return
       public dynamic stopLevelReports(dynamic id){return null;}//dummy return
       public dynamic _ensureAnalyserTimer(){return null;}//dummy return
       public dynamic _cancelAnalyserTimer(){return null;}//dummy return
       public dynamic _emitVolumes(){return null;}//dummy return

    }
        
}