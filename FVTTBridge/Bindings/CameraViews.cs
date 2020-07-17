
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class CameraViews{
       public dynamic webrtc;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic setUserIsSpeaking(dynamic userId, dynamic speaking){return null;}//dummy return
       public dynamic getUserCameraView(dynamic userId){return null;}//dummy return
       public dynamic getUserVideoElement(dynamic userId){return null;}//dummy return
       public dynamic render(dynamic force, dynamic context){return null;}//dummy return
       public dynamic _render(dynamic force, dynamic options){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic _getDataForUser(dynamic user){return null;}//dummy return
       public dynamic _sortUsersData(dynamic users){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onCameraViewHover(dynamic evt){return null;}//dummy return
       public dynamic _onClickControl(dynamic evt){return null;}//dummy return
       public dynamic _onVolumeChange(dynamic evt){return null;}//dummy return
       public dynamic _setVideoDisplayMode(dynamic view, dynamic enabled){return null;}//dummy return
       public dynamic _setAudioDisplayMode(dynamic view, dynamic enabled){return null;}//dummy return
       public dynamic _setPlayerListVisibility(){return null;}//dummy return
       public dynamic _getToggleIcon(dynamic action, dynamic enabled){return null;}//dummy return
       public dynamic _getToggleTooltip(dynamic action, dynamic enabled){return null;}//dummy return
       public dynamic _getCameraBox(dynamic userId, dynamic selector){return null;}//dummy return
       public dynamic _toggleControlVisibility(dynamic container, dynamic show, dynamic selector){return null;}//dummy return

    }
        
}