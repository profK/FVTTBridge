
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class EasyRTCClient{
       public EasyRTCClient(dynamic webrtc, dynamic settings){}//dummy body
       public dynamic _callRejections;
       public dynamic _room;
       public dynamic _usernameCache;
       public dynamic initialize(){return null;}//dummy return
       public dynamic connect(dynamic optionsObject){return null;}//dummy return
       public dynamic _loginSuccess(dynamic resolve, dynamic easyRtcId){return null;}//dummy return
       public dynamic _loginFailure(dynamic resolve, dynamic errorCode, dynamic message){return null;}//dummy return
       public dynamic _setupCustomTURN(){return null;}//dummy return
       public dynamic disconnect(){return null;}//dummy return
       public dynamic initLocalStream(dynamic audioSrc, dynamic videoSrc, dynamic temporary){return null;}//dummy return
       public dynamic closeLocalStream(dynamic temporary){return null;}//dummy return
       public dynamic assignStreamToVideo(dynamic stream, dynamic video){return null;}//dummy return
       public dynamic setAudioOutput(dynamic video, dynamic audioSinkId){return null;}//dummy return
       public dynamic _createStreamForPeer(dynamic peer){return null;}//dummy return
       public dynamic _getPeerInfo(dynamic easyRtcId){return null;}//dummy return
       public dynamic _userIdToEasyRtcId(dynamic userId){return null;}//dummy return
       public dynamic getStreamForUser(dynamic userId){return null;}//dummy return
       public dynamic getConnectedStreams(){return null;}//dummy return
       public dynamic getVideoSources(){return null;}//dummy return
       public dynamic getAudioSources(){return null;}//dummy return
       public dynamic getAudioSinks(){return null;}//dummy return
       public dynamic _deviceInfoToObject(dynamic list){return null;}//dummy return
       public dynamic _onRoomOccupantsChange(dynamic roomName, dynamic otherPeople, dynamic myInfo){return null;}//dummy return
       public dynamic _performCall(dynamic easyRtcId){return null;}//dummy return
       public dynamic _answerIncomingCall(dynamic easyRtcId, dynamic acceptor){return null;}//dummy return
       public dynamic _onStreamAdded(dynamic callerEasyRtcId, dynamic stream){return null;}//dummy return
       public dynamic _onStreamClosed(dynamic easyRtcId, dynamic stream, dynamic streamName){return null;}//dummy return
       public dynamic _onError(dynamic optionsObject){return null;}//dummy return
       public dynamic _onDisconnect(){return null;}//dummy return
       public dynamic _onPeerOpen(dynamic easyRtcId){return null;}//dummy return
       public dynamic _onPeerClosed(dynamic easyRtcId){return null;}//dummy return
       public dynamic onSettingsChanged(dynamic changed){return null;}//dummy return

    }
        
}