
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class PlaylistSoundConfig{
       public dynamic playlist;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic title(){return null;}//dummy return
       public dynamic getData(){return null;}//dummy return
       public dynamic _updateObject(dynamic event, dynamic formData){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onSourceChange(dynamic event){return null;}//dummy return

    }
        
}