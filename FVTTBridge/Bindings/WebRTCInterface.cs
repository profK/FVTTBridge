
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class WebRTCInterface{
       public WebRTCInterface(dynamic webrtc, dynamic settings){}//dummy body
       public dynamic webrtc;
       public dynamic settings;
       public dynamic initialize(){return null;}//dummy return
       public dynamic connect(dynamic optionsObject){return null;}//dummy return
       public dynamic disconnect(){return null;}//dummy return
       public dynamic initLocalStream(dynamic audioSrc, dynamic videoSrc, dynamic temporary){return null;}//dummy return
       public dynamic closeLocalStream(dynamic temporary){return null;}//dummy return
       public dynamic getStreamForUser(dynamic userId){return null;}//dummy return
       public dynamic getConnectedStreams(){return null;}//dummy return
       public dynamic assignStreamToVideo(dynamic stream, dynamic video){return null;}//dummy return
       public dynamic setAudioOutput(dynamic video, dynamic audioSinkId){return null;}//dummy return
       public dynamic getVideoSources(){return null;}//dummy return
       public dynamic getAudioSources(){return null;}//dummy return
       public dynamic getAudioSinks(){return null;}//dummy return
       public dynamic onSettingsChanged(dynamic changed){return null;}//dummy return

    }
        
}