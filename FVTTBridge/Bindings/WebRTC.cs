
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class WebRTC{
       public dynamic _reconnectPeriodMS;
       public dynamic _speakingData;
       public dynamic _pttHandlers;
       public dynamic _pttMuteTimeout;
       public dynamic config;
       public dynamic client;
       public dynamic _broadcastingAudio;
       public dynamic _connected;
       public dynamic settings;
       public dynamic initialize(){return null;}//dummy return
       public dynamic connect(){return null;}//dummy return
       public dynamic disconnect(){return null;}//dummy return
       public dynamic _initLocalStream(){return null;}//dummy return
       public dynamic _closeLocalStream(){return null;}//dummy return
       public dynamic setVideoStream(dynamic userId, dynamic stream){return null;}//dummy return
       public dynamic render(){return null;}//dummy return
       public dynamic streamHasVideo(dynamic stream){return null;}//dummy return
       public dynamic streamHasAudio(dynamic stream){return null;}//dummy return
       public dynamic _enableMediaTracks(dynamic tracks, dynamic enable){return null;}//dummy return
       public dynamic enableStreamVideo(dynamic stream, dynamic enable){return null;}//dummy return
       public dynamic disableStreamVideo(dynamic stream){return null;}//dummy return
       public dynamic isStreamVideoEnabled(dynamic stream){return null;}//dummy return
       public dynamic enableStreamAudio(dynamic stream, dynamic enable){return null;}//dummy return
       public dynamic disableStreamAudio(dynamic stream){return null;}//dummy return
       public dynamic isStreamAudioEnabled(dynamic stream){return null;}//dummy return
       public dynamic enableCamera(dynamic enable){return null;}//dummy return
       public dynamic disableCamera(){return null;}//dummy return
       public dynamic enableMicrophone(dynamic enable){return null;}//dummy return
       public dynamic disableMicrophone(){return null;}//dummy return
       public dynamic broadcastMicrophone(dynamic broadcast){return null;}//dummy return
       public dynamic _setupVoiceDetection(dynamic stream){return null;}//dummy return
       public dynamic _stopVoiceDetection(){return null;}//dummy return
       public dynamic _pttPush(){return null;}//dummy return
       public dynamic _pttRelease(){return null;}//dummy return
       public dynamic _pttBroadcast(dynamic stream, dynamic broadcast){return null;}//dummy return
       public dynamic onSettingsChanged(dynamic changed){return null;}//dummy return
       public dynamic onUserStreamChange(dynamic userId, dynamic stream){return null;}//dummy return
       public dynamic onLocalStreamCreated(dynamic userId, dynamic stream){return null;}//dummy return
       public dynamic onError(dynamic error){return null;}//dummy return
       public dynamic onDisconnect(){return null;}//dummy return
       public dynamic _resetSpeakingHistory(dynamic userId){return null;}//dummy return
       public dynamic _onAudioLevel(dynamic userId, dynamic dbLevel){return null;}//dummy return
       public dynamic _onPTTKeyDown(dynamic event){return null;}//dummy return
       public dynamic _onPTTKeyUp(dynamic event){return null;}//dummy return
       public dynamic _onPTTMouseDown(dynamic event){return null;}//dummy return
       public dynamic _onPTTMouseUp(dynamic event){return null;}//dummy return
       public dynamic debug(params dynamic[] args){return null;}//dummy return

    }
        
}